using System.ComponentModel;

namespace PetShop.Models
{
    public class Types
    {
        public enum HumanRelationship
        {
            [Description("affectionate")]
            affectionate = 1,
            [Description("neutral")]
            neutral = 2,
            [Description("independant")]
            independant = 3
        }

        public enum Behaviour
        {
            [Description("docile")]
            docile = 1,
            [Description("agitated")]
            agitated = 2,
            [Description("wild")]
            wild = 3
        }

        public enum Appetite
        {
            [Description("tiny")]
            tiny = 1,
            [Description("medium")]
            medium = 2,
            [Description("huge")]
            huge = 3
        }

    }
}
