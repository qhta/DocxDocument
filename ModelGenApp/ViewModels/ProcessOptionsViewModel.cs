using Microsoft.Win32;

using WPFFolderBrowser;

namespace ModelGenApp.ViewModels;
public partial class ProcessOptionsViewModel : ViewModel<ProcessOptions>
{

  public ProcessOptionsViewModel() : base(ProcessOptionsMgr.GetInstance())
  {
    _MainTypeNames = GetMainTypeNames();
    BrowseModelDocFileCommand = new RelayCommand(BrowseModelDocFile) { Name = nameof(BrowseModelDocFile) };
    BrowseCodeOutputPathCommand = new RelayCommand(BrowseCodeOutputPath) { Name = nameof(BrowseCodeOutputPath) };
    BrowseAppDataFolderCommand = new RelayCommand(BrowseAppDataFolder) { Name = nameof(BrowseAppDataFolder) };
  }

  #region Observable properties
  /// <summary>
  /// Specifies the name of the generator class.
  /// </summary>
  /// 

  public string? GeneratorType
  {
    get { return Model.GeneratorType; }
    set
    {
      if (Model.GeneratorType != value)
      {
        Model.GeneratorType = value;
        NotifyPropertyChanged(nameof(GeneratorType));
      }
    }
  }

  /// <summary>
  /// Specifies the name of the subfolder of user's AppData containing config files for input and produced log files .
  /// </summary>
  public string? AppDataFolder
  {
    get { return Model.AppDataFolder; }
    set
    {
      if (Model.AppDataFolder != value)
      {
        Model.AppDataFolder = value;
        NotifyPropertyChanged(nameof(AppDataFolder));
      }
    }
  }

  /// <summary>
  /// Specifies a path for the generated code.
  /// </summary>
  public string? CodeOutputPath
  {
    get { return Model.CodeOutputPath; }
    set
    {
      if (Model.CodeOutputPath != value)
      {
        Model.CodeOutputPath = value;
        NotifyPropertyChanged(nameof(CodeOutputPath));
      }
    }
  }

  /// <summary>
  /// Specifies the name of the generated C# project.
  /// </summary>

  public string? ProjectName
  {
    get { return Model.ProjectName; }
    set
    {
      if (Model.ProjectName != value)
      {
        Model.ProjectName = value;
        NotifyPropertyChanged(nameof(ProjectName));
      }
    }
  }

  /// <summary>
  /// Specifies the name of the generated C# solution.
  /// </summary>
  public string? SolutionName
  {
    get { return Model.SolutionName; }
    set
    {
      if (Model.SolutionName != value)
      {
        Model.SolutionName = value;
        NotifyPropertyChanged(nameof(SolutionName));
      }
    }
  }

  /// <summary>
  /// Specifies the name of the generated C# namespace root.
  /// </summary>
  public string? RootNamespace
  {
    get { return Model.RootNamespace; }
    set
    {
      if (Model.RootNamespace != value)
      {
        Model.RootNamespace = value;
        NotifyPropertyChanged(nameof(RootNamespace));
      }
    }
  }

  /// <summary>
  /// Specifies the name of type used as a root for scan types phase.
  /// </summary>
  public string? ScanTypeName
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

  /// <summary>
  /// Specifies a name of model doc file. It must contain XML-serialized ModelDoc.
  /// </summary>
  public string? ModelDocFileName
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


  /// <summary>
  /// Specifies how many phases of process to run.
  /// </summary>
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

  /// <summary>
  /// Specifies whether results of the scan source phase should be validated.
  /// </summary>
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

  /// <summary>
  /// Specifies whether results of the add docs phase should be validated.
  /// </summary>
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

  /// <summary>
  /// Specifies whether results of the rename phase should be validated.
  /// </summary>
  public bool ValidateNames
  {
    get { return Model.ValidateNames; }
    set
    {
      if (Model.ValidateNames != value)
      {
        Model.ValidateNames = value;
        NotifyPropertyChanged(nameof(ValidateNames));
      }
    }
  }

  /// <summary>
  /// Specifies whether results of the conversion phase should be validated.
  /// </summary>
  public bool ValidateConversion
  {
    get { return Model.ValidateConversion; }
    set
    {
      if (Model.ValidateConversion != value)
      {
        Model.ValidateConversion = value;
        NotifyPropertyChanged(nameof(ValidateConversion));
      }
    }
  }

  /// <summary>
  /// Specifies whether results of the fixage phase should be validated.
  /// </summary>
  public bool ValidateFix
  {
    get { return Model.ValidateFix; }
    set
    {
      if (Model.ValidateFix != value)
      {
        Model.ValidateFix = value;
        NotifyPropertyChanged(nameof(ValidateFix));
      }
    }
  }

  /// <summary>
  /// Specifies whether results of the code generation phase should be validated.
  /// </summary>
  public bool ValidateGeneration
  {
    get { return Model.ValidateGeneration; }
    set
    {
      if (Model.ValidateGeneration != value)
      {
        Model.ValidateGeneration = value;
        NotifyPropertyChanged(nameof(ValidateGeneration));
      }
    }
  }
  #endregion

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
  public void BrowseModelDocFile()
  {
    var dialog = new OpenFileDialog();
    dialog.Filter = "Xml file (*.xml)|*.xml|All files (*.*)|*.*";
    dialog.InitialDirectory = Path.GetDirectoryName(ModelDocFileName);
    dialog.FileName = Path.GetFileName(ModelDocFileName);
    if (dialog.ShowDialog() == true)
    {
      ModelDocFileName = dialog.FileName?.Trim();
    }
  }
  #endregion

  #region BrowseCodeOutputPathCommand
  /// <summary>
  /// A command to store config data
  /// </summary>
  public Command BrowseCodeOutputPathCommand { get; }

  /// <summary>
  /// Execute method of config data store.
  /// </summary>
  public void BrowseCodeOutputPath()
  {
    var dialog = new WPFFolderBrowserDialog();
    if (Directory.Exists(CodeOutputPath))
      dialog.InitialDirectory = CodeOutputPath;
    else
      dialog.InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    if (dialog.ShowDialog() == true)
    {
      var filename = dialog.FileName.Trim();
      CodeOutputPath = filename;
    }
  }
  #endregion

  #region BrowseAppDataFolderCommand
  /// <summary>
  /// A command to store config data
  /// </summary>
  public Command BrowseAppDataFolderCommand { get; }

  /// <summary>
  /// Execute method of config data store.
  /// </summary>
  public void BrowseAppDataFolder()
  {
    var appDataBase =  ModelConfig.GetAppDataBase();
    var appDataPath = appDataBase;
    appDataPath = Path.Combine(appDataPath, AppDataFolder ?? "");
    var dialog = new WPFFolderBrowserDialog();
    while (!String.IsNullOrEmpty(appDataPath) && !Directory.Exists(appDataPath))
      appDataPath = Path.GetDirectoryName(appDataPath);
    if (!String.IsNullOrEmpty(appDataPath))
      dialog.InitialDirectory = appDataPath;
    if (dialog.ShowDialog() == true)
    {
      var filename = dialog.FileName.Trim();
      appDataPath = filename;
      appDataPath = appDataPath.ReplaceStart(appDataBase,"").ReplaceStart("\\","");
      AppDataFolder = appDataPath;
    }
  }
  #endregion
}
