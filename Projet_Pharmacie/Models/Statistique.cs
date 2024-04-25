
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_PharmaService.Models
{
    public class Statistique
    {
        [Key]
        public int StatistiqueID { get; set; }
        public string period {  get; set; }

        public int nombreVentes { get; set; }

        public double chifreDaffaire { get; set; }

        public double margeBeneficiaire { get; set; }
        [ForeignKey(nameof(StockId))]
        public Stock Stock { get; set; }
       
        public int StockId { get; set; }

    }
}
