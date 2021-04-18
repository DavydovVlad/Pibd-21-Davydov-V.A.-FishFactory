using System;
using System.Collections.Generic;
using System.Linq;
using CannedFactoryBusinessLogic.BindingModels;
using CannedFactoryBusinessLogic.Enums;
using CannedFactoryBusinessLogic.HelperModels;
using CannedFactoryBusinessLogic.Interfaces;
using CannedFactoryBusinessLogic.ViewModels;

namespace CannedFactoryBusinessLogic.BusinessLogics
{
    public class ReportLogic
    {
        private readonly ICannedStorage _cannedStorage;
        private readonly IOrderStorage _orderStorage;

        public ReportLogic(ICannedStorage cannedStorage, IOrderStorage orderStorage)
        {
            _cannedStorage = cannedStorage;
            _orderStorage = orderStorage;
        }
        /// <summary>
        /// Получение списка путёвок с указанием, какие компоненты в них используются
        /// </summary>
        /// <returns></returns>
        public List<ReportCannedComponentViewModel> GetComponentCanned()
        {
            var canneds = _cannedStorage.GetFullList();
            var list = new List<ReportCannedComponentViewModel>();
            foreach (var canned in canneds)
            {
                var record = new ReportCannedComponentViewModel
                {
                    CannedName = canned.CannedName,
                    Components = new List<Tuple<string, int>>(),
                    TotalCount = 0
                };
                foreach (var component in canned.CannedComponents)
                {
                    record.Components.Add(new Tuple<string, int>(component.Value.Item1, component.Value.Item2));
                    record.TotalCount += component.Value.Item2;
                }
                list.Add(record);
            }
            return list;
        }
        /// <summary>
        /// Получение списка заказов за определенный период
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<ReportOrdersViewModel> GetOrders(ReportBindingModel model)
        {
            return _orderStorage.GetFilteredList(new OrderBindingModel { DateFrom = model.DateFrom, DateTo = model.DateTo })
            .Select(x => new ReportOrdersViewModel
            {
                DateCreate = x.DateCreate,
                CannedName = x.CannedName,
                Count = x.Count,
                Sum = x.Sum,
                Status = Convert.ToString((OrderStatus)Enum.Parse(typeof(OrderStatus), x.Status.ToString()))
            })
            .ToList();
        }
        /// <summary>
        /// Сохранение путёвок в файл-Word
        /// </summary>
        /// <param name="model"></param>
        public void SaveCannedsToWordFile(ReportBindingModel model)
        {
            SaveToWord.CreateDoc(new WordInfo
            {
                FileName = model.FileName,
                Title = "Список путёвок",
                Canneds = _cannedStorage.GetFullList()
            });
        }
        /// <summary>
        /// Сохранение путёвок с указанием компонентов в файл-Excel
        /// </summary>
        /// <param name="model"></param>
        public void SaveComponentCannedToExcelFile(ReportBindingModel model)
        {
            SaveToExcel.CreateDoc(new ExcelInfo
            {
                FileName = model.FileName,
                Title = "Список путёвок",
                CannedComponents = GetComponentCanned()
            });
        }
        /// <summary>
        /// Сохранение заказов в файл-Pdf
        /// </summary>
        /// <param name="model"></param>
        public void SaveOrdersToPdfFile(ReportBindingModel model)
        {
            SaveToPdf.CreateDoc(new PdfInfo
            {
                FileName = model.FileName,
                Title = "Список заказов",
                DateFrom = model.DateFrom.Value,
                DateTo = model.DateTo.Value,
                Orders = GetOrders(model)
            });
        }
    }
}