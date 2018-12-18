using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels;

namespace CarManagement.Pages.MamoriatManagement
{
    public class IndexModel : PageModel
    {
      //  public List<CarViewModel> LstCarViewModel = new List<CarViewModel>();

        public List<MamoriatViewModel> LstMamoriat = new List<MamoriatViewModel>();

        [BindProperty(SupportsGet = true)]
        public Mamoriat Mamoriat { set; get; }

        public void OnGet()
        {
            var person = CarManagementDB.GetDb().GetCollection<Person>("Person").Find(_ => true).ToList();
            var car = CarManagementDB.GetDb().GetCollection<Car>("Car").Find(_ => true).ToList();
            var mabda = CarManagementDB.GetDb().GetCollection<Vahed>("Vahed").Find(_ => true).ToList();
            ViewData["DriverId"] = new SelectList(person, "Id", "Name");

            ViewData["MabdaId"] = new SelectList(mabda, "Id", "Name");


            ViewData["CarId"] = new SelectList(car, "Id", "Name");


            var lm = CarManagementDB.GetDb().GetCollection<Mamoriat>("Mamoriat").Find(_ => true).ToList();


            foreach (var item in lm)
            {
                LstMamoriat.Add(new MamoriatViewModel
                {

                    Mamoriat = item,
                    CarName = CarManagementDB.GetDb().GetCollection<Car>("Car")
                        .Find(p => p.Id == item.CarId).FirstOrDefault().Name,
                    CarPelak = CarManagementDB.GetDb().GetCollection<Car>("Car")
                        .Find(p => p.Id == item.CarId).FirstOrDefault().Pelak,
                    DriverName = CarManagementDB.GetDb().GetCollection<Person>("Person")
                        .Find(p => p.Id == item.DriverId).FirstOrDefault().Name,
                    MabdaName =  CarManagementDB.GetDb().GetCollection<Vahed>("Vahed")
                        .Find(p => p.Id == item.MabdaId).FirstOrDefault().Name,
                    UserName =  CarManagementDB.GetDb().GetCollection<User>("User")
                        .Find(p => p.Id == item.UserId).FirstOrDefault().Name

                } );
            }

        }


        public async Task<IActionResult> OnPostCreateAsync()
        {

            await CarManagementDB.GetDb().GetCollection<Mamoriat>("Mamoriat").InsertOneAsync(Mamoriat);
            return RedirectToPage("./Index");

        }

        public async Task<IActionResult> OnPostEditAsync()
        {

            await CarManagementDB.GetDb().GetCollection<Mamoriat>("Mamoriat")
                .UpdateOneAsync(x => x.Id == Mamoriat.Id, Builders<Mamoriat>.Update
                    .Set(u => u.CarId, Mamoriat.CarId)
                    .Set(u => u.DriverId, Mamoriat.DriverId)
                    .Set(u => u.Maghsad, Mamoriat.Maghsad)
                    .Set(u => u.TarikhBargasht, Mamoriat.TarikhBargasht)
                    .Set(u => u.TarikhRaft, Mamoriat.TarikhRaft)
                    .Set(u => u.ZamanBargasht, Mamoriat.ZamanBargasht)
                    .Set(u => u.ZamanRaft, Mamoriat.ZamanRaft)
                    .Set(u => u.MabdaId, Mamoriat.MabdaId)
                    .Set(u => u.ShomareNameh, Mamoriat.ShomareNameh)
                    .Set(u => u.UserId, Mamoriat.UserId)
                    .Set(u => u.KilometerBargasht, Mamoriat.KilometerBargasht)
                    .Set(u => u.KilometerRaft, Mamoriat.KilometerRaft)



                );

            return RedirectToPage("./Index");

        }



        public async Task<IActionResult> OnPostDeleteAsync()
        {

            if (Mamoriat.Id == string.Empty)
            {
                return Page();
            }

            await CarManagementDB.GetDb().GetCollection<Mamoriat>("Mamoriat")
                .DeleteOneAsync(x => x.Id == Mamoriat.Id);

            return RedirectToPage("./Index");
        }



    }
}