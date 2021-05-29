﻿using CannedFactoryBusinessLogic.BindingModels;
using CannedFactoryBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace CannedFactoryBusinessLogic.Interfaces
{
    public interface IImplementerStorage
    {
        List<ImplementerViewModel> GetFullList();
        List<ImplementerViewModel> GetFilteredList(ImplementerBindingModel model);
        ImplementerViewModel GetElement(ImplementerBindingModel model);
        void Insert(ImplementerBindingModel model);
        void Update(ImplementerBindingModel model);
        void Delete(ImplementerBindingModel model);
    }
}
