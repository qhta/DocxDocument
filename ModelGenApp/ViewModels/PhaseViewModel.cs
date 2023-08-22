namespace ModelGenApp.ViewModels;

/// <summary>
/// Observable monitor for a single process phase
/// </summary>
public abstract partial class PhaseViewModel : ViewModel
{

  /// <summary>
  /// Initializing constructor. Needs a phase enum and name.
  /// </summary>
  /// <param name="phase"></param>
  /// <param name="name"></param>
  public PhaseViewModel(PPS phase, string name)
  {
    PhaseNum = phase;
    PhaseName = name;
    NameKindSelector = new NKS(false, false, false);
    SaveResultsCommand = new RelayCommand(SaveResultsExecute, SaveResultsCanExecute) { Name = "SaveResultsCommand" };
    ShowResultsCommand = new RelayCommand(ShowResultsExecute, ShowResultsCanExecute) { Name = "ShowResultsCommand" };
    RefreshResultsCommand = new RelayCommand(RefreshResultsExecute, RefreshResultsCanExecute) { Name = "RefreshResultsCommand" };
    PropertyChanged += PhaseMonitor_PropertyChanged;
  }

  private void PhaseMonitor_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
  {
    NotifyCanExecuteChanged();
  }

  private void NotifyCanExecuteChanged()
  {
    SaveResultsCommand.NotifyCanExecuteChanged();
    ShowResultsCommand.NotifyCanExecuteChanged();
    RefreshResultsCommand.NotifyCanExecuteChanged();
  }

  /// <summary>
  /// ID of the process phase.
  /// </summary>
  public PPS PhaseNum { get; private set; }

  /// <summary>
  /// Name of the process phase.
  /// </summary>
  public string PhaseName {get; set; }

  public string Caption => 
    CommonStrings.ResourceManager.GetString(PhaseName, CultureInfo.CurrentUICulture) ?? PhaseName;

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
  public SummaryViewModel Summary
  {
    get { return _Summary; }
    set
    {
      if (_Summary != value)
      {
        _Summary = value;
        NotifyPropertyChanged(nameof(Summary));
      }
    }
  }
  private SummaryViewModel _Summary = null!;

  public void SetSummary(SummaryInfo summary)
  {
    Summary = new SummaryViewModel();
    if (summary.Summary != null)
      foreach (var info in summary.Summary)
      {
        var infoName = info.Key.ToString();
        infoName = CommonStrings.ResourceManager.GetString(infoName, CultureInfo.CurrentUICulture) ?? infoName.DeCamelCase();
        Summary.Add(new SummaryValueViewModel { Name = infoName, InfoKind = info.Key, Value = info.Value });
      }
    Summary.PropertyChanged += Summary_PropertyChanged;
  }

  private void Summary_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
  {
    if (e.PropertyName == nameof(Summary.Filter))
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


  public NTS NamespaceTypeSelector { get; protected set; }

  public NKS NameKindSelector { get; protected set; }

  #region Namespaces
  public NamespacesViewModel Namespaces
  {
    get { return _Namespaces; }
    set
    {
      if (_Namespaces != value)
      {
        _Namespaces = value;
        NotifyPropertyChanged(nameof(Namespaces));
      }
    }
  }
  private NamespacesViewModel _Namespaces = null!;

  public async void FillNamespacesAsync()
  {
    await Task.Run(() => FillNamespaces());
  }

  public virtual void FillNamespaces()
  {
    Namespaces = new NamespacesViewModel(this, NamespaceTypeSelector, Filter);
    Namespaces.Populate();
  }

  public async void RefreshResultsAsync()
  {
    await Task.Run(() => RefreshResults());
  }

  public virtual void RefreshResults()
  {
    Namespaces?.Refresh();
  }
  #endregion

  #region Types
  public TypeListViewModel Types
  {
    get { return _Types; }
    set
    {
      if (_Types != value)
      {
        _Types = value;
        NotifyPropertyChanged(nameof(Types));
      }
    }
  }
  private TypeListViewModel _Types = null!;

  public virtual void GetTypes()
  {
    Types = new TypeListViewModel(this, null, "", NameKindSelector, TKS.Any);
  }
  #endregion

  #region SaveResultsCommand
  /// <summary>
  /// Command to show phase result window.
  /// </summary>
  public Command SaveResultsCommand
  {
    get { return _SaveResultsCommand; }
    set
    {
      if (_SaveResultsCommand != value)
      {
        _SaveResultsCommand = value;
        NotifyPropertyChanged(nameof(_SaveResultsCommand));
      }
    }
  }
  private Command _SaveResultsCommand = null!;

  protected virtual void SaveResultsExecute()
  {
    var filename = GetFilename();
    SaveData(filename);
    MessageBox.Show($"Data saved to \"{filename}\"");
  }

  protected virtual bool SaveResultsCanExecute()
  {
    return Percentage == 100;
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

  protected void ShowResultsExecute()
  {
    WindowsManager.ShowWindow<PhaseResultsWindow>(this);
    FillNamespacesAsync();
  }

  protected virtual bool ShowResultsCanExecute()
  {
    return true;//Percentage == 100;
  }
  #endregion

  #region RefreshResultsCommand
  /// <summary>
  /// Command to show phase result window.
  /// </summary>
  public Command RefreshResultsCommand
  {
    get { return _RefreshResultsCommand; }
    set
    {
      if (_RefreshResultsCommand != value)
      {
        _RefreshResultsCommand = value;
        NotifyPropertyChanged(nameof(_RefreshResultsCommand));
      }
    }
  }
  private Command _RefreshResultsCommand = null!;

  protected void RefreshResultsExecute()
  {
    RefreshResultsAsync();
  }

  protected virtual bool RefreshResultsCanExecute()
  {
    return true;//Percentage == 100;
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

  public void SetFilter(string? filter)
  {
    Filter = filter;
    FillNamespacesAsync();
  }
  #endregion

  public bool IsTargetNameVisible { get; protected set; }

  public bool IsInvalidMarkVisible { get; protected set; } = true;

  public bool CanShowErrorDetails { get; protected set; }

  #region SaveData
  public void SaveData(string filename)
  {
    TypeManager.SaveData(filename);
  }

  public string GetFilename()
  {
    var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    path = Path.Combine(path, "ModelGen");
    if (!Directory.Exists(path))
      Directory.CreateDirectory(path);
    path = Path.Combine(path, $"Phase {Convert.ChangeType(PhaseNum, typeof(int))} result.xml");
    return path;
  }
  #endregion

  public virtual void ShowErrorFor(TypeInfoViewModel typeInfoViewModel)
  {
    if (CanShowErrorDetails)
      WindowsManager.ShowWindow<TypeInfoWindow>(this);
  }

}
