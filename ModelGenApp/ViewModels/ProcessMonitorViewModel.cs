namespace ModelGenApp.ViewModels;
public class ProcessMonitorViewModel : ViewModel
{

  public ProcessMonitorViewModel()
  {
    const int numPhases = 6;
    PhaseMonitors = new PhaseMonitor[numPhases];
    for (int i = 0; i < numPhases; i++)
    {
      PhaseMonitors[i] = new PhaseMonitor{ PhaseNumber=i+1, PhaseName=Enum.ToObject(typeof(PPS),i+1).ToString() };
    }

  }

  public void WriteLine()
  {
    DispatcherHelper.Execute(() => Lines.Add(string.Empty));
  }

  public void WriteLine(string line)
  {
    DispatcherHelper.Execute(() => Lines.Add(line));
  }

  public void WriteSameLine(string line)
  {
    DispatcherHelper.Execute(() => StatusLine = line);
  }

  public ObservableCollection<string> Lines
  {
    get { return _Lines; }
    set
    {
      if (_Lines != value)
      {
        _Lines = value;
        NotifyPropertyChanged(nameof(Lines));
      }
    }
  }
  private ObservableCollection<string> _Lines = new();


  public string? StatusLine
  {
    get { return _StatusLine; }
    set
    {
      if (_StatusLine != value)
      {
        _StatusLine = value;
        NotifyPropertyChanged(nameof(StatusLine));
      }
    }
  }
  private string? _StatusLine;


  public PhaseMonitor[] PhaseMonitors
  {
    get { return _PhaseMonitors; }
    set
    {
      if (_PhaseMonitors != value)
      {
        _PhaseMonitors = value;
        NotifyPropertyChanged(nameof(PhaseMonitors));
      }
    }
  }
  private PhaseMonitor[] _PhaseMonitors = null!;

  public int Percentage
  {
    get { return _Percentage; }
    set
    {
      if (_Percentage != value)
      {
        _Percentage = value;
        NotifyPropertyChanged(nameof(Percentage));
      }
    }
  }
  private int _Percentage;

}
