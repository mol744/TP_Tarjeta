using System;
using tarjeta;

namespace colectivo
{
    public class Colectivo
    {
        string linea;
        public float tarifa;
        float recuento;
        int pagosInvalidos;
        int pagosValidos;

        public Colectivo(string l, float t)
        {
            linea = l;
            tarifa = t;
        }

        public void mostrar_tarifa()
        {
            Console.WriteLine($"Valor tarifa: ${tarifa}\n\n");
        }

        public void nuevoPasajero(Tarjeta tarj)
        {
            if ((tarj.saldo - tarifa) < 0)
            {
                Console.WriteLine("Saldo INSUFICIENTE.\n\n");
                mostrarSaldo(tarj);
                pagosInvalidos++;
            }
            else
            {
                Console.WriteLine("Pago realizado.\n");
                tarj.pagarBoleto(tarifa);
                mostrarSaldo(tarj);
                pagosValidos++;
                recuento += tarifa;
            }
        }
        public void mostrarSaldo(Tarjeta tarj)
        {
            Console.WriteLine($"Saldo Actual: '${tarj.saldo}'\n\n");
        }
    }
}
