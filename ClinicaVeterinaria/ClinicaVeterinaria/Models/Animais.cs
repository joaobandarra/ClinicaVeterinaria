using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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


        //***************************************************************************
        //  criar a chave forasteira
        //  Um animal tem um dono
        //***************************************************************************
        [ForeignKey("DonoFK")]
        public Donos Dono { get; set; } // relaciona, no c#, um animal com o seu dono
        public int DonoFK { get; set; } // na BD vai criar a foreign key


    }
}