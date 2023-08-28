using System.Runtime.InteropServices;

namespace ModelGenApp.Helpers;

/// <summary>
/// Helper class which shows "busy" cursor on registered Task 
/// and returns to standard arrow when the task finishes.
/// </summary>
public class BusyMonitor : ObservableObject
{
  /// <summary>
  /// Default constructor is private to prevent creating an instance in the caller class.
  /// </summary>
  public BusyMonitor() { }

  /// <summary>
  /// Gets common instance.
  /// </summary>
  public static BusyMonitor Instance
  {
    get
    {
      if (_instance == null)
        _instance = new BusyMonitor();
      return _instance;
    }
  }
  private static BusyMonitor _instance = null!;



  public bool IsBusy
  {
    get { return _IsBusy; }
    set
    {
      if (_IsBusy != value)
      {
        _IsBusy = value;
        NotifyPropertyChanged(nameof(IsBusy));
      }
    }
  }
  private bool _IsBusy;

  private int BusyCounter;

  public async Task Monitor(Task task)
  {
    SwitchOn(task);
    var finalTask = task.ContinueWith((task)=>SwitchOff(task));
    await finalTask;
  }

  private void SwitchOn(Task task) 
  {
    BusyCounter++;
    IsBusy = true;
    //Debug.WriteLine($"Busy={IsBusy} at {DateTime.Now:HH:mm:ss:fff}");
  }
  private void SwitchOff(Task task) 
  {
    if (BusyCounter > 0)
      BusyCounter--;
    IsBusy = BusyCounter>0;
    //Debug.WriteLine($"Busy={IsBusy} at {DateTime.Now:HH:mm:ss:fff}");
  }
}
