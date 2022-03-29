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
        [Required]
        public string link {get; set;}

        [Display(Name = "Enter Username")]
        [Required]
        public string username {get; set;}

        [Display(Name = "Enter Likes")]
        [Required]
        public int likes {get; set;}
    }
}


