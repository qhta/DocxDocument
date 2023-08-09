namespace ModelGenApp.ViewModels;
public class ProcessMonitorViewModel : ViewModel
{

  public ProcessMonitorViewModel()
  {
    const int numPhases = 6;
    PhaseMonitors = new PhaseViewModel[numPhases];
    for (int i = 0; i < numPhases; i++)
    {
      PPS phase = (PPS)Enum.ToObject(typeof(PPS),i+1);
      switch (phase)
      {
        case PPS.ScanTypes:
          PhaseMonitors[i] = new ScanPhaseViewModel (phase.ToString());
          break;
        case PPS.RenameTypes:
          PhaseMonitors[i] = new RenamePhaseViewModel(phase.ToString());
          break;
        case PPS.ConvertTypes:
          PhaseMonitors[i] = new ConvertPhaseViewModel(phase.ToString());
          break;
      }
  }

}

public void WriteLine()
{
  Dispatcher?.Invoke(() => Lines.Add(string.Empty));
}

public void WriteLine(string line)
{
  Dispatcher?.Invoke(() => Lines.Add(line));
}

public void WriteSameLine(string line)
{
  Dispatcher?.Invoke(() => StatusLine = line);
}

public ObservableList<string> Lines
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
private ObservableList<string> _Lines = new();

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

public PhaseViewModel[] PhaseMonitors
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
private PhaseViewModel[] _PhaseMonitors = null!;

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
