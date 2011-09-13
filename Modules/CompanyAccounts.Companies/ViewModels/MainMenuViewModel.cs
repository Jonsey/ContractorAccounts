using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompanyAccounts.Companies.Services;
using Microsoft.Practices.Prism.Commands;

namespace CompanyAccounts.Companies.ViewModels
{
    

    public sealed class MainMenuViewModel : IMainMenuViewModel
    {
        enum CompanyViews
        {
            CreateNew
        }

        readonly INavigationService navigationService;
        DelegateCommand navigateToCreateCompanyCommand;

        public MainMenuViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public DelegateCommand NavigateToCreateCompanyCommand
        {
            get
            {
                return navigateToCreateCompanyCommand ?? (navigateToCreateCompanyCommand = new DelegateCommand(() => NavigateTo(CompanyViews.CreateNew)));
            }
        }

        void NavigateTo(CompanyViews view)
        {
            navigationService.NavigateToCreateCompany();
        }

        
    }
}
