﻿using System;

namespace CapaEntidades
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public String Nombres { get; set; }
        public String ApPaterno { get; set; }
        public String ApMaterno { get; set; }
        public int Edad { get; set; }
        public char Sexo { get; set; }
        public String NroDocumento { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public bool Estado { get; set; }
        public String Imagen { get; set; }

        public Paciente()
        {
        }

        public Paciente(int IdPaciente, string Nombres, string ApPaterno, string ApMaterno, int Edad, char Sexo, string NroDocumento, string Direccion, string Telefono, bool Estado, string Imagen)
        {
            this.IdPaciente = IdPaciente;
            this.Nombres = Nombres;
            this.ApPaterno = ApPaterno;
            this.ApMaterno = ApMaterno;
            this.Edad = Edad;
            this.Sexo = Sexo;
            this.NroDocumento = NroDocumento;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Estado = Estado;
            this.Imagen = Imagen;
        }
    }
}
