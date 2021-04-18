using System.Collections.Generic;
using CannedFactoryBusinessLogic.ViewModels;

namespace CannedFactoryBusinessLogic.HelperModels
{
    class WordInfo
    {
        public string FileName { get; set; }

        public string Title { get; set; }

        public List<CannedViewModel> Canneds { get; set; }
    }
}