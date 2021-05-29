﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using CannedFactoryBusinessLogic.Enums;

namespace CannedFactoryBusinessLogic.ViewModels
{
    /// <summary>
    /// Заказ
    /// </summary>
    [DataContract]
    public class OrderViewModel
    {
        [DataMember]
        public int Id { get; set; }

		[DataMember]
        public int? ImplementerId { get; set; }

        [DataMember] 
        public int ClientId { get; set; }

        [DataMember]
        public int CannedId { get; set; }

        [DataMember]
        [DisplayName("Клиент")] 
        public string ClientFIO { get; set; }

        [DataMember]
        [DisplayName("Консервы")]
        public string CannedName { get; set; }

        [DataMember]
        [DisplayName("Implementer")]
        public string ImplementerFIO { get; set; }
        
		[DataMember]
        [DisplayName("Количество")]
        public int Count { get; set; }

        [DataMember]
        [DisplayName("Сумма")]
        public decimal Sum { get; set; }

        [DataMember]
        [DisplayName("Статус")]
        public OrderStatus Status { get; set; }
        
        [DataMember]
        [DisplayName("Дата создания")]
        public DateTime DateCreate { get; set; }

        [DataMember]
        [DisplayName("Дата выполнения")]
        public DateTime? DateImplement { get; set; }
    }
}