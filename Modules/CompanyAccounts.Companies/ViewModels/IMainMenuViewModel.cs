using Microsoft.Practices.Prism.Commands;

namespace CompanyAccounts.Companies.ViewModels
{
    public interface IMainMenuViewModel
    {
        DelegateCommand NavigateToCreateCompanyCommand { get; }
    }
}