namespace ModelGenApp.ViewModels;

/// <summary>
/// Observable monitor for a single process phase
/// </summary>
public partial class PhaseMonitor : ViewModel
{

  public PhaseMonitor()
  {
    ShowSummaryCommand = new RelayCommand(ShowSummaryExecute, ShowSummaryCanExecute){ DebugName="ShowSummaryCommand" };
    ShowOverviewCommand = new RelayCommand(ShowOverviewExecute, ShowOverviewCanExecute){ DebugName="ShowOverviewCommand" };
    ShowDetailsCommand = new RelayCommand(ShowDetailsExecute, ShowDetailsCanExecute){ DebugName="ShowDetailsCommand" };
    PropertyChanged += PhaseMonitor_PropertyChanged;
  }

  private void PhaseMonitor_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
  {
    NotifyCanExecuteChanged();
  }

  /// <summary>
  /// Id of the process phase.
  /// </summary>
  public int PhaseNumber
  {
    get => _PhaseNumber;
    set
    {
      if (value != _PhaseNumber)
      {
        _PhaseNumber = value;
        NotifyPropertyChanged(nameof(PhaseNumber));
      }
    }
  }
  private int _PhaseNumber;


  /// <summary>
  /// Name of the process phase.
  /// </summary>
  public string? PhaseName
  {
    get => _PhaseName;
    set
    {
      if (value != _PhaseName)
      {
        _PhaseName = value;
        NotifyPropertyChanged(nameof(PhaseName));
      }
    }
  }
  private string? _PhaseName;


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

  public Command ShowSummaryCommand
  {
    get { return _ShowSummaryCommand; }
    set
    {
      if (_ShowSummaryCommand != value)
      {
        _ShowSummaryCommand = value;
        NotifyPropertyChanged(nameof(_ShowSummaryCommand));
      }
    }
  }
  private Command _ShowSummaryCommand = null!;

  public Command ShowOverviewCommand
  {
    get { return _ShowOverviewCommand; }
    set
    {
      if (_ShowOverviewCommand != value)
      {
        _ShowOverviewCommand = value;
        NotifyPropertyChanged(nameof(ShowOverviewCommand));
      }
    }
  }
  private Command _ShowOverviewCommand = null!;

  public Command ShowDetailsCommand
  {
    get { return _ShowOverviewCommand; }
    set
    {
      if (_ShowDetailsCommand != value)
      {
        _ShowDetailsCommand = value;
        NotifyPropertyChanged(nameof(_ShowDetailsCommand));
      }
    }
  }
  private Command _ShowDetailsCommand = null!;

  public void NotifyCanExecuteChanged()
  {
    ShowSummaryCommand.NotifyCanExecuteChanged();
    ShowOverviewCommand.NotifyCanExecuteChanged();
    ShowDetailsCommand.NotifyCanExecuteChanged();
  }

  protected virtual void ShowSummaryExecute()
  {
  }

  protected virtual bool ShowSummaryCanExecute()
  {
    return Percentage == 100;
  }

  protected virtual void ShowOverviewExecute()
  {
  }

  protected virtual bool ShowOverviewCanExecute()
  {
    return Percentage == 100;
  }

  protected virtual void ShowDetailsExecute()
  {
  }

  protected virtual bool ShowDetailsCanExecute()
  {
    return Percentage == 100;
  }


}
