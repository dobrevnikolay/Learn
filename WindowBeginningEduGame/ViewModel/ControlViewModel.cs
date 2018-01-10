using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowBeginningEduGame
{
    public class ControlViewModel : BaseViewModel
    {
        /// <summary>
        /// Stores the current Control Context
        /// </summary>

        private ControlContext mControlContext = ControlContext.TopicMenu;

        /// <summary>
        /// Provide access to current Control context
        /// </summary>

        public ControlContext CurrentControlContext
        {
            get
            {
                return mControlContext;
            }
            set
            {
                mControlContext = value;
                this.OnPropertyChanged();
            }
        }
    }
}
