using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using CompanyAccounts.Companies;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;

namespace ContractorAccounts.Desktop
{
    internal class Bootstrapper : UnityBootstrapper
    {
        #region Overrides of Bootstrapper

        protected override DependencyObject CreateShell()
        {
            var shell = new Shell();
            shell.Show();
            return shell;
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            var catalog = new ModuleCatalog();
            catalog.AddModule(typeof(CompaniesModule));
            return catalog;
        }

        #endregion
    }
}
