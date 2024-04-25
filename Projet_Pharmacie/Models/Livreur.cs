
using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.Models
{
    public class Livreur : Personne
    {
        [Key]
        public int LivreurId { get; set; }
           public string Password { get; set; }
           public string VehiculeUtilise { get; set; }
           public string ZoneLivraison { get; set; }
           public string Status { get; set; }
           public string NoteSatisfais { get; set; }
           public string Permis { get; set; }
           public string Photo { get; set; }
           public string Cin { get; set; }

        public ICollection<Commande> Commandes { get; set; }


    }
}
