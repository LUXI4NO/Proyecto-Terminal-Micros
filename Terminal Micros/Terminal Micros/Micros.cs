using System.Collections;

namespace Terminal_Micros
{
    public class Micros
    {
        public int Codigo { get; set; }
        public string Patente { get; set; }
        public double Precio_pasaje { get; set; }
        public string Destino { get; set; }
        public int CupoLibre { get; set; }
        public int DuracionDeViaje { get; set; }
        public ArrayList ListaPasajeros { get; set; }

        public Micros(int cod, string patente, double precio, string destino, int cupolibre, int duracion)
        {
            Codigo = cod;
            Patente = patente;
            Precio_pasaje = precio;
            Destino = destino;
            CupoLibre = cupolibre;
            DuracionDeViaje = duracion;
            ListaPasajeros = new ArrayList();
        }
    }
}
