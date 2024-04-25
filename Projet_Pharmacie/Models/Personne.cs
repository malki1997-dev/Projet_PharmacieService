
using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_PharmaService.Models
{
    [NotMapped] 
    
    public class Personne
    {
        protected string Nom { get; set; }
        protected string Prenom { get; set; }
        protected DateTime DateNaissance { get; set; }
        protected string Adresse { get; set; }
       
        protected string AdresseEmail { get; set; }
        protected string Telephone { get; set; }
     
       


    }
}
