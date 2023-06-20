using System.ComponentModel;

using ModelGenApp.ViewModels;

namespace ModelGenApp;

public partial class MainViewModel : ObservableObject
{
  [ObservableProperty]
  private StartProcessViewModel startProcessVM;

  [ObservableProperty]
  private Window? startWindow;

  [ObservableProperty]
  private IWindowService windowService;

  [ObservableProperty]
  private ProcessMonitorViewModel? processMonitor;

  public MainViewModel()//: this()
  {
    this.windowService = new WindowService();
    StartProcessVM = new StartProcessViewModel(this);
    OpenStartWindowCommand = new RelayCommand(OpenStartWindow);
  }

  public ICommand OpenStartWindowCommand { get; }

  public bool CanOpenStartWindow()
  {
    return StartWindow == null;
  }

  public void OpenStartWindow()
  {
    var window = WindowService.ShowWindow(StartProcessVM, Application.Current.MainWindow);
    if (window != null)
    {
      window.Closed += StartWindow_Closed;
      StartProcessVM.ThisWindow = window;
    }
  }

  private void StartWindow_Closed(object? sender, EventArgs e)
  {
    if (StartProcessVM.StartRequest == true)
    {
      var worker = new BackgroundWorker();
      worker.DoWork += Worker_DoWork;
      worker.RunWorkerAsync();
    }
  }

  private void Worker_DoWork(object? sender, DoWorkEventArgs args)
  {
    var options = StartProcessVM.ProcessOptionsVM.Options;
    var filePath = Assembly.GetExecutingAssembly().Location;
    var index = filePath.IndexOf(@"\bin");
    if (index > 0)
      filePath = filePath.Substring(0, index);
    filePath = Path.GetDirectoryName(filePath) ?? "";
    filePath = Path.GetDirectoryName(filePath) ?? "";
    filePath = Path.Combine(filePath, @"ModelGen\DocumentModel");
    var creator = new ModelCreator("DocumentModel", filePath);
    this.ProcessMonitor = new ProcessMonitorViewModel();
    creator.ModelMonitor = this.ProcessMonitor;
    creator.RunProcess(options);
  }
}
