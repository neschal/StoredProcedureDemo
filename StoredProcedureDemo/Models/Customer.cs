using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoredProcedureDemo.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Your Address")]
        [StringLength(10, ErrorMessage = "Address should be less than or equal to ten characters.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string Mobileno { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Enter Your DOB.")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }
        [Required(ErrorMessage = "Enter Your EmailID")]
        public string EmailID { get; set; }
        public List<Customer> ShowallCustomer { get; set; }
    }
} 
    