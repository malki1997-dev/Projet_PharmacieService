
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace Projet_PharmaService.Models
{
    public class Pharmacie
    {
        [Key]
        public int PharmacieId { get; set; }
        public string Enseigne { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int CodePostal { get; set; }
        public string Ville { get; set; }
        public string SiteWeb { get; set; }
        public Stock? Stock { get; set; }
     
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Panier> Paniers { get; set; }

       
    }
}
