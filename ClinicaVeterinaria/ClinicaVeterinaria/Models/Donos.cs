using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicaVeterinaria.Models
{
    public class Donos
    {
        //********************************************************
        //  criar um construtor para inicializar
        //  ListaDosMeusAnimais
        //********************************************************
        public Donos() {
            ListaDosMeusAnimais = new HashSet<Animais>();
        }


        public int ID { get; set; } //por se chamar ID, será PK

        public string Nome { get; set; }

        public string NIF { get; set; }

        //********************************************************
        //  informar a classe que 
        //  um dono tem muitos animais
        //********************************************************
        public virtual ICollection<Animais> ListaDosMeusAnimais { get; set; }



    }
}