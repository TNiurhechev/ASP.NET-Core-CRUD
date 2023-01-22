using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chita309KP.Models
{
    public class Phone
    {
        [Key]
        public int Id { get; set; }
        public string Phone_name { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public DateTime Sales_date { get; set; }
        [ForeignKey("Supplier")]
        public int Supplier_id { get; set; }
    }
}
