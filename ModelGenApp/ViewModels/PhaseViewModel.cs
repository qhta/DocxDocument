using ModelGenApp.Views;

namespace ModelGenApp.ViewModels;

/// <summary>
/// Observable monitor for a single process phase
/// </summary>
public partial class PhaseMonitor : ViewModel
{

  public PhaseMonitor()
  {
    ShowResultsCommand = new RelayCommand(ShowResultsExecute, ShowResultsCanExecute){ DebugName="ShowResultsCommand" };
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
        SummaryVM.Add(new SummaryValueViewModel{ Name = info.Key, Value = info.Value });
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

  public void GetNamespaces(NTS filter)
  {
    NamespacesVM = new NamespaceListViewModel();
    var namespaces = TypeManager.GetNamespaces(filter).OrderBy(item=>item);
    foreach (var ns in namespaces)
    {
      var nsVM = new NamespaceViewModel{ Name = ns };
      var nsTypes = TypeManager.GetNamespaceTypes(ns).OrderBy(item=>item.Name).ToList();
      nsVM.AllTypesCount = nsTypes.Count();
      NamespacesVM.Add(nsVM);
    }
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
  protected virtual void ShowResultsExecute()
  {
    if (window == null)
     window = new PhaseResultsWindow();
    window.DataContext = this;
    window.Show();
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
    await Task.Run(() => {
    GetNamespaces(NTS.Origin|NTS.System);
      });
  }

  #endregion
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
    ShowResultsCommand.NotifyCanExecuteChanged();
    ShowOverviewCommand.NotifyCanExecuteChanged();
    ShowDetailsCommand.NotifyCanExecuteChanged();
  }

  protected virtual void ShowDetailsExecute()
  {
  }

  protected virtual bool ShowDetailsCanExecute()
  {
    return Percentage == 100;
  }


}
