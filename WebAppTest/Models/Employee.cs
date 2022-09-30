using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebAppTest.Models
{
    public class Employee
    {
        [Key]
        public int No { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "Name")]
        public string Name { get; set; }


        [EmailAddress]
        [Column(TypeName = "nvarchar(40)")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please enter Address")]
        [DataType(DataType.Text)]
        [Display(Name = "Address")]
        [Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; }


        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                  ErrorMessage = "Entered phone format is not valid.")]
        [Column(TypeName = "char(10)")]
        public int Phone { get; set; }
    }
}
