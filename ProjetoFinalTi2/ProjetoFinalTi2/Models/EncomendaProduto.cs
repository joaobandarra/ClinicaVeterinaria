using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFinalTi2.Models
{
    public class EncomendaProduto
    {

        [Key]
        public int IdProduto { set; get; }
        public int IdEncomenda { set; get; }


    }
}