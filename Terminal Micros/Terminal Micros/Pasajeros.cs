﻿namespace Terminal_Micros
{
    public class Pasajeros
    {
        public string DNI { get; set; }
        public string Apellido { get; set; }

        public Pasajeros(string dni, string apellido)
        {
            DNI = dni;
            Apellido = apellido;
        }
    }
}
