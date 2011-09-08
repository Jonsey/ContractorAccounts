using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompanyAccounts.Companies.Services;
using CompanyAccounts.Companies.ViewModels;
using NUnit.Framework;
using Rhino.Mocks;

namespace CompanyAccounts.Companies.Tests
{
    [TestFixture]
    public class CreateCompanyTests
    {
        [Test]
        public void ShouldNavigateToCreateCompanyView()
        {
            var mockNavigationService = MockRepository.GenerateMock<INavigationService>();
            
            mockNavigationService.Expect(x => x.NavigateToCreateCompany());

            var mainMenuViewModel = new MainMenuViewModel(mockNavigationService);
            mainMenuViewModel.NavigateToCreateCompanyCommand.Execute();

            mockNavigationService.VerifyAllExpectations();
        }
    }
}
