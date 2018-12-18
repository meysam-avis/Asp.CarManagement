using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarManagement.Pages.PersonManager
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public Person Person { set; get; }

        public List<Person> LstPerson { set; get; }

        public void OnGet()
        {
            // LstCar = CarManagementDB.GetDb().GetCollection<Car>("Car").Find(_ => true).ToList();
            LstPerson = CarManagementDB.GetDb().GetCollection<Person>("Person").Find(_ => true).ToList();

        }


        public async Task<IActionResult> OnPostCreateAsync()
        {

            await CarManagementDB.GetDb().GetCollection<Person>("Person").InsertOneAsync(Person);
            return RedirectToPage("./Index");

        }

        public async Task<IActionResult> OnPostEditAsync()
        {

            await CarManagementDB.GetDb().GetCollection<Person>("Person")
                       .UpdateOneAsync(x => x.Id == Person.Id, Builders<Person>.Update
                       .Set(u => u.CellPhone, Person.CellPhone)
                       .Set(u => u.MelliCode, Person.MelliCode)
                       .Set(u => u.Name, Person.Name)


                   );

            return RedirectToPage("./Index");

        }



        public async Task<IActionResult> OnPostDeleteAsync()
        {

            if (Person.Id == string.Empty)
            {
                return Page();
            }

          await CarManagementDB.GetDb().GetCollection<Person>("Person")
                .DeleteOneAsync(x => x.Id == Person.Id);
            
            return RedirectToPage("./Index");
        }


    }
}