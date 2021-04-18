using System.Collections.Generic;
using CannedFactoryBusinessLogic.BindingModels;
using CannedFactoryBusinessLogic.ViewModels;

namespace CannedFactoryBusinessLogic.Interfaces
{
    public interface IOrderStorage
    {
        List<OrderViewModel> GetFullList();

        List<OrderViewModel> GetFilteredList(OrderBindingModel model);

        OrderViewModel GetElement(OrderBindingModel model);

        void Insert(OrderBindingModel model);

        void Update(OrderBindingModel model);

        void Delete(OrderBindingModel model);
    }
}