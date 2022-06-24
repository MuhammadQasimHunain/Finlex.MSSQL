using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinlexApp.DataLibrary.DataModel
{
    public class Order
    {
        [Key]
        public int OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string CreatedBy { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? ProductName { get; set; }
        public double Total { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }

        public Order()
        {

        }
        public Order(string createdBy)
        {
            CreatedBy = createdBy;
        }
    }
}
