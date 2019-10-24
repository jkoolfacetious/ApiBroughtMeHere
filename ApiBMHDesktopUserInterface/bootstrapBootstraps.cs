using ApiBMHDesktopUserInterface.ViewModels;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ApiBMHDesktopUserInterface
{
   public class bootstrapBootstraps : BootstrapperBase
    {
        public bootstrapBootstraps()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
