using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Regions;

namespace CompanyAccounts.Companies.Services
{
    public sealed class NavigationService : INavigationService
    {
        readonly IRegionManager regionMangergion;

        public NavigationService(IRegionManager regionMangergion)
        {
            this.regionMangergion = regionMangergion;
        }

        public void NavigateToCreateCompany()
        {
            regionMangergion.RequestNavigate("MainRegion", new Uri("CreateCompanyView", UriKind.Relative));
        }
    }
}
