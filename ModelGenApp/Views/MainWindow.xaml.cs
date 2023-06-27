using ModelGenApp.ViewModels;

using Qhta.DispatchedObjects;

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
    DispatchedObject.DispatcherBridge = new DispatcherBridge();
  }

  public MainViewModel MainViewModel { get; }

}
