using Microsoft.Win32;

namespace ModelGenApp.ViewModels;
public partial class ProcessOptionsViewModel : ViewModel<ProcessOptions>
{

  public ProcessOptionsViewModel() : base(ProcessOptionsMgr.GetInstance())
  {
    _MainTypeNames = GetMainTypeNames();
    BrowseModelDocFileCommand = new RelayCommand(BrowseModelDoc) { Name = "BrowseModelDocFile" };
  }

  public int StopAtPhase
  {
    get { return Model.StopAtPhase; }
    set
    {
      if (Model.StopAtPhase != value)
      {
        Model.StopAtPhase = value;
        NotifyPropertyChanged(nameof(StopAtPhase));
      }
    }
  }

  public string ScanTypeName
  {
    get { return Model.ScanTypeName; }
    set
    {
      if (Model.ScanTypeName != value)
      {
        Model.ScanTypeName = value;
        NotifyPropertyChanged(nameof(ScanTypeName));
      }
    }
  }

  public bool UseModelDocFile
  {
    get { return Model.UseModelDocFile; }
    set
    {
      if (Model.UseModelDocFile != value)
      {
        Model.UseModelDocFile = value;
        NotifyPropertyChanged(nameof(UseModelDocFile));
      }
    }
  }

  public string ModelDocFileName
  {
    get { return Model.ModelDocFileName; }
    set
    {
      if (Model.ModelDocFileName != value)
      {
        Model.ModelDocFileName = value;
        NotifyPropertyChanged(nameof(ModelDocFileName));
      }
    }
  }

  public bool ValidateScan
  {
    get { return Model.ValidateScan; }
    set
    {
      if (Model.ValidateScan != value)
      {
        Model.ValidateScan = value;
        NotifyPropertyChanged(nameof(ValidateScan));
      }
    }
  }

  public bool ValidateDocs
  {
    get { return Model.ValidateDocs; }
    set
    {
      if (Model.ValidateDocs != value)
      {
        Model.ValidateDocs = value;
        NotifyPropertyChanged(nameof(ValidateDocs));
      }
    }
  }

  public ObservableCollection<string> MainTypeNames
  {
    get { return _MainTypeNames; }
    set
    {
      if (_MainTypeNames != value)
      {
        _MainTypeNames = value;
        NotifyPropertyChanged(nameof(MainTypeNames));
      }
    }
  }
  private ObservableCollection<string> _MainTypeNames;

  private ObservableCollection<string> GetMainTypeNames()
  {
    var assembly = Assembly.Load("DocumentFormat.OpenXml");
    var typeNames = assembly.GetTypes().Where(type => !type.IsCompilerGenerated() && !type.IsAbstract)
    .Select(type => type.FullName ?? "")
    .Where(name => name.StartsWith("DocumentFormat.OpenXml.Packaging")).ToList();
    typeNames.Sort();
    var sortedTypeNames = typeNames.Where(name => name.EndsWith("Document")).ToList();
    sortedTypeNames.AddRange(typeNames.Where(name => name.EndsWith("Part")).ToList());
    return new ObservableCollection<string>(sortedTypeNames);
  }

  #region BrowseModelDocFileCommand
  /// <summary>
  /// A command to store config data
  /// </summary>
  public Command BrowseModelDocFileCommand { get; }

  /// <summary>
  /// Execute method of config data store.
  /// </summary>
  public void BrowseModelDoc()
  {
    var dialog = new OpenFileDialog();
    dialog.Filter = "Xml file (*.xml)|*.xlm|All files (*.*)|*.*";
    dialog.InitialDirectory = Path.GetDirectoryName(ModelDocFileName);
    dialog.FileName = Path.GetFileName(ModelDocFileName);
    if (dialog.ShowDialog() == true)
    {
      ModelDocFileName = dialog.FileName.Trim();
    }
  }
  #endregion
}
