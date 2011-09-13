using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompanyAccounts.Companies.Services;
using CompanyAccounts.Companies.ViewModels;
using CompanyAccounts.Companies.Views;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace CompanyAccounts.Companies
{
    public class CompaniesModule : IModule
    {
        readonly IUnityContainer container;
        readonly IRegionManager regionManager;

        public CompaniesModule(IUnityContainer container, IRegionManager regionManager)
        {
            this.container = container;
            this.regionManager = regionManager;
        }

        #region Implementation of IModule

        public void Initialize()
        {
            container.RegisterType<INavigationService, NavigationService>();
            container.RegisterType<IMainMenuViewModel, MainMenuViewModel>();
            container.RegisterType<IMainMenuView, MainMenuView>();
            regionManager.RegisterViewWithRegion("MenuRegion", typeof(IMainMenuView));

            container.RegisterType<Object, CreateCompanyView>("CreateCompanyView");
 

        }

        #endregion
    }
}
