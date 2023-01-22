using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chita309KP.Models
{
    public class Sales
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Phone")]
        public int Phone_id { get; set; }
        [ForeignKey("Worker")]
        public int Worker_id { get; set; }
        public int Price { get; set; }
    }
}
