using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace Infrastructure
{
    public static class Variables
    {
        public static  string AppName {  get; } = "Sabt.Car";
        public static User User { get; set; }
        public static string Version { get; } = "0.4";
    }
}
