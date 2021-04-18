using System;
using System.Collections.Generic;
using System.Linq;
using CannedFactoryBusinessLogic.BindingModels;
using CannedFactoryBusinessLogic.Interfaces;
using CannedFactoryBusinessLogic.ViewModels;
using CannedFactoryFileImplement.Models;

namespace CannedFactoryFileImplement.Implements
{
    public class CannedStorage : ICannedStorage
    {
        private readonly FileDataListSingleton source;

        public CannedStorage()
        {
            source = FileDataListSingleton.GetInstance();
        }

        public List<CannedViewModel> GetFullList()
        {
            return source.Canneds
            .Select(CreateModel)
            .ToList();
        }

        public List<CannedViewModel> GetFilteredList(CannedBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return source.Canneds
            .Where(rec => rec.CannedName.Contains(model.CannedName))
            .Select(CreateModel)
            .ToList();
        }

        public CannedViewModel GetElement(CannedBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            var Canned = source.Canneds
            .FirstOrDefault(rec => rec.CannedName == model.CannedName || rec.Id == model.Id);
            return Canned != null ? CreateModel(Canned) : null;
        }

        public void Insert(CannedBindingModel model)
        {
            int maxId = source.Canneds.Count > 0 ? source.Canneds.Max(rec => rec.Id) : 0;
            var element = new Canned { Id = maxId + 1, CannedComponents = new Dictionary<int, int>() };
            source.Canneds.Add(CreateModel(model, element));
        }

        public void Update(CannedBindingModel model)
        {
            var element = source.Canneds.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, element);
        }

        public void Delete(CannedBindingModel model)
        {
            Canned element = source.Canneds.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                source.Canneds.Remove(element);
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        private Canned CreateModel(CannedBindingModel model, Canned Canned)
        {
            Canned.CannedName = model.CannedName;
            Canned.Price = model.Price;
            // удаляем убранные
            foreach (var key in Canned.CannedComponents.Keys.ToList())
            {
                if (!model.CannedComponents.ContainsKey(key))
                {
                    Canned.CannedComponents.Remove(key);
                }
            }
            // обновляем существуюущие и добавляем новые
            foreach (var component in model.CannedComponents)
            {
                if (Canned.CannedComponents.ContainsKey(component.Key))
                {
                    Canned.CannedComponents[component.Key] = model.CannedComponents[component.Key].Item2;
                }
                else
                {
                    Canned.CannedComponents.Add(component.Key, model.CannedComponents[component.Key].Item2);
                }
            }
            return Canned;
        }

        private CannedViewModel CreateModel(Canned Canned)
        {
            return new CannedViewModel
            {
                Id = Canned.Id,
                CannedName = Canned.CannedName,
                Price = Canned.Price,
                CannedComponents = Canned.CannedComponents.ToDictionary(recPC => recPC.Key, recPC =>
                (source.Components.FirstOrDefault(recC => recC.Id == recPC.Key)?.ComponentName, recPC.Value))
            };
        }
    }
}