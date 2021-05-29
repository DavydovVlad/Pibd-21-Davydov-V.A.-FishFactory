using CannedFactoryBusinessLogic.BindingModels;
using CannedFactoryBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace CannedFactoryBusinessLogic.Interfaces
{
    public interface IMessageInfoStorage
    {
        List<MessageInfoViewModel> GetFullList();

        List<MessageInfoViewModel> GetFilteredList(MessageInfoBindingModel model);

        void Insert(MessageInfoBindingModel model);
    }
}
