namespace ModelGenApp;

public partial class MainViewModel : ObservableObject
{
  [ObservableProperty]
  public ProcessOptions processOptions;

  public MainViewModel()
  {
    ProcessOptions = ProcessOptionsMgr.GetInstance();
    StartProcessCommand = new RelayCommand(StartProcess);
  }

  public ICommand StartProcessCommand { get; }

  public void StartProcess()
  {
    var options = this.ProcessOptions;
    if (options != null)
      ProcessOptionsMgr.SaveInstance(options);
  }
}
