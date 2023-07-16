namespace Proyecto2_EE_GG.ViewModels
{
    public class ViewModelBase : BindableObject
    {
        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
    }
}