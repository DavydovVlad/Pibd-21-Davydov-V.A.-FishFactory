using System.Collections.Generic;
using CannedFactoryBusinessLogic.ViewModels;

namespace CannedFactoryBusinessLogic.HelperModels
{
    class ExcelInfo
    {
        public string FileName { get; set; }

        public string Title { get; set; }

        public List<ReportCannedComponentViewModel> CannedComponents { get; set; }
    }
}