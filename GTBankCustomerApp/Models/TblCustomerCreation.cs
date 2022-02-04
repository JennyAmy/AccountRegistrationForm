using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GTBankCustomerApp.Models
{
    public enum Gender
    {
        Male,
        Female
    }

    public partial class TblCustomerCreation
    {
        public int Id { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string Othername { get; set; }
        public string Title { get; set; }
        public string MaritalStatus { get; set; }
        public Gender? Gender { get; set; }
        public string MobilePhone { get; set; }
        public string Residence { get; set; }
        public string Bvn { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-z0-9_.+-]+@[a-zA-z0-9]+\.[a-zA-z0-9.]+$",
            ErrorMessage = "Invalid Email Format")]
        public string Email { get; set; }
    }
}
