using System.Collections.Generic;
using CannedFactoryBusinessLogic.Attributes;
using System.Runtime.Serialization;

namespace CannedFactoryBusinessLogic.ViewModels
{
    [DataContract]
    public class CannedViewModel
    {
        [Column(title: "Номер", width: 100)]
		[DataMember]
        public int Id { get; set; }

        [DataMember]
        [Column(title: "Название консервов", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string CannedName { get; set; }

        [DataMember]
        [Column(title: "Цена", width: 100)]
        public decimal Price { get; set; }

        [DataMember]
		[Column(visible: false)]
        public Dictionary<int, (string, int)> CannedComponents { get; set; }
    }
}