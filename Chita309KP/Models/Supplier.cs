using System.ComponentModel.DataAnnotations;

namespace Chita309KP.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
