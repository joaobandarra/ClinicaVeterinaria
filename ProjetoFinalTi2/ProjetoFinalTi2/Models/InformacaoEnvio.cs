using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFinalTi2.Models
{
    public class InformacaoEnvio
    {
        [Key]
        public int IdEnvio { get; set; }

        [StringLength(10)]
        public string TipoEnvio { get; set; }

        public float CustoEnvio { get; set; }

        public int IdRegiaoEnvio { get; set; }
    }
}