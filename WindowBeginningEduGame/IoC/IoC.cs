using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowBeginningEduGame
{
    /// <summary>
    /// The IoC container for our application
    /// </summary>

    public class IoC
    {
        public static IKernel ApplicationKernel { get; private set; } = new StandardKernel();

        public static IKernel ControlKernel { get; private set; } = new StandardKernel();

        /// <summary>
        /// Sets up the IoC container, binds all information
        /// Note: must be called as soon as your application starts up to 
        /// ensure all services can be found
        /// </summary>

        public static void Setup()
        {
            // Bind all Required view Models
            BindViewModels();
        }

        /// <summary>
        /// Bind all singleton View Models
        /// </summary>

        private static void BindViewModels()
        {
            // Bind to a single instance of Application view model
            ApplicationKernel.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel());

            ControlKernel.Bind<ControlViewModel>().ToConstant(new ControlViewModel());
        }
    }
}
