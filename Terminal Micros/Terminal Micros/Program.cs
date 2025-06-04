using System;

namespace Terminal_Micros
{
    class Program
    {
        static void Main(string[] args)
        {
            Terminal terminal = new Terminal("Terminal Luciano");

            Console.WriteLine("CARGA DE MICROS");
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Código: ");
                int cod = int.Parse(Console.ReadLine());

                Console.WriteLine("Patente: ");
                string pat = Console.ReadLine();

                Console.WriteLine("Precio pasaje: ");
                double precio = double.Parse(Console.ReadLine());

                Console.WriteLine("Destino: ");
                string destino = Console.ReadLine();

                Console.WriteLine("Cupo libre: ");
                int cupo = int.Parse(Console.ReadLine());

                Console.WriteLine("Duración del viaje (en minutos): ");
                int duracion = int.Parse(Console.ReadLine());

                Micros micro = new Micros(cod, pat, precio, destino, cupo, duracion);
                terminal.AgregarMicros(micro);

                Console.WriteLine("¿Desea agregar otro micro? (si/no): ");
                string resp = Console.ReadLine();
                if (resp.ToLower() == "no")
                    continuar = false;
            }

            Console.WriteLine("VENTA DE PASAJES");
            continuar = true;
            while (continuar)
            {
                Console.WriteLine("Ingrese código del micro: ");
                int codMicro = int.Parse(Console.ReadLine());

                Console.WriteLine("DNI del pasajero: ");
                string dni = Console.ReadLine();

                Console.WriteLine("Apellido del pasajero: ");
                string apellido = Console.ReadLine();

                terminal.VentaPasajes(codMicro, dni, apellido);

                Console.WriteLine("¿Desea vender otro pasaje? (si/no): ");
                string resp = Console.ReadLine();
                if (resp.ToLower() == "no")
                    continuar = false;
            }

            Console.WriteLine("\nRESÚMEN FINAL:");
            terminal.MostrarPorcentajePasajesVendidosConDuracionMayorA6Horas();
            terminal.MostrarVentasRechazadas();

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
