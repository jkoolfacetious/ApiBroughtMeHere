using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace ApiBMHDesktopUserInterface.ViewModels
{
    public class LoginViewModel : Screen
    {
        private String _userName;
        private String _password;

        public int MyProperty
        {
            get { return _userName; }
            set { _userName = value; }
        }


    }
}
