using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FullMVC.Models
{
    public class Genre
    {

        public virtual string GenreID { get; set; }


        [Required(ErrorMessage = "A Genre type is required")]
        [Display(Name = "Genre Type")]
        [StringLength(60)]
        public virtual string GenreType { get; set; }

    }
}