using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mediatek86.Models
{
    [Table("service")]
    public class Service
    {
        [Key]
        public int IdService { get; set; }
        public string? Nom { get; set; }

        public virtual ICollection<Personnel>? Personnels { get; set; }
    }
}
