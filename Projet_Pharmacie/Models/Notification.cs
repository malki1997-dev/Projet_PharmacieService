
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_PharmaService.Models
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }
        public int Destinataire { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public DateTime Heure { get; set; }
        public string Status { get; set; }
        public Livreur Livreur { get; set; }
        public int LivreurId {  get; set; }
        public  Pharmacie Pharmacie { get; set; }
        [ForeignKey("Pharmacie")]
        public string PharmacieId { get; set; }

     
    }
}
