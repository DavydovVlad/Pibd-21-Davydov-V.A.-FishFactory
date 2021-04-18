using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CannedFactoryBusinessLogic.BindingModels;
using CannedFactoryBusinessLogic.Interfaces;
using CannedFactoryBusinessLogic.ViewModels;
using CannedFactoryDatabaseImplement.Models;

namespace CannedFactoryDatabaseImplement.Implements
{
    public class CannedStorage : ICannedStorage
    {
        public List<CannedViewModel> GetFullList()
        {
            using (var context = new CannedFactoryDatabase())
            {
                return context.Canneds
                .Include(rec => rec.CannedComponents)
                .ThenInclude(rec => rec.Component)
                .ToList()
                .Select(rec => new CannedViewModel
                {
                    Id = rec.Id,
                    CannedName = rec.CannedName,
                    Price = rec.Price,
                    CannedComponents = rec.CannedComponents
                    .ToDictionary(recTC => recTC.ComponentId, recTC => (recTC.Component?.ComponentName, recTC.Count))
                })
                .ToList();
            }
        }

        public List<CannedViewModel> GetFilteredList(CannedBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new CannedFactoryDatabase())
            {
                return context.Canneds
                .Include(rec => rec.CannedComponents)
                .ThenInclude(rec => rec.Component)
                .Where(rec => rec.CannedName.Contains(model.CannedName))
                .ToList()
                .Select(rec => new CannedViewModel
                {
                    Id = rec.Id,
                    CannedName = rec.CannedName,
                    Price = rec.Price,
                    CannedComponents = rec.CannedComponents
                    .ToDictionary(recTC => recTC.ComponentId, recTC => (recTC.Component?.ComponentName, recTC.Count))
                })
                .ToList();
            }
        }

        public CannedViewModel GetElement(CannedBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new CannedFactoryDatabase())
            {
                var canned = context.Canneds
                .Include(rec => rec.CannedComponents)
                .ThenInclude(rec => rec.Component)
                .FirstOrDefault(rec => rec.CannedName == model.CannedName || rec.Id == model.Id);
                return canned != null ?
                new CannedViewModel
                {
                    Id = canned.Id,
                    CannedName = canned.CannedName,
                    Price = canned.Price,
                    CannedComponents = canned.CannedComponents
                    .ToDictionary(recTC => recTC.ComponentId, recTC => (recTC.Component?.ComponentName, recTC.Count))
                } :
                null;
            }
        }

        public void Insert(CannedBindingModel model)
        {
            using (var context = new CannedFactoryDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        Canned canned = CreateModel(model, new Canned());
                        context.Canneds.Add(canned);
                        context.SaveChanges();
                        canned = CreateModel(model, canned, context);
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Update(CannedBindingModel model)
        {
            using (var context = new CannedFactoryDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var element = context.Canneds.FirstOrDefault(rec => rec.Id == model.Id);
                        if (element == null)
                        {
                            throw new Exception("Элемент не найден");
                        }
                        CreateModel(model, element, context);
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Delete(CannedBindingModel model)
        {
            using (var context = new CannedFactoryDatabase())
            {
                Canned element = context.Canneds.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Canneds.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private Canned CreateModel(CannedBindingModel model, Canned Canned)
        {
            Canned.CannedName = model.CannedName;
            Canned.Price = model.Price;
            return Canned;
        }

        private Canned CreateModel(CannedBindingModel model, Canned canned, CannedFactoryDatabase context)
        {
            canned.CannedName = model.CannedName;
            canned.Price = model.Price;
            if (model.Id.HasValue)
            {
                var cannedComponents = context.CannedComponents.Where(rec => rec.CannedId == model.Id.Value).ToList();
                // удалили те, которых нет в модели
                context.CannedComponents.RemoveRange(cannedComponents.Where(rec => !model.CannedComponents.ContainsKey(rec.ComponentId)).ToList());
                context.SaveChanges();
                // обновили количество у существующих записей
                foreach (var updateComponent in cannedComponents)
                {
                    updateComponent.Count = model.CannedComponents[updateComponent.ComponentId].Item2;
                    model.CannedComponents.Remove(updateComponent.ComponentId);
                }
                context.SaveChanges();
            }
            // добавили новые
            foreach (var tc in model.CannedComponents)
            {
                context.CannedComponents.Add(new CannedComponent
                {
                    CannedId = canned.Id,
                    ComponentId = tc.Key,
                    Count = tc.Value.Item2
                });
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    MessageBox.Show(e?.InnerException?.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return canned;
        }
    }
}