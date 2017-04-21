﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria.Models
{
    public class Consultas
    {

        [Key]
        public int ConsultaID { get; set; }

        [Column(TypeName = "date")] //só regista 'datas', não 'horas'
        public DateTime DataConsulta { get; set; }


        [ForeignKey("Veterinario")]
        public int VeterinarioFK { get; set; }
        public virtual Veterinarios Veterinario { get; set; }


        [ForeignKey("Animal")]
        public int AnimalFK { get; set; }
        public virtual Animais Animal { get; set; }




    }
}