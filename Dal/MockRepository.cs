using PetShop.Models;
using System.Collections.Generic;

namespace PetShop.Dal
{
    public class MockRepository : IMockRepository
    {
        public MockRepository()
        {
            MockDb();
        }

        public List<ViewModels.PetViewModel> _pets;      
       
        public IEnumerable<ViewModels.PetViewModel> GetAll()
        {
            return _pets;
        }
              
        public void MockDb()
        {
            _pets = new List<ViewModels.PetViewModel>
            {
                new ViewModels.PetViewModel
                {
                    Id = 1,
                    Breed = "Cat",
                    ImagePath = "/images/cat.jpg",
                    Behaviour = Types.Behaviour.agitated.ToString(),
                    Relationship = Types.HumanRelationship.independant.ToString(),
                    Appetite = Types.Appetite.tiny.ToString()
                },
                new ViewModels.PetViewModel
                {
                    Id = 2,
                    Breed = "Dog",
                    ImagePath = "/images/dog.jpg",
                    Behaviour = Types.Behaviour.docile.ToString(),
                    Relationship = Types.HumanRelationship.affectionate.ToString(),
                    Appetite = Types.Appetite.medium.ToString()
                },
                new ViewModels.PetViewModel
                {
                    Id = 3,
                    Breed = "Mini_Pig",
                    ImagePath = "/images/mini_pig.jpg",
                    Behaviour =Types.Behaviour.agitated.ToString(),
                    Relationship = Types.HumanRelationship.affectionate.ToString(),
                    Appetite = Types.Appetite.tiny.ToString()
                },
                new ViewModels.PetViewModel
                {
                    Id = 4,
                    Breed = "Weasel",
                    ImagePath = "/images/weasel.jpg",
                    Behaviour = Types.Behaviour.agitated.ToString(),
                    Relationship = Types.HumanRelationship.neutral.ToString(),
                    Appetite = Types.Appetite.tiny.ToString()
                },
                 new ViewModels.PetViewModel
                 {
                    Id = 5,
                    Breed = "Hedgehog",
                    ImagePath = "/images/Hedgehog.jpg",
                    Behaviour = Types.Behaviour.docile.ToString(),
                    Relationship = Types.HumanRelationship.independant.ToString(),
                    Appetite = Types.Appetite.tiny.ToString()
                },
                 new ViewModels.PetViewModel
                {
                    Id = 5,
                    Breed = "Kangaroo",
                    ImagePath = "/images/Kangaroo.jpg",
                    Behaviour = Types.Behaviour.agitated.ToString(),
                    Relationship = Types.HumanRelationship.independant.ToString(),
                    Appetite = Types.Appetite.huge.ToString()
                },
                new ViewModels.PetViewModel
                {
                    Id = 5,
                    Breed = "Cheetah",
                    ImagePath = "/images/cheetah.jpg",
                    Behaviour = Types.Behaviour.wild.ToString(),
                    Relationship = Types.HumanRelationship.independant.ToString(),
                    Appetite = Types.Appetite.huge.ToString()
                }
            };
        }

    }
}
