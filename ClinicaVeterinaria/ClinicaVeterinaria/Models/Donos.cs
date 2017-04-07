using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicaVeterinaria.Models
{
    public class Donos
    {

        public int ID { get; set; } //por se chamar ID, será PK

        public string Nome { get; set; }

        public string NIF { get; set; }
    }
}