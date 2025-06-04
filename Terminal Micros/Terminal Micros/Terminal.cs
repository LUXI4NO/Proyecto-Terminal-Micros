using System;
using System.Collections;

namespace Terminal_Micros
{
    public class Terminal
    {
        public string Nombre { get; set; }
        public ArrayList ListaMicros { get; set; }
        public int VentasRechazadas { get; set; }

        public Terminal(string nombre)
        {
            Nombre = nombre;
            ListaMicros = new ArrayList();
            VentasRechazadas = 0;
        }

        public void AgregarMicros(Micros micro)
        {
            ListaMicros.Add(micro);
            Console.WriteLine(micro.Codigo + " " + micro.Destino + " " + micro.Patente + " " + micro.Precio_pasaje);
        }

        public void VentaPasajes(int codigoMicro, string dni, string apellido)
        {
            foreach (Micros m in ListaMicros)
            {
                if (m.Codigo == codigoMicro)
                {
                    if (m.CupoLibre > 0)
                    {
                        Pasajeros nuevo = new Pasajeros(dni, apellido);
                        m.ListaPasajeros.Add(nuevo);
                        m.CupoLibre -= 1;
                        Console.WriteLine("El pasaje fue vendido a: " + dni + " " + apellido);
                    }
                    else
                    {
                        Console.WriteLine("No hay más cupos disponibles.");
                        VentasRechazadas += 1;
                    }
                    return;
                }
            }

            Console.WriteLine("Micro no encontrado.");
        }

        public void MostrarPorcentajePasajesVendidosConDuracionMayorA6Horas()
        {
            int totalVendidos = 0;
            int vendidosMas6hs = 0;

            foreach (Micros m in ListaMicros)
            {
                int vendidos = m.ListaPasajeros.Count;
                totalVendidos += vendidos;

                if (m.DuracionDeViaje > 360)
                {
                    vendidosMas6hs += vendidos;
                }
            }

            if (totalVendidos > 0)
            {
                double porcentaje = (double)vendidosMas6hs / totalVendidos * 100;
                Console.WriteLine("Porcentaje de pasajes vendidos en micros con viaje > 6hs: " + porcentaje + "%");
            }
            else
            {
                Console.WriteLine("No se vendieron pasajes.");
            }
        }

        public void MostrarVentasRechazadas()
        {
            Console.WriteLine("Ventas rechazadas por falta de cupo: " + VentasRechazadas);
        }
    }
}
