using System.Collections.Generic;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Dropdowns.Models
{
    public class SignUpModel
    {
        [Required]
        [Display(Name = "ID")]
        public int Id { get; set; }

        // This property will hold a state, selected by user
        [Required]
        [Display(Name = "Court")]
        public string Name { get; set; }

        // This property will hold all available states for selection
        public IEnumerable<SelectListItem> Courts { get; set; }
    }
}