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
    var modelDataFilename = ModelData.GetFilename();
    if (File.Exists(modelDataFilename))
      try
      {
        ModelData.LoadData(modelDataFilename);
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Error while reading {modelDataFilename}: " + ex.ToString());
      }
    else
      try
      {
        ModelData.SaveData(modelDataFilename);
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Error while writing {modelDataFilename}: " + ex.ToString());
      }
  }

  public MainViewModel MainViewModel { get; }

}
