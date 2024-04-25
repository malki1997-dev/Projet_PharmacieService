
using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;
namespace Projet_PharmaService.Models
{
    public class Client: Personne
    {
        [Key]
        public int Id { get; set; }
        public string Mutuelle { get; set; }
        public string Etat { get; set; }
        public string Password { get; set; }
        
       
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Panier> Paniers { get; set; }

  
    }
}
