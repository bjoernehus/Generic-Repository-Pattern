
namespace PetShop.Models
{
    public class Pet : EntityBase
    {
        public string Breed { get; set; }
        public string ImagePath { get; set; }
        public Types.HumanRelationship Relationship { get; set; }
        public Types.Behaviour  Behaviour { get; set; }
        public Types.Appetite Appetite { get; set; }
    }
}
