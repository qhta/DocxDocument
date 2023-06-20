using System.ComponentModel;

namespace ModelGenApp.ViewModels;

public partial class MainViewModel : ObservableObject
{
  [ObservableProperty]
  private ProcessOptionsViewModel processOptionsVM;

  [ObservableProperty]
  private Window? startWindow;

  [ObservableProperty]
  private IWindowService windowService;

  [ObservableProperty]
  private ProcessMonitor? processMonitor;

  public MainViewModel()//: this()
  {
    this.windowService = new WindowService();
    ProcessOptionsVM = new ProcessOptionsViewModel();
    StartProcessCommand = new RelayCommand(StartProcess);
    CloseWindowCommand = new RelayCommand(CloseWindow);
  }

  public ICommand StartProcessCommand { get; }

  public ICommand CloseWindowCommand { get; }

  public void CloseWindow()
  {
  }


  public async void StartProcess()
  {
    var options = this.ProcessOptionsVM.Options;
    if (options != null)
    {
      ProcessOptionsMgr.SaveInstance((ProcessOptions)options);
      var filePath = Assembly.GetExecutingAssembly().Location;
      var index = filePath.IndexOf(@"\bin");
      if (index > 0)
        filePath = filePath.Substring(0, index);
      filePath = Path.GetDirectoryName(filePath) ?? "";
      filePath = Path.GetDirectoryName(filePath) ?? "";
      filePath = Path.Combine(filePath, @"ModelGen\DocumentModel");
      var creator = new ModelCreator("DocumentModel", filePath);
      this.ProcessMonitor = new ProcessMonitor();
      creator.ModelMonitor = this.ProcessMonitor;
      await Task.Run(() => creator.RunProcess(options));
    }
  }

}
