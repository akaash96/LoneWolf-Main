using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FullMVC.Models
{
    public class Film
    {
        public virtual string FilmID { get; set; }

        [Required(ErrorMessage = "A Film name is required")]
        [StringLength(60)]
        public virtual string Film_Name { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public virtual string ReleaseDate { get; set; }

        [Required(ErrorMessage = "A Film name is required")]

        [StringLength(60)]
        public virtual string Cast { get; set; }

        [Required(ErrorMessage = "A Film name is required")]
        [StringLength(60)]
        public virtual string Director { get; set; }

        public virtual string ReviewID { get; set; }
        public virtual Review Reviews { get; set; }

        public virtual string GenreID { get; set; }

        public virtual Genre Genres { get; set; }



    }
}