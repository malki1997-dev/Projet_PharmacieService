
using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.Models
{
    public class Livraison
    {

        [Key]
        public int Id { get; set; }

        public DateTime dateLivraison { get; set; }

    }
}
