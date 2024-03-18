﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Modelos
{
    public class Usuario
    {
        public int IdUsuario {  get; set; }

        public int IDPersona { get; set; }

        public string NombreUser { get; set; }

        public string Contraseña {  get; set; }

        public DateTime FechaReg {  get; set; }


    }
}