namespace CannedFactoryBusinessLogic.BindingModels
{
    /// <summary>
    /// Компонент, требуемый для изготовления путёвки
    /// </summary>
    public class ComponentBindingModel
    {
        public int? Id { get; set; }

        public string ComponentName { get; set; }
    }
}