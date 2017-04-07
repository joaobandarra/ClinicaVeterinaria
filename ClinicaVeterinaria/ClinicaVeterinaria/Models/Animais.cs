using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicaVeterinaria.Models
{
    public class Animais
    {
        public int AnimaisID { get; set; } //por ser 'nome da classe' + ID, será PK

        public string Nome { get; set; }

        public string Raca { get; set; }

        public string Especie { get; set; }

        public int Idade { get; set; }

        public double Peso { get; set; }

    }
}