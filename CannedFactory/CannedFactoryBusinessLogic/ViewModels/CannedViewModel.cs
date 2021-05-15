using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace CannedFactoryBusinessLogic.ViewModels
{
    [DataContract]
    public class CannedViewModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [DisplayName("Название консервов")]
        public string CannedName { get; set; }

        [DataMember]
        [DisplayName("Цена")]
        public decimal Price { get; set; }

        [DataMember]
        public Dictionary<int, (string, int)> CannedComponents { get; set; }
    }
}