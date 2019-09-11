using System.Collections.Generic;
using System.Web.Mvc;
using Dropdowns.Models;

namespace Dropdowns.Controllers
{
    public class SignUpController : Controller
    {
        //
        // 1. Action method for displaying 'Sign Up' page
        //
        public ActionResult SignUp()
        {
            // Let's get all states that we need for a DropDownList
            var courts = GetAllCourts();

            var model = new SignUpModel();

            // Create a list of SelectListItems so these can be rendered on the page
            model.Courts = GetSelectListItems(courts);

            return View(model);
        }
        
        private IEnumerable<string> GetAllCourts()
        {
            return new List<string>
            {
                "Riyadh",
                "Jeddah",
                "Eastern province",
                "Mecca",
                "Al Hufuf",
                "Al baha",
                "Jamaica",
            };
        }

        // This is one of the most important parts in the whole example.
        // This function takes a list of strings and returns a list of SelectListItem objects.
        // These objects are going to be used later in the SignUp.html template to render the
        // DropDownList.
        private IEnumerable<SelectListItem> GetSelectListItems(IEnumerable<string> elements)
        {
            // Create an empty list to hold result of the operation
            var selectList = new List<SelectListItem>();

            // For each string in the 'elements' variable, create a new SelectListItem object
            // that has both its Value and Text properties set to a particular value.
            // This will result in MVC rendering each item as:
            //     <option value="State Name">State Name</option>
            foreach (var element in elements)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element,
                    Text = element
                });
            }

            return selectList;
        }
    }
}
