using ModelGenApp.ViewModels;

namespace ModelGenApp.Views;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
  public MainWindow()
  {
    InitializeComponent();
    MainViewModel = new MainViewModel();
    DataContext = MainViewModel;
  }

  public MainViewModel MainViewModel { get; }

}
