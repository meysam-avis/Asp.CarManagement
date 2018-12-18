using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class DriverViewModel
    {
       
        public int Id { get; set; }
        public  string Fname { get; set; }
        public  string Lname { get; set; }
        public string CellPhone { get; set; }
        public string MelliCode { get; set; }
        public bool Deleted { get; set; } = false;
        public string FullName { get; set; }/* = GetFullName();*/

        //private static string GetFullName()
        //{
        //    return Fname + " " + Lname;
        //}
    }
}
