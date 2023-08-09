using Qhta.MVVM;
using Qhta.WPF.Behaviors;

namespace ModelGenApp.Views;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
  public MainWindow()
  {
    ObservableObject.CommonDispatcher = new DispatcherBridge(Dispatcher.CurrentDispatcher);
    Command.CanExecuteChangedListener = new CommandManagerBridge();
    InitializeComponent();
    MainViewModel = new MainViewModel();
    DataContext = MainViewModel;
    var modelDataFilename = ModelConfig.Instance.GetFilename();
    if (File.Exists(modelDataFilename))
      try
      {
        ModelConfig.Instance.LoadData(modelDataFilename);
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Error while reading {modelDataFilename}: " + ex.ToString());
      }
    else
      try
      {
        ModelConfig.Instance.SaveData(modelDataFilename);
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Error while writing {modelDataFilename}: " + ex.ToString());
      }
  }

  public MainViewModel MainViewModel { get; }

  private void ProcessOptionsView_Loaded(object sender, RoutedEventArgs e)
  {

  }
}
