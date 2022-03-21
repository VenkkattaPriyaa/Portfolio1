using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lib.Core.Model
{
    public class Investors
    {
       
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is Required")]
            public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is Required")]
        [StringLength(50, MinimumLength =3,ErrorMessage ="Full Name Must be between 3 and 50 chars")]
            public string name { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is Required")]
            public string Email { get; set; }

            [Display(Name = "Contact")]
            [Required(ErrorMessage = "Contact is Required")]
            public decimal Contact { get; set; }

            [Display(Name = "Total_Investments")]
            [Required(ErrorMessage = "Total_Investments is Required")]
            public decimal Total_Investments { get; set; }

            [Display(Name = "Gender")]
            [Required(ErrorMessage = "Gender is Required")]
            public string Gender { get; set; }



          
    }
}
