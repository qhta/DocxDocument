
namespace ModelGenApp.ViewModels;
public partial class StartProcessViewModel : ObservableObject
{
  [ObservableProperty]
  private MainViewModel owner;

  [ObservableProperty]
  private ProcessOptionsViewModel processOptionsVM;

  [ObservableProperty]
  private Window? thisWindow;

  [ObservableProperty]
  private bool? startRequest;

  public StartProcessViewModel(MainViewModel owner)
  {
    this.owner = owner;
    processOptionsVM = new ProcessOptionsViewModel();
    StartProcessCommand = new RelayCommand(StartProcess);
    CloseWindowCommand = new RelayCommand(CloseWindow);
  }

  public ICommand StartProcessCommand { get; }

  public void StartProcess()
  {
    var options = this.ProcessOptionsVM.Options;
    if (options != null)
      ProcessOptionsMgr.SaveInstance((ProcessOptions)options);
    StartRequest = true;
    ThisWindow?.Close();
  }

  public ICommand CloseWindowCommand { get; }

  public void CloseWindow()
  {
    StartRequest = false;
    ThisWindow?.Close();
  }
}
