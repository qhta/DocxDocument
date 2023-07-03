using ModelGenApp.Views;

namespace ModelGenApp.ViewModels;

/// <summary>
/// Observable monitor for a single process phase
/// </summary>
public partial class PhaseViewModel : ViewModel
{

  public PhaseViewModel()
  {
    ShowResultsCommand = new RelayCommand(ShowResultsExecute, ShowResultsCanExecute) { Name = "ShowResultsCommand" };
    ShowOverviewCommand = new RelayCommand(ShowOverviewExecute, ShowOverviewCanExecute) { Name = "ShowOverviewCommand" };
    PropertyChanged += PhaseMonitor_PropertyChanged;
  }

  private void PhaseMonitor_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
  {
    NotifyCanExecuteChanged();
  }
  public void NotifyCanExecuteChanged()
  {
    ShowResultsCommand.NotifyCanExecuteChanged();
    ShowOverviewCommand.NotifyCanExecuteChanged();
  }



  public string Name
  {
    get { return _Name; }
    set
    {
      if (_Name != value)
      {
        _Name = value;
        NotifyPropertyChanged(nameof(Name));
      }
    }
  }
  private string _Name = null!  ;

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

  /// <summary>
  /// Percent of the phase advantage.
  /// </summary>
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

  #region Summary
  public SummaryViewModel SummaryVM
  {
    get { return _SummaryVM; }
    set
    {
      if (_SummaryVM != value)
      {
        _SummaryVM = value;
        NotifyPropertyChanged(nameof(SummaryVM));
      }
    }
  }
  private SummaryViewModel _SummaryVM = null!;

  public void SetSummary(SummaryInfo summary)
  {
    SummaryVM = new SummaryViewModel();
    if (summary.Summary != null)
      foreach (var info in summary.Summary)
        SummaryVM.Add(new SummaryValueViewModel { Name = info.Key.ToString().DeCamelCase(), InfoKind = info.Key, Value = info.Value });
    SummaryVM.PropertyChanged += SummaryVM_PropertyChanged;
  }

  private void SummaryVM_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
  {
    if (e.PropertyName == nameof(SummaryVM.Filter))
    {
      var summary = sender as SummaryViewModel;
      if (summary != null)
      {
        var filter = summary.Filter;
        SetFilter(filter);
      }
    }
  }
  #endregion

  #region Namespaces
  public NamespaceListViewModel NamespacesVM
  {
    get { return _Namespaces; }
    set
    {
      if (_Namespaces != value)
      {
        _Namespaces = value;
        NotifyPropertyChanged(nameof(NamespacesVM));
      }
    }
  }
  private NamespaceListViewModel _Namespaces = null!;

  public void GetNamespaces(NTS nts)
  {
    NamespacesVM = new NamespaceListViewModel(this, nts, Filter);
  }
  #endregion

  #region ShowResultsCommand
  /// <summary>
  /// Command to show phase result window.
  /// </summary>
  public Command ShowResultsCommand
  {
    get { return _ShowResultsCommand; }
    set
    {
      if (_ShowResultsCommand != value)
      {
        _ShowResultsCommand = value;
        NotifyPropertyChanged(nameof(_ShowResultsCommand));
      }
    }
  }
  private Command _ShowResultsCommand = null!;

  Window? window;
  protected virtual async void ShowResultsExecute()
  {
    if (window != null && window.IsVisible)
    {
      window.Topmost = true;
      window.Focus();
    }
    else
    {
      window = new PhaseResultsWindow();
      window.DataContext = this;
      window.Show();
      await Task.Run(() => ShowOverviewExecute());
    }
  }

  protected virtual bool ShowResultsCanExecute()
  {
    return Percentage == 100;
  }
  #endregion

  #region ShowOverviewCommand
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


  protected virtual bool ShowOverviewCanExecute()
  {
    return Percentage == 100;
  }

  protected virtual async void ShowOverviewExecute()
  {
    await Task.Run(() =>
    {
      GetNamespaces(NTS.Origin | NTS.System);
    });
  }

  #endregion

  #region Filter namespaces


  public string? Filter
  {
    get { return _Filter; }
    set
    {
      if (_Filter != value)
      {
        _Filter = value;
        NotifyPropertyChanged(nameof(Filter));
      }
    }
  }
  private string? _Filter;

  public async void SetFilter(string? filter)
  {
    Filter = filter;
    await Task.Run(() =>
    {
      GetNamespaces(NTS.Origin | NTS.System);
    });
  }
  #endregion
}
