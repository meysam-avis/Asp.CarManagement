using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using ViewModels;

namespace CarManagement.Pages.ManageCar
{
    public class IndexModel : PageModel
    {
        public List<CarViewModel> LstCarViewModel = new List<CarViewModel>();
        [BindProperty(SupportsGet = true)]
        public Car Car { set; get; }

        [BindProperty(SupportsGet = true)]
        public int? Id { set; get; }

        public void OnGet()
        {
           var  lst = CarManagementDB.GetDb().GetCollection<Car>("Car").Find(_ => true).ToList();

            foreach (var item in lst)
            {
                var cv=new CarViewModel();

                cv.Transferee = item.Transferee;
                cv.Model = item.Model;
                cv.Color = item.Color;
                cv.Pelak = item.Pelak;
                cv.Deleted = item.Deleted;
                cv.Name = item.Name;
                cv.Id =item.Id;
                cv.TransfereeName = CarManagementDB.GetDb().GetCollection<Person>("Person")
                    .Find(p => p.Id == item.Transferee).FirstOrDefault().Name;


                LstCarViewModel.Add(cv);
                
            }

            var person = CarManagementDB.GetDb().GetCollection<Person>("Person").Find(_ => true).ToList();
            ViewData["transfreeId"] = new SelectList(person, "Id", "Name");

        }

        public async Task<IActionResult> OnPostCreateAsync()
        {
          
            await CarManagementDB.GetDb().GetCollection<Car>("Car").InsertOneAsync(Car);
              return RedirectToPage("./Index");

        }

        public async Task<IActionResult> OnPostEditAsync()
        {
            var person = CarManagementDB.GetDb().GetCollection<Person>("Person").Find(_ => true).ToList();
            ViewData["transfreeId"] = new SelectList(person, "Id", "Name");

            await CarManagementDB.GetDb().GetCollection<Car>("Car").UpdateOneAsync(x => x.Id == Car.Id, Builders<Car>.Update
                .Set(u => u.Model, Car.Model)
                .Set(u => u.Color, Car.Color)
                .Set(u => u.Name, Car.Name )
                .Set(u => u.Pelak, Car.Pelak)
                .Set(u => u.Transferee, Car.Transferee)
                
                );

         return RedirectToPage("./Index");

        }


        public async Task<IActionResult> OnPostDeleteAsync()
        {
        
            if (Car.Id==string.Empty)
            {
                return Page();
            }
            
            var person = CarManagementDB.GetDb().GetCollection<Person>("Person").Find(_ => true).ToList();
            ViewData["transfreeId"] = new SelectList(person, "Id", "Name");


            await CarManagementDB.GetDb().GetCollection<Car>("Car")
                .DeleteOneAsync(x => x.Id == Car.Id);


            return RedirectToPage("./Index");

        }




    }
}