using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FullMVC.Models
{
    public class Review
    {

        public virtual string ReviewID { get; set; }

        [Display(Name = "Review Description")]
        [StringLength(800)]
        public virtual string Review_Description { get; set; }



    }
}