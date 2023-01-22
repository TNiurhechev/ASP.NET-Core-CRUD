using System.ComponentModel.DataAnnotations;

namespace Chita309KP.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
    }
}
