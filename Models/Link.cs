using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sooziales_Netzwerk.Models{
    public class Link{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idLink {get; set;}

        [Display(Name = "Enter Link")]
        [Required(ErrorMessage = "Upload without a link make no sence")]
        public string linkText {get; set;}

        [Display(Name = "Enter Username")]
        [Required(ErrorMessage = "Upload without a username make no sence")]
        public string username {get; set;}

        [Display(Name = "Enter Likes")]
        [Required(ErrorMessage = "Upload without a link make no sence")]
        public int likes {get; set;}
    }
}


