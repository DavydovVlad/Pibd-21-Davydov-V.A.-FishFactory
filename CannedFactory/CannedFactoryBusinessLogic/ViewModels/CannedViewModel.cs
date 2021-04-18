using System.Collections.Generic;
using System.ComponentModel;

namespace CannedFactoryBusinessLogic.ViewModels
{
    public class CannedViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название консервов")]
        public string CannedName { get; set; }

        [DisplayName("Цена")]
        public decimal Price { get; set; }

        public Dictionary<int, (string, int)> CannedComponents { get; set; }
    }
}