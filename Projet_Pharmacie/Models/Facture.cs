
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_PharmaService.Models
{
    public class Facture
    {
        [Key]
        public int FactureId { get; set; }
        [ForeignKey(nameof(CommandeId))]
        public Commande Commande { get; set; }
        [ForeignKey(nameof(PaiementId))]
        public Paiement Paiement { get; set; }
        public int CommandeId { get; set; }
        public int PaiementId { get; set; }

        public DateTime DateFacture { get; set; }
        public double PrixTotalFacture { get; set; }
        public double TvaFacture { get; set; }
    }
}
