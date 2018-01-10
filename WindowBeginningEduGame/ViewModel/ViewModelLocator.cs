using Ninject;

namespace WindowBeginningEduGame
{
    /// <summary>
    /// Locates view models from the IoC for use in binding in xaml
    /// </summary>

    public class ViewModelLocator
    {
        public static ViewModelLocator Instance { get; private set; } = new ViewModelLocator();

        public static ApplicationViewModel ApplicationViewModel => IoC.ApplicationKernel.Get<ApplicationViewModel>();

        public static ControlViewModel ControlViewModel => IoC.ControlKernel.Get<ControlViewModel>();
    }
}
