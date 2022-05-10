﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EstudiantesCore.Dtos
{
    class EstudianteDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Documento { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Sexo { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public DateTime FechaIngreso { get; set; }

        public DateTime FechaEgreso { get; set; }

        public DateTime FechaRetiro { get; set; }

        public Entidades.TipoDocumento TipoDocumento { get; set; }

        public Entidades.EstadoEstudiante Estado { get; set; }
    }
}
