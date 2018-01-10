using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowBeginningEduGame
{

    public class ApplicationViewModel : BaseViewModel
    {

        /// <summary>
        /// The application page
        /// </summary>
        private ApplicationPage applicationPage = ApplicationPage.Login;

        public ApplicationPage CurrentPage
        {
            get
            {
                return this.applicationPage;
            }
            set
            {
                this.applicationPage = value;
                this.OnPropertyChanged();
            }
        }

    }
}
