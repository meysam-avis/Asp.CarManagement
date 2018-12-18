using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;

using CarManagement;



namespace Shared
{
public static class Common {
        public static void ClearMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

    public static void SetUserActivity(UserActivityType ut, string message)
    {
        //using (var db = new CarManagementDB())
        //{
        //    var ua = new UserActivity();
        //    ua.Description = message;
        //    ua.UserId = Program.User.Id;
        //    ua.UserActivityType = ut;

        //}

    }





    }
}
