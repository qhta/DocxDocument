﻿namespace ModelGenApp.ViewModels;

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
    NamespacesSelector = nameTypeSelector;
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

  private void PhaseMonitor_PropertyChanged(object? sender, PropertyChangedEventArgs e)
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
  public PPS PhaseNum { [DebuggerStepThrough] get; private set; }

  /// <summary>
  /// Name of the process phase.
  /// </summary>
  public string PhaseName { [DebuggerStepThrough] get; set; }

  public string Caption => CommonStrings.ResultsOfPhase +": "+
    CommonStrings.ResourceManager.GetString(PhaseName, CultureInfo.CurrentUICulture) ?? PhaseName;


  public bool ShowTargetsOnlyEnabled
  {
   [DebuggerStepThrough] get { return _ShowTargetsOnlyEnabled; }
    set
    {
      if (_ShowTargetsOnlyEnabled != value)
      {
        _ShowTargetsOnlyEnabled = value;
        NotifyPropertyChanged(nameof(ShowTargetsOnlyEnabled));
      }
    }
  }
  protected bool _ShowTargetsOnlyEnabled;

  /// <summary>
  /// Percent of the phase advantage.
  /// </summary>
  public int Percentage
  {
   [DebuggerStepThrough] get { return _Percentage; }
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
   [DebuggerStepThrough] get { return _Summary; }
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

  public virtual void SetSummary(SummaryInfo summary)
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

  public NTS NamespacesSelector { [DebuggerStepThrough] get; protected set; }

  public TNS TypeNameSelector => new TNS(NamespacesSelector, false, false);

  #region Namespaces
  public NamespacesViewModel Namespaces
  {
   [DebuggerStepThrough] get { return _Namespaces; }
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

  public async Task FillNamespacesAsync()
  {
    //Debug.WriteLine($"PhaseResultsViewModel.FillNamespacesAsync");
    await Task.Factory.StartNew(() => FillNamespaces());
  }

  public virtual void FillNamespaces()
  {
    //Debug.WriteLine($"PhaseResultsViewModel.FillNamespaces.Start");
    Namespaces = new NamespacesViewModel(this, Filter);
    //Debug.WriteLine($"PhaseResultsViewModel.FillNamespaces.End");
  }

  public async void FillTypesAsync()
  {
    await Task.Factory.StartNew(() => FillTypes());
  }

  public virtual void FillTypes()
  {
    Types = new TypeListViewModel(this, null, NamespacesSelector.ToString(), TypeNameSelector, TKS.Any, Filter);
    Types.FillItemsAsync();
  }

  public async void FillPropertiesAsync()
  {
    await Task.Factory.StartNew(() => FillProperties());
  }

  public virtual void FillProperties()
  {
    Properties = new PropListViewModel(this, null, NamespacesSelector.ToString(), TypeNameSelector);
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
    Types = new TypeListViewModel(this, null, NamespacesSelector.ToString(), TypeNameSelector, TKS.Any, Filter);
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
    Properties = new PropListViewModel(this, null, NamespacesSelector.ToString(), TypeNameSelector);
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
   [DebuggerStepThrough] get { return _SaveResultsCommand; }
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
   [DebuggerStepThrough] get { return _ShowResultsCommand; }
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

  protected virtual async void ShowResultsExecute()
  {
    WindowsManager.ShowWindow<PhaseResultsWindow>(this);
    await FillNamespacesAsync();
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
   [DebuggerStepThrough] get { return _RefreshResultsCommand; }
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

  protected virtual void RefreshResultsExecute()
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
   [DebuggerStepThrough] get { return _Filter; }
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

  public void SetFilter(SummaryInfoKind? filter)
  {
    if (filter != null)
      Filter = new TypeInfoViewModelFilter((SummaryInfoKind)filter, PhaseNum);
    else
      Filter = null;
    ApplyFilter();
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

  public bool IsTargetNameVisible { [DebuggerStepThrough] get; protected set; }

  public bool IsInvalidMarkVisible { [DebuggerStepThrough] get; protected set; } = true;

  public bool CanShowErrorDetails { [DebuggerStepThrough] get; protected set; }


  public bool ShowTargetsOnly
  {
   [DebuggerStepThrough] get { return _ShowTargetsOnly; }
    set
    {
      if (_ShowTargetsOnly != value)
      {
        //Debug.WriteLine($"PhaseResultsViewModel.ShowTargetsOnly.Set({value})");
        _ShowTargetsOnly = value;
        NotifyPropertyChanged(nameof(ShowTargetsOnly));
        if (Namespaces!=null)
          ReloadNamespacesAsync();
      }
    }
  }
  protected bool _ShowTargetsOnly;

  public async void ReloadNamespacesAsync()
  {
    //Debug.WriteLine($"ReloadNamespacesAsync");
    var task1 = FillNamespacesAsync();
    if (_Types==null)
      await task1;
    var task2 = task1.ContinueWith((t) => ReloadTypes());
    if (_Properties==null) 
      await task2;
    var task3 = task2.ContinueWith((t) => ReloadProperties());
    await task3;
  }

  public void ReloadTypes()
  {
    //Debug.WriteLine($"ReloadTypes");
    FillTypes();
  }

  public void ReloadProperties()
  {
    //Debug.WriteLine($"ReloadProperties");
    FillProperties();
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
