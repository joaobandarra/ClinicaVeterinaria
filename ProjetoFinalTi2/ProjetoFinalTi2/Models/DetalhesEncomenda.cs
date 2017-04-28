using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFinalTi2.Models
{
    public class DetalhesEncomenda
    {
        [Key]
        public int IdDetalhe { get; set; }

        [StringLength(50)]
        public string NomeProduto { get; set; }

        public int Quantidade { get; set; }

   
        public float PrecoUnitario { get; set; }


        public float PrecoEncomenda { get; set; }
    }
}