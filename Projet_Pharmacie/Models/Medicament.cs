
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_PharmaService.Models
{
    public class Medicament
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MedicamentId { get; set; }

        public string designation { get; set; }

        public string form { get; set; }

        public string prescription { get; set; }

        public double prixUnitaire { get;}

        public string image { get; set; }

        public string info { get; set; }

        
        public Catalog catalog { get; set; }
        [ForeignKey("catalog")]

        public int CatalogId { get; set; }
       
        public Commande Commande { get; set; }
        public int CommandeId { get; set; }

   
    }
}
