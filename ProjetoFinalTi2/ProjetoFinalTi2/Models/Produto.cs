using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFinalTi2.Models
{
    public class Produto
    {
        [key]
        public int IdProduto { set; get; }


        [StringLength(50)]
        public string Nome { get; set; }

        [StringLength(255)]
        public string Descricao { get; set; }

        
        public float Preco { get; set; }

       
    }
}