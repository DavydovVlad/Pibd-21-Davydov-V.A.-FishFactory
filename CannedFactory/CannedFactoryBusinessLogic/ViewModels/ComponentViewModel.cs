using CannedFactoryBusinessLogic.Attributes;
using System.ComponentModel;

namespace CannedFactoryBusinessLogic.ViewModels
{
    /// <summary>
    /// Компонент, требуемый для изготовления путёвки
    /// </summary>
    public class ComponentViewModel
    {
		[Column(title: "Number", width: 100)]
        public int Id { get; set; }

        [Column(title: "Component name", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ComponentName { get; set; }
    }
}