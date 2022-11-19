using System.ComponentModel.DataAnnotations;

namespace ITProvisioning.API.Models {
    public class Employee {
        public Guid Id { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }

        [Required]
        public string Department { get; set; }
        
        [RegularExpression("^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$", ErrorMessage ="Invalid email format")]
        public string Email { get; set; }

        public string? Phone { get; set; }
        
        public string? Device { get; set; }
    }
}
