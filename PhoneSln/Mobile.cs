using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PhoneSln
{
    internal class Mobile
    {
        private string Brand;
        private string Display;
        private string Storage;
        private bool Hasinsurance;
        
        public Mobile(string brand,string display, string storage, bool hasinsurance)
        {
            Brand = brand;
            Display = display;
            Storage = storage;
            Hasinsurance = hasinsurance;
                     
        
        }

        public string GetBrand()
        {
         return Brand;

        }
         
        public string GetDisplay()
        {
            return Display;
        }
        public string GetStorage()
        {
            return Storage;
        }
        public bool GetHasinsurance()
        { 
            return Hasinsurance; 
        }
        





    }   
}
