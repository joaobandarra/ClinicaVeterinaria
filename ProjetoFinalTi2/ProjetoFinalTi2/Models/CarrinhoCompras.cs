using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoFinalTi2.Models
{
    public class CarrinhoCompras
    {
        [Key]
        public int IdCarrinho { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DataAdicao { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public int NumProduto { get; set; }
    }
}