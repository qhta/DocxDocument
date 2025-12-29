using DocxEd.ViewModels;
using Qhta.MVVM;
using Qhta.ObservableObjects;
using Qhta.WPF.Utils;

namespace DocxEd.Views;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
  public MainWindow()
  {
    ObservableObject.CommonDispatcher = new DispatcherBridge(Dispatcher.CurrentDispatcher);
    Command.CommandManager = new CommandManagerBridge();
    InitializeComponent();

    var selectedProject = ProcessOptionsMgr.LoadInstanceName();
    ProcessOptionsMgr.DataFolder = selectedProject;
    var options = ProcessOptionsMgr.CurrentInstance;

    //ModelConfig.SetDataFolder(options.AppDataFolder ?? "");
    var modelDataFilename = ModelConfig.GetFilename(options.AppDataFolder);
    if (!File.Exists(modelDataFilename))
    {
      ModelConfig.CreateInstance(options.AppDataFolder);
      if (ModelConfig.Instance == null)
        throw new InvalidOperationException(CommonStrings.Model_configuration_not_defined);
      try
      {
        ModelConfig.Instance.SaveDataInFile(modelDataFilename);
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Error while writing {modelDataFilename}: " + ex.ToString());
      }
    }
    else
    {
      try
      {
        ModelConfig.LoadInstance(options.AppDataFolder);
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Error while reading {modelDataFilename}: " + ex.ToString());
      }
    }

    MainViewModel = new MainViewModel();
    DataContext = MainViewModel;
  }

  public MainViewModel MainViewModel { [DebuggerStepThrough] get; }

  private void ProcessOptionsView_Loaded(object sender, RoutedEventArgs e)
  {

  }
}
