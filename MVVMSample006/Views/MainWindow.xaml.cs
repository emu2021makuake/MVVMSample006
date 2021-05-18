using MVVMSample006.ViewModels;
using System.Windows;

namespace MVVMSample006.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
