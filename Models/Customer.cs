using System.ComponentModel.DataAnnotations;

namespace MvcApp.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Customer Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        [Display(Name = "Telephone Number")]
        public string? TelephoneNumber { get; set; }

        [Display(Name = "Contact Person Name")]
        public string? ContactPersonName { get; set; }

        [Display(Name = "Contact Person Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address format.")]
        public string? ContactPersonEmail { get; set; }

        [Display(Name = "VAT Number")]
        public string? VatNumber { get; set; }
    }
}
