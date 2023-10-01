namespace ModelGenApp.ViewModels;

/// <summary>
/// Observable monitor for a single process phase
/// </summary>
public abstract partial class PhaseResultsViewModel : ViewModel
{

  /// <summary>
  /// Initializing constructor. Needs a phase enum and name.
  /// </summary>
  /// <param name="phase"></param>
  /// <param name="name"></param>
  public PhaseResultsViewModel(PPS phase, string name, NTS nameTypeSelector)
  {
    PhaseNum = phase;
    PhaseName = name;
    NamespaceTypeSelector = nameTypeSelector;
    TypeNameSelector = new TNS(nameTypeSelector.HasFlag(NTS.Target), false, false);
    SaveResultsCommand = new RelayCommand(SaveResultsExecute, SaveResultsCanExecute) { Name = "SaveResultsCommand" };
    ShowResultsCommand = new RelayCommand(ShowResultsExecute, ShowResultsCanExecute) { Name = "ShowResultsCommand" };
    RefreshResultsCommand = new RelayCommand(RefreshResultsExecute, RefreshResultsCanExecute) { Name = "RefreshResultsCommand" };
    PropertyChanged += PhaseMonitor_PropertyChanged;
    BusyMonitor.Instance.PropertyChanged += BusyMonitor_PropertyChanged;
  }

  public void Clear()
  {
    Percentage = 0;
    BusyMonitor.Instance.IsBusy = false;
  }

  public bool IsBusy => BusyMonitor.Instance.IsBusy;

  private void BusyMonitor_PropertyChanged(object? sender, PropertyChangedEventArgs args)
  {
    if (args.PropertyName == nameof(BusyMonitor.IsBusy))
      NotifyPropertyChanged(nameof(IsBusy));
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
  public string PhaseName { get; set; }

  public string Caption =>
    CommonStrings.ResourceManager.GetString(PhaseName, CultureInfo.CurrentUICulture) ?? PhaseName;


  public bool ShowTargetsOnlyEnabled
  {
    get { return _ShowTargetsOnlyEnabled; }
    set
    {
      if (_ShowTargetsOnlyEnabled != value)
      {
        _ShowTargetsOnlyEnabled = value;
        NotifyPropertyChanged(nameof(ShowTargetsOnlyEnabled));
      }
    }
  }
  private bool _ShowTargetsOnlyEnabled;

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
  public PhaseSummaryViewModel Summary
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
  private PhaseSummaryViewModel _Summary = null!;

  public void SetSummary(SummaryInfo summary)
  {
    Summary = new PhaseSummaryViewModel();
    if (summary.Summary != null)
      foreach (var info in summary.Summary)
      {
        var infoName = info.Key.ToString();
        infoName = CommonStrings.ResourceManager.GetString(infoName, CultureInfo.CurrentUICulture) ?? infoName.DeCamelCase();
        Summary.Add(new PhaseSummaryInfoViewModel
        {
          Name = infoName,
          InfoKind = info.Key,
          Value = info.Value,
          FilterEnabled = TypeInfoViewModelFilter.CanFilter(info.Key)
        });
      }
    Summary.PropertyChanged += Summary_PropertyChanged;
  }

  private void Summary_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
  {
    if (e.PropertyName == nameof(Summary.Filter))
    {
      var summary = sender as PhaseSummaryViewModel;
      if (summary != null)
      {
        var filter = summary.Filter;
        SetFilter(filter);
      }
    }
  }
  #endregion


  public NTS NamespaceTypeSelector { get; protected set; }

  public TNS TypeNameSelector { get; protected set; }

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
    await Task.Factory.StartNew(() => FillNamespaces());
  }

  public virtual void FillNamespaces()
  {
    Namespaces = new NamespacesViewModel(this, Filter);
  }

  public async void FillTypesAsync()
  {
    await Task.Factory.StartNew(() => FillTypes());
  }

  public virtual void FillTypes()
  {
    Types = new TypeListViewModel(this, null, NamespaceTypeSelector.ToString(), TypeNameSelector, TKS.Any, Filter);
    Types.FillItemsAsync();
  }

  public async void FillPropertiesAsync()
  {
    await Task.Factory.StartNew(() => FillProperties());
  }

  public virtual void FillProperties()
  {
    Properties = new PropListViewModel(this, null, NamespaceTypeSelector.ToString(), TypeNameSelector);
    Properties.FillItemsAsync();
  }

  public async void FillResultsAsync()
  {
    await Task.Factory.StartNew(() => FillResults());
  }

  public virtual void FillResults()
  {
    if (_Namespaces != null)
      FillNamespaces();
    if (_Types != null)
      FillTypes();
    if (_Properties != null)
      FillProperties();
  }

  public async void RefreshResultsAsync()
  {
    await Task.Factory.StartNew(() => RefreshResults());
  }

  public virtual void RefreshResults()
  {
    Namespaces?.RefreshItems();
    Types?.RefreshItems();
    Properties?.RefreshItems();
  }
  #endregion

  #region Types

  public void InitTypes()
  {
    Types = new TypeListViewModel(this, null, NamespaceTypeSelector.ToString(), TypeNameSelector, TKS.Any, Filter);
    Types.FillItemsAsync();
  }

  public TypeListViewModel Types
  {
    get
    {
      return _Types;
    }
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

  #endregion

  #region Properties

  public void InitProperties()
  {
    Properties = new PropListViewModel(this, null, NamespaceTypeSelector.ToString(), TypeNameSelector);
    Properties.FillItemsAsync();
  }

  public PropListViewModel Properties
  {
    get
    {
      return _Properties;
    }
    set
    {
      if (_Properties != value)
      {
        _Properties = value;
        NotifyPropertyChanged(nameof(Properties));
      }
    }
  }
  private PropListViewModel _Properties = null!;

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
    return Percentage == 100;
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

  public TypeInfoViewModelFilter? Filter
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
  private TypeInfoViewModelFilter? _Filter;

  public void SetFilter(TypeInfoKind? filter)
  {
    if (filter == TypeInfoKind.TargetTypes)
    {
      ShowTargetsOnly = true;
    }
    else
    {
      ShowTargetsOnly = false;
      if (filter != null)
        Filter = new TypeInfoViewModelFilter((TypeInfoKind)filter, PhaseNum);
      else
        Filter = null;
      ApplyFilter();
    }
  }

  public void ApplyFilter()
  {
    if (_Namespaces != null)
      _Namespaces.Filter = Filter;
    if (_Types != null)
      FillTypes();
    if (_Properties != null)
      FillProperties();
  }
  #endregion

  public bool IsTargetNameVisible { get; protected set; }

  public bool IsInvalidMarkVisible { get; protected set; } = true;

  public bool CanShowErrorDetails { get; protected set; }


  public bool ShowTargetsOnly
  {
    get { return _ShowTargetsOnly; }
    set
    {
      if (_ShowTargetsOnly != value)
      {
        _ShowTargetsOnly = value;
        NotifyPropertyChanged(nameof(ShowTargetsOnly));
        ReloadNamespaces();
      }
    }
  }
  private bool _ShowTargetsOnly;

  public void ReloadNamespaces()
  {
    if (ShowTargetsOnly)
      NamespaceTypeSelector = NTS.Target;
    else
      NamespaceTypeSelector = NTS.Origin;
    FillNamespaces();
  }

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
