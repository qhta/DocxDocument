namespace ModelGenApp.ViewModels;

public class MainViewModel : ViewModel
{
  public ProcessMonitorViewModel ProcessMonitorVM
  {
    get { return ProcessMonitor.VM; }
    set
    {
      if (ProcessMonitor.VM != value)
      {
        ProcessMonitor.VM = value;
        NotifyPropertyChanged(nameof(ProcessMonitor));
      }
    }
  }

  public ProcessMonitor ProcessMonitor
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
  private ProcessMonitor _ProcessMonitor = new ProcessMonitor();

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
    OpenConfigCommand = new RelayCommand<string>(OpenConfig, CanOpenConfig) { Name = "OpenConfigCommand" };
    StartProcessCommand = new RelayCommand(StartProcess, CanStartProcess) { Name = "StartProcessCommand" };
    StopProcessCommand = new RelayCommand(StopProcess, CanStopProcess) { Name = "StopProcessCommand" };
    ContinueProcessCommand = new RelayCommand(ContinueProcess, CanContinueProcess) { Name = "ContinueProcessCommand" };
    ProcessOptionsVM.PropertyChanged += ProcessOptionsVM_PropertyChanged;
  }

  private void ProcessOptionsVM_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs args)
  {
    if (args.PropertyName == nameof(ProcessOptionsVM.StopAtPhase))
      if (ModelCreator != null)
      {
        var phaseNum = (sender as ProcessOptionsViewModel)?.StopAtPhase;
        if (phaseNum is int n)
          ModelCreator.StopAtPhase = (PPS)Enum.ToObject(typeof(PPS), n);
      }
    StartProcessCommand.NotifyCanExecuteChanged();
    CommandManager.InvalidateRequerySuggested();
  }

  #region OpenConfigCommand
  public Command OpenConfigCommand { get; }

  public bool CanOpenConfig(string parameter)
  {
    return true;
  }

  protected void OpenConfig(string parameter)
  {
    if (parameter == "Namespaces")
      WindowsManager.ShowWindow<ModelConfigWindow>(new NamespacesConfigViewModel(ModelConfig.Instance));
    else
    if (parameter == "Types")
      WindowsManager.ShowWindow<ModelConfigWindow>(new TypesConfigViewModel(ModelConfig.Instance));
    else
    if (parameter == "Properties")
      WindowsManager.ShowWindow<ModelConfigWindow>(new PropertiesConfigViewModel(ModelConfig.Instance));
  }
  #endregion

  #region StartStopProcess commands

  public bool ProcessStarted
  {
    get { return _ProcessStarted; }
    set
    {
      if (_ProcessStarted != value)
      {
        _ProcessStarted = value;
        NotifyPropertyChanged(nameof(ProcessStarted));
        StartProcessCommand.NotifyCanExecuteChanged();
        CommandManager.InvalidateRequerySuggested();
      }
    }
  }
  private bool _ProcessStarted;

  public Command StartProcessCommand { get; }

  public bool CanStartProcess()
  {
    return ProcessOptionsVM.StopAtPhase > 0 && !ProcessStarted;
  }

  public async void StartProcess()
  {
    await StartProcess(false);
  }

  public async Task StartProcess(bool continueProcess)
  {
    ProcessStarted = true;
    var options = this.ProcessOptionsVM.Model;
    ProcessOptionsMgr.SaveInstance((ProcessOptions)options);
    if (!continueProcess)
    {
      //var filePath = Assembly.GetExecutingAssembly().Location;
      //var index = filePath.IndexOf(@"\bin");
      //if (index > 0)
      //  filePath = filePath.Substring(0, index);
      //filePath = Path.GetDirectoryName(filePath) ?? "";
      //filePath = Path.GetDirectoryName(filePath) ?? "";
      //filePath = Path.Combine(filePath, @"ModelGen\DocumentModel");
      ModelCreator = new ModelCreator("DocumentModel", this.ProcessOptionsVM.ModelCodeOutputPath);
    }
    if (ModelCreator != null)
    {
      if (!continueProcess)
        this.ProcessMonitor.Clear();
      ModelCreator.ModelMonitor = this.ProcessMonitor;
      await Task.Run(() => ModelCreator.RunProcess(options, continueProcess));
      ModelCreator.CancelRequest = false;
    }
    ProcessStarted = false;
  }

  public ModelCreator? ModelCreator { get; set; }

  public Command StopProcessCommand { get; }

  public bool CanStopProcess()
  {
    return ModelCreator != null && ProcessStarted;
  }

  public void StopProcess()
  {
    if (ModelCreator != null)
      ModelCreator.CancelRequest = true;
  }

  public Command ContinueProcessCommand { get; }

  public bool CanContinueProcess()
  {
    return ModelCreator != null && ModelCreator.CanContinue && !ProcessStarted;
  }


  public async void ContinueProcess()
  {
    await StartProcess(true);

  }
  #endregion
}
