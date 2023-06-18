using ModelGenApp.Views;

namespace ModelGenApp;
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
    StartWindow = new Views.StartWindow();
    StartWindow.DataContext = MainViewModel;
    StartWindow.Closing += StartWindow_Closing;
    StartWindow.Closed += StartWindow_Closed;
  }

  public MainViewModel MainViewModel { get; }

  private void StartWindow_Closing(object? sender, System.ComponentModel.CancelEventArgs e)
  {
    StartWindowIsClosing = true;
  }

  private void StartWindow_Closed(object? sender, EventArgs e)
  {
    StartWindowIsClosed = true;
  }

  private StartWindow StartWindow { get; set; }
  private bool StartWindowIsOpened;
  private bool StartWindowIsClosing;
  private bool StartWindowIsClosed;
  protected override void OnActivated(EventArgs e)
  {
    if (!StartWindowIsOpened && !StartWindowIsClosing && !StartWindowIsClosed)
    {                        
      StartWindowIsOpened = true;
      StartWindow.Owner = this;
      StartWindow.Show();
    }
  }
}
