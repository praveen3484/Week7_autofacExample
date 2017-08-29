using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1.Repository.Entity
{
    public class Employee2
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is Required")]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public long? Phone { get; set; }
        [Required(ErrorMessage ="This Field is Required")]
      
        public bool MaritalStatus { get; set; }

        [Required, Range(1, int.MaxValue, ErrorMessage = "Error: Must Choose a State")]
        public string State { get; set; }
        [Required, Range(1, int.MaxValue, ErrorMessage = "Error: Must Choose a City")]

        public string City { get; set; }
        public byte[] Image { get; set; }
    }
}
