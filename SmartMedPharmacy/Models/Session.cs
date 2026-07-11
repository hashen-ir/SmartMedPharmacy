using System;
using System.Collections.Generic;
using System.Text;
using SmartMedPharmacy.Models;

namespace SmartMedPharmacy.Models
{
    public static class Session
    {
        public static int CustomerID { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }

        public static int AdminID { get; set; }

        public static bool ExpiryNotificationShown = false;
    }





}

