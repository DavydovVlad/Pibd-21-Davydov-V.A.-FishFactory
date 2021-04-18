using System;
using System.Collections.Generic;

namespace CannedFactoryBusinessLogic.ViewModels
{
    public class ReportCannedComponentViewModel
    {
        public string CannedName { get; set; }

        public int TotalCount { get; set; }

        public List<Tuple<string, int>> Components { get; set; }
    }
}