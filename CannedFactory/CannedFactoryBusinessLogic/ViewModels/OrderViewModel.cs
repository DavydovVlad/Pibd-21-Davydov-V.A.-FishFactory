using System;
using CannedFactoryBusinessLogic.Attributes;
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
        [Column(title: "Number", gridViewAutoSize: GridViewAutoSize.Fill)]
		[DataMember]
        public int Id { get; set; }

		[DataMember]
        public int? ImplementerId { get; set; }

        [DataMember] 
        public int ClientId { get; set; }

        [DataMember]
        public int CannedId { get; set; }

        [DataMember]
        [Column(title: "Client", gridViewAutoSize: GridViewAutoSize.Fill)] 
        public string ClientFIO { get; set; }

        [DataMember]
        [Column(title: "Canned", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string CannedName { get; set; }

        [DataMember]
        [Column(title: "Implementer", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ImplementerFIO { get; set; }
        
		[DataMember]
        [Column(title: "Quantity", gridViewAutoSize: GridViewAutoSize.Fill)]
        public int Count { get; set; }

        [DataMember]
        [Column(title: "Sum", gridViewAutoSize: GridViewAutoSize.Fill)]
        public decimal Sum { get; set; }

        [DataMember]
        [Column(title: "Status", gridViewAutoSize: GridViewAutoSize.Fill)]
        public OrderStatus Status { get; set; }
        
        [DataMember]
        [Column(title: "Creation date", gridViewAutoSize: GridViewAutoSize.Fill)]
        public DateTime DateCreate { get; set; }

        [DataMember]
        [Column(title: "Complition date", gridViewAutoSize: GridViewAutoSize.Fill)]
        public DateTime? DateImplement { get; set; }
    }
}