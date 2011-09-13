using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CompanyAccounts.Companies.ViewModels;
using Microsoft.Practices.Unity;
using NavigationService = CompanyAccounts.Companies.Services.NavigationService;

namespace CompanyAccounts.Companies.Views
{
    /// <summary>
    /// Interaction logic for MainMenuView.xaml
    /// </summary>
    public partial class MainMenuView : UserControl, IMainMenuView
    {
        public MainMenuView()
        {
            InitializeComponent();
            
        }

        [Dependency]
        public IMainMenuViewModel ViewModel
        {
            get { return DataContext as IMainMenuViewModel; }
            set { DataContext = value; }
        }
    }
}
