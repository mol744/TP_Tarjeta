using System;

namespace boleto
{
    public class Boleto
    {
        string fechaYHora;
        float tarifa;
        int nroTarjeta;

        public Boleto(string fecha, float t, int nroT)
        {
            tarifa = t;
            nroTarjeta = nroT;
            fechaYHora = fecha;
        }

        public void imprimir_boleto()
        {
            Console.WriteLine($"|fecha: {fechaYHora}|tarifa: {tarifa}|nro: {nroTarjeta}\n\n");
        }

    }
}
