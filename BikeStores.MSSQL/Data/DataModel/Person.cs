using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinlexApp.DataLibrary.DataModel
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? Name { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }
    }
}
