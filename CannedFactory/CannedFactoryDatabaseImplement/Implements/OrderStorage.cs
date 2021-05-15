using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using CannedFactoryBusinessLogic.BindingModels;
using CannedFactoryBusinessLogic.Interfaces;
using CannedFactoryBusinessLogic.ViewModels;
using CannedFactoryDatabaseImplement.Models;

namespace CannedFactoryDatabaseImplement.Implements
{
    public class OrderStorage : IOrderStorage
    {
        public List<OrderViewModel> GetFullList()
        {
            using (var context = new CannedFactoryDatabase())
            {
                return context.Orders
                .Include(rec => rec.Canned)
                .Include(rec => rec.Client)
                .Select(rec => new OrderViewModel
                {
                    Id = rec.Id,
                    CannedId = rec.CannedId,
                    CannedName = rec.Canned.CannedName,
                    Count = rec.Count,
                    Sum = rec.Sum,
                    Status = rec.Status,
                    DateCreate = rec.DateCreate,
                    DateImplement = rec.DateImplement,
                    ClientId = rec.ClientId,
                    ClientFIO = rec.Client.ClientFIO
                })
                .ToList();
            }
        }

        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new CannedFactoryDatabase())
            {
                return context.Orders
                .Include(rec => rec.Canned)
                .Include(rec => rec.Client)
                .Where(rec => (!model.DateFrom.HasValue && !model.DateTo.HasValue && rec.DateCreate.Date == model.DateCreate.Date) ||
                (model.DateFrom.HasValue && model.DateTo.HasValue && rec.DateCreate.Date >= model.DateFrom.Value.Date && rec.DateCreate.Date <= model.DateTo.Value.Date)
                || (model.ClientId.HasValue && rec.ClientId == model.ClientId))
                .Select(rec => new OrderViewModel
                {
                    Id = rec.Id,
                    CannedId = rec.CannedId,
                    CannedName = rec.Canned.CannedName,
                    Count = rec.Count,
                    Sum = rec.Sum,
                    Status = rec.Status,
                    DateCreate = rec.DateCreate,
                    DateImplement = rec.DateImplement,
                    ClientId = rec.ClientId,
                    ClientFIO = rec.Client.ClientFIO
                })
                .ToList();
            }
        }

        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new CannedFactoryDatabase())
            {
                var order = context.Orders
                .Include(rec => rec.Canned)
                .Include(rec => rec.Client)
                .FirstOrDefault(rec => rec.Id == model.Id);
                return order != null ?
                new OrderViewModel
                {
                    Id = order.Id,
                    CannedId = order.CannedId,
                    CannedName = order.Canned.CannedName,
                    Count = order.Count,
                    Sum = order.Sum,
                    Status = order.Status,
                    DateCreate = order.DateCreate,
                    DateImplement = order.DateImplement,
                    ClientId = order.ClientId,
                    ClientFIO = order.Client.ClientFIO
                } :
                null;
            }
        }

        public void Insert(OrderBindingModel model)
        {
            using (var context = new CannedFactoryDatabase())
            {
                context.Orders.Add(CreateModel(model, new Order()));
                context.SaveChanges();
            }
        }

        public void Update(OrderBindingModel model)
        {
            using (var context = new CannedFactoryDatabase())
            {
                var element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(OrderBindingModel model)
        {
            using (var context = new CannedFactoryDatabase())
            {
                Order element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Orders.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private Order CreateModel(OrderBindingModel model, Order order)
        {
            order.CannedId = model.CannedId;
            order.Count = model.Count;
            order.Sum = model.Sum;
            order.Status = model.Status;
            order.DateCreate = model.DateCreate;
            order.DateImplement = model.DateImplement;
            order.ClientId = model.ClientId.Value;
            return order;
        }
    }
}