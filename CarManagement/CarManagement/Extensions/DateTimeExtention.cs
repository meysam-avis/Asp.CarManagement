using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Extensions
{
    public static class DateTimeExtention
    {
        public static string GetPersianDate(this DateTime dt)
        {
           var pc =new PersianCalendar();
           return $"{pc.GetYear(dt).ToString("00")}/{pc.GetMonth(dt).ToString("00")}/{pc.GetDayOfMonth(dt).ToString("00")}";
        }
        public static string GetPersianDateTime(this DateTime dt)
        {
            var pc = new PersianCalendar();
            string date= $"{pc.GetYear(dt).ToString("00")}/{pc.GetMonth(dt).ToString("00")}/{pc.GetDayOfMonth(dt).ToString("00")}";

            string time = dt.ToShortTimeString();

            return date + " "+ time;
        }
    }
}