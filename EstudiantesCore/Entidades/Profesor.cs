﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstudiantesCore.Entidades
{
    [Table("Profesor", Schema = "GE")]
    public class Profesor
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Nombre { get; set; }

        public int Apellido { get; set; }

        public string Documento { get; set; }

        public TipoDocumento TipoDocumento { get; set; }

        public EstadoProfesor Estado { get; set; }
    }
}
