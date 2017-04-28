using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFinalTi2.Models
{
    public class Cliente
    {
        
        [Key]
        public int IdCliente { get; set; }


        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        [Required]
        [StringLength(10)]
        public string EstadoLogin { get; set; }

        [Required]
        [StringLength(50)]
        public string NomeUtilizador { get; set; }

        [Required]
        [StringLength(255)]
        public string Morada { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string InformacaoCartaoCredito { get; set; }

        [Required]
        [StringLength(255)]
        public string InformacaoEnvio { get; set; }






    }
}