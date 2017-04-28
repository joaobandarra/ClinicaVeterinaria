using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFinalTi2.Models
{
    public class CarrinhoComprasProduto
    {

        [Key]
        public int ID { get; set; }

        public int IdCarrinho { get; set; }
        public int IdProduto { get; set; }



    }
}