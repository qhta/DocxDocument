namespace ModelGenApp.ViewModels;

public class MainViewModel : ViewModel
{
  public ProcessMonitorViewModel ProcessMonitorVM
  {
   [DebuggerStepThrough] get { return ProcessMonitor.VM; }
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
   [DebuggerStepThrough] get { return _ProcessMonitor; }
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
   [DebuggerStepThrough] get { return Options; }
    set
    {
      if (Options != value)
      {
        Options = value;
        NotifyPropertyChanged(nameof(ProcessOptionsVM));
      }
    }
  }
  private ProcessOptionsViewModel Options;

  public Window? StartWindow
  {
   [DebuggerStepThrough] get { return _StartWindow; }
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
    Options = new ProcessOptionsViewModel();
    OpenConfigCommand = new RelayCommand<string>(OpenConfig, CanOpenConfig) { Name = "OpenConfigCommand" };
    StartProcessCommand = new RelayCommand(StartProcess, CanStartProcess) { Name = "StartProcessCommand" };
    StopProcessCommand = new RelayCommand(StopProcess, CanStopProcess) { Name = "StopProcessCommand" };
    ContinueProcessCommand = new RelayCommand(ContinueProcess, CanContinueProcess) { Name = "ContinueProcessCommand" };
    ProcessOptionsVM.PropertyChanged += ProcessOptionsVM_PropertyChanged;
    ProcessOptionsVM.RestoreOptions();
  }

  private void ProcessOptionsVM_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs args)
  {
    if (sender is ProcessOptionsViewModel processOptionsVM)
    {
      if (args.PropertyName == nameof(ProcessOptionsVM.AppDataFolder))
      {
        ModelConfig.LoadInstance(processOptionsVM.AppDataFolder);
      }
      else
      if (args.PropertyName == nameof(ProcessOptionsVM.StopAtPhase))
        if (Creator != null)
        {
          var phaseNum = processOptionsVM.StopAtPhase;
          if (phaseNum is int n)
          {
            Creator.StopAtPhase = (PPS)Enum.ToObject(typeof(PPS), n);
            var options = this.ProcessOptionsVM.Model;
            options.StopAtPhase = n;
            ProcessOptionsMgr.SaveInstance((ProcessOptions)options);
          }
        }
    }
    StartProcessCommand.NotifyCanExecuteChanged();
    CommandManager.InvalidateRequerySuggested();
  }

  #region OpenConfigCommand
  public Command OpenConfigCommand { get; }

  public bool CanOpenConfig(string? parameter)
  {
    return Options.InputAssembly != null && ModelConfig.Instance!=null;
  }

  protected void OpenConfig(string? parameter)
  {
    if (Options.InputAssembly == null)
      throw new InvalidOperationException(CommonStrings.Input_assembly_not_specified);
    if (ModelConfig.Instance==null)
      throw new InvalidOperationException(CommonStrings.Model_configuration_not_defined);
    if (ModelConfigVM==null || Options.InputAssembly != ModelConfigVM.AssemblyName)
      ModelConfigVM = new ModelConfigViewModel(Options.InputAssembly, ModelConfig.Instance);
    if (parameter == "Namespaces")
      WindowsManager.ShowWindow<ModelConfigWindow>(ModelConfigVM.NamespaceConfigList);
    else
    if (parameter == "Types")
      WindowsManager.ShowWindow<ModelConfigWindow>(ModelConfigVM.TypeConfigList);
    else
    if (parameter == "Properties")
      WindowsManager.ShowWindow<ModelConfigWindow>(ModelConfigVM.PropertiesConfigList);
  }

  public ModelConfigViewModel ModelConfigVM { get; private set; } = null!;

  #endregion

  #region StartStopProcess commands

  public bool ProcessStarted
  {
   [DebuggerStepThrough] get { return _ProcessStarted; }
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
    return ProcessOptionsVM.ProjectName!=null && ProcessOptionsVM.SolutionName!=null && ProcessOptionsVM.RootNamespace!=null
      && ProcessOptionsVM.ScanTypeName!=null /*&& ProcessOptionsVM.ModelDocFileName!=null*/ && ProcessOptionsVM.CodeOutputPath != null
      && ProcessOptionsVM.StopAtPhase > 0 && !ProcessStarted;
  }

  public async void StartProcess()
  {
    await StartProcess(false);
  }

  public async Task StartProcess(bool continueProcess)
  {
    if (ProcessOptionsVM.ProjectName==null)
      throw new System.InvalidOperationException(CommonStrings.Project_name_not_defined);
    if (ProcessOptionsVM.CodeOutputPath==null)
      throw new System.InvalidOperationException(CommonStrings.Code_output_path_not_defined);
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
      if (ModelConfig.Instance==null)
        throw new InvalidOperationException(CommonStrings.Model_configuration_not_defined);
      var configPath = ModelConfig.Instance.GetConfigPath();
      Creator = new Creator(ProcessOptionsVM.Model);
    }
    if (Creator != null)
    {
      if (!continueProcess)
        this.ProcessMonitor.Clear();
      Creator.ModelMonitor = this.ProcessMonitor;
      await Task.Factory.StartNew(() => Creator.RunProcess(options, continueProcess));
      Creator.CancelRequest = false;
    }
    ProcessStarted = false;
  }

  public Creator? Creator { get; set; }

  public Command StopProcessCommand { get; }

  public bool CanStopProcess()
  {
    return Creator != null && ProcessStarted;
  }

  public void StopProcess()
  {
    if (Creator != null)
      Creator.CancelRequest = true;
  }

  public Command ContinueProcessCommand { get; }

  public bool CanContinueProcess()
  {
    return Creator != null && Creator.CanContinue && !ProcessStarted;
  }


  public async void ContinueProcess()
  {
    await StartProcess(true);

  }
  #endregion
}
