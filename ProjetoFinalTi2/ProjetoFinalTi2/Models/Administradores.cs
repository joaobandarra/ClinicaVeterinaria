using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFinalTi2.Models
{
    public class Administradores
    {

        [Key]
        public int IdAmin{ get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        [Required]
        [StringLength(10)]
        public string EstadoLogin { get; set; }

        [Required]
        [StringLength(50)]
        public string NomeAdmin { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

    }
}