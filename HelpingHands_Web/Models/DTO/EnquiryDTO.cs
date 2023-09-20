using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace HelpingHands_Web.Models.DTO
{
    public class EnquiryDTO
    {
       [Required]
        public int Id { get; set; }

        public int CompanyID { get; set; }
        [ValidateNever]
        public CompanyDTO Company { get; set; }


        public string ApplicationUserId { get; set; }
        [ValidateNever]
        public ApplicationUserDTO ApplicationUser { get; set; }


        [Required]
        [DisplayName("User Name")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("User Email")]
		[StringLength(20)]
		[DataType(DataType.EmailAddress)]
		[RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Invalid Email Address")]
		public string Email { get; set; }
        [Required]
        [DisplayName("User Phone Number")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "The phone number must be exactly 10 digits.")]
        public int PhoneNumber { get; set; }
        [Required]
        [DisplayName("Enquiry Title")]
        public string Title { get; set; }
        [Required]
        [DisplayName("Brif Description Of Your Enquiry")]
        public string Description { get; set; }

        public bool IsActive { get; set; }


    }
}
