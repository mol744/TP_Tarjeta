using System;

namespace tarjeta
{
    public class Tarjeta
    {
        public int nro;
        public float saldo;
        float saldoMax = 40000;

        public Tarjeta(int nroNuevo)
        {
            nro = nroNuevo;
            saldo = 0;
        }

        public void cargarSaldo(float saldoACargar)
        {
            if ((saldo + saldoACargar) >= 40000)
            {
                Console.WriteLine($"El saldo final no puede exceder el valor de '${saldoMax}'. Revisa tu saldo actual y vuelve a intentarlo.");

            }
            else
            {
                saldo += saldoACargar;
                Console.WriteLine($"Se efectuó la carga exitosamente.Tu nuevo saldo es '${saldo}'\n\n");
            }

        }

        public void pagarBoleto(float tarifa)
        {
            if ((saldo - tarifa) < 0)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            saldo -= tarifa;
            Console.WriteLine($"Pago realizado. Nuevo saldo: '${saldo}'");
        }
    }
}