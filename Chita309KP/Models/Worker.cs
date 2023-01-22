using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chita309KP.Models
{
    public class Worker
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        [ForeignKey("Position")]
        public int Position_id { get; set; }
    }
}
