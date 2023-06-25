namespace ModelGenApp.ViewModels;

public class MainViewModel : ViewModel
{


  public ProcessMonitor? ProcessMonitor
  {
    get { return _ProcessMonitor; }
    set
    {
      if (_ProcessMonitor != value)
      {
        _ProcessMonitor = value;
        NotifyPropertyChanged(nameof(ProcessMonitor));
      }
    }
  }
  private ProcessMonitor? _ProcessMonitor;
  public ProcessOptionsViewModel ProcessOptionsVM
  {
    get { return _ProcessOptionsVM; }
    set
    {
      if (_ProcessOptionsVM != value)
      {
        _ProcessOptionsVM = value;
        NotifyPropertyChanged(nameof(ProcessOptionsVM));
      }
    }
  }
  private ProcessOptionsViewModel _ProcessOptionsVM;


  public Window? StartWindow
  {
    get { return _StartWindow; }
    set
    {
      if (_StartWindow != value)
      {
        _StartWindow = value;
        NotifyPropertyChanged(nameof(StartWindow));
      }
    }
  }
  private Window? _StartWindow;



  private IWindowService windowService;

  public MainViewModel()//: this()
  {
    this.windowService = new WindowService();
    _ProcessOptionsVM = new ProcessOptionsViewModel();
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
