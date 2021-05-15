using System.Collections.Generic;
using CannedFactoryBusinessLogic.BindingModels;
using CannedFactoryBusinessLogic.ViewModels;

namespace CannedFactoryBusinessLogic.Interfaces
{
    public interface IClientStorage
    {
        List<ClientViewModel> GetFullList();

        List<ClientViewModel> GetFilteredList(ClientBindingModel model);

        ClientViewModel GetElement(ClientBindingModel model);

        void Insert(ClientBindingModel model);

        void Update(ClientBindingModel model);

        void Delete(ClientBindingModel model);
    }
}
