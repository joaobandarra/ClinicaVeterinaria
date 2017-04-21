using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClinicaVeterinaria.Models
{
    public class VetsDB : DbContext
    {

        //**********************************************************
        //  informar a entity framework que as classes abaixo 
        //  descritas devem ser associadas a uma base de dados
        //**********************************************************
        public virtual DbSet<Donos> Donos { get; set; }

        public virtual DbSet<Animais> Animais { get; set; }

        public virtual DbSet<Consultas> Consultas { get; set; }

        public virtual DbSet<Veterinarios> Veterinarios { get; set; }
        //**********************************************************
        //  onde criar e de que tipo será a base de dados
        //**********************************************************
        public VetsDB() :base("localizacaoDaBD") {
                
        }


    }
}