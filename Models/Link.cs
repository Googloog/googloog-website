using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

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

        //[Display(Name = "Enter Likes")]
        //[Required(ErrorMessage = "Upload without a link make no sence")]
        public int likes = 0;

        //[Display(Name = "Who can see you post?")]
        //[Required(ErrorMessage = "Please choose who can see your post?")]
        public enum visibility {Public, Friends, Private};

        //public string[] comments {set; get;}
    }
}


