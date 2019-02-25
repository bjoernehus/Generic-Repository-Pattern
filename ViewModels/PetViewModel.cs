using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.ViewModels
{
    public class PetViewModel 
    {
        public  int  Id { get; set; }  
        public string Breed { get; set; }
        public string ImagePath { get; set; }
        public string Relationship { get; set; }
        public string Behaviour { get; set; }
        public string Appetite { get; set; }
    }
}
