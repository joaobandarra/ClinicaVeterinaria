using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFinalTi2.Models
{
    public class Encomenda
    {

        [Key]
        public int IdEncomenda { get; set; }

        public DateTime DataCriacaoEncomenda { get; set; }

        public DateTime DataEnvioEncomenda { get; set; }

        [StringLength(50)]
        public string NomeCliente{ get; set; }

        [StringLength(10)]
        public string Estadocompra { get; set; }



    }
}