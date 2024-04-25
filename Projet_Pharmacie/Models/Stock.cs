
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_PharmaService.Models
{
    public class Stock
    {
        [Key]

        public int StockId { get; set; }
        public int quantite { get; set; }

        public DateTime datePeremption { get; set; }

        public double seuilReaprovisionnement { get; set; }

        public Pharmacie Pharmacie { get; set; }


        public int PharmacieId { get; set; }

        public Medicament Medicament { get; set; }

        public int MedicamentId { get; set; }
        public ICollection<Statistique> statistiques { get; set; }

    }
}
