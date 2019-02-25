using System.Collections.Generic;

namespace PetShop.Dal
{
    public interface IMockRepository
    {
        IEnumerable<ViewModels.PetViewModel> GetAll();
    }
}
