using Microsoft.Win32;

using WPFFolderBrowser;

namespace DocxEd.ViewModels;
public partial class ProcessOptionsViewModel : ViewModel<ProcessOptions>
{

  public ProcessOptionsViewModel() : base(ProcessOptionsMgr.CurrentInstance)
  {
    SaveOptionsCommand = new RelayCommand(SaveOptions) { Name = nameof(SaveOptions) };
    RestoreOptionsCommand = new RelayCommand(RestoreOptions) { Name = nameof(RestoreOptions) };
    BrowseModelDocFileCommand = new RelayCommand(BrowseModelDocFile) { Name = nameof(BrowseModelDocFile) };
    BrowseCodeOutputPathCommand = new RelayCommand(BrowseCodeOutputPath) { Name = nameof(BrowseCodeOutputPath) };
    AddAppDataFolderCommand = new RelayCommand(AddAppDataFolder) { Name = nameof(AddAppDataFolder) };
  }

  #region Observable properties

  /// <summary>
  /// Specifies the names of available app data folders.
  /// </summary>
  public string[] AppDataFolders
  {
    get
    {
      var appDataBase = ModelConfig.GetAppDataBase();
      var dirs = Directory.EnumerateDirectories(appDataBase);
      return dirs.Select(item => Path.GetFileName(item)).ToArray();
    }
  }

  /// <summary>
  /// Specifies the name of the subfolder of user's AppData containing config files for input and produced log files.
  /// </summary>
  public string? AppDataFolder
  {
    [DebuggerStepThrough]
    get { return Model.AppDataFolder; }
    set
    {
      if (Model.AppDataFolder != value)
      {
        ProcessOptionsMgr.DataFolder = value;
        Model.AppDataFolder = value;
        RestoreOptions();
        NotifyPropertyChanged(nameof(AppDataFolder));
      }
    }
  }

  /// <summary>
  /// Specifies the name of input assembly to parse.
  /// </summary>
  /// 
  public string? InputAssembly
  {
    [DebuggerStepThrough]
    get { return Model.InputAssembly; }
    set
    {
      if (Model.InputAssembly != value)
      {
        Model.InputAssembly = value;
        NotifyPropertyChanged(nameof(InputAssembly));
      }
    }
  }

  /// <summary>
  /// Specifies the name of the generator class.
  /// </summary>
  /// 
  public string? GeneratorType
  {
    [DebuggerStepThrough]
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
  /// Specifies a path for the generated code.
  /// </summary>
  public string? CodeOutputPath
  {
    [DebuggerStepThrough]
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
    [DebuggerStepThrough]
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
    [DebuggerStepThrough]
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
    [DebuggerStepThrough]
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
    [DebuggerStepThrough]
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
    [DebuggerStepThrough]
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
    [DebuggerStepThrough]
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
    [DebuggerStepThrough]
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
    [DebuggerStepThrough]
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
    [DebuggerStepThrough]
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
    [DebuggerStepThrough]
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
    [DebuggerStepThrough]
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
    [DebuggerStepThrough]
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
    [DebuggerStepThrough]
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
  private ObservableCollection<string> _MainTypeNames = new ObservableCollection<string>();

  private ObservableCollection<string> GetMainTypeNames(string assemblyName)
  {
    var typeNames = GetMainTypes(assemblyName);
    //var sortedTypeNames = typeNames.Where(name => name.Contains("Document")).ToList();
    //sortedTypeNames.AddRange(typeNames.Where(name => name.Contains("Spreadsheet")).ToList());
    //sortedTypeNames.AddRange(typeNames.Where(name => name.Contains("Part")).ToList());
    return new ObservableCollection<string>(typeNames.Select(item=>item.FullName!).OrderBy(item=>item));
  }

  public static string[] GetAvailableAssemblies()
  {
    List<Assembly> availableAssemblies = new List<Assembly>();
    availableAssemblies.Add(Assembly.Load("DocumentFormat.OpenXml"));
    availableAssemblies.Add(Assembly.Load("Microsoft.Office.Interop.Word"));
    return availableAssemblies.Select(item=>item.FullName!)
      .OrderBy(item=>item).ToArray();
  }

  public static Type[] GetMainTypes(string assemblyName)
  {
    var assembly = Assembly.Load(assemblyName);
    var typeNames = assembly.GetTypes()
      .Where(type => !type.IsCompilerGenerated() && !type.IsAbstract)
    //.Where(name => name.StartsWith("DocumentFormat.OpenXml.Packaging"))
    .ToList();
    //var sortedTypeNames = typeNames.Where(name => name.Contains("Document")).ToList();
    //sortedTypeNames.AddRange(typeNames.Where(name => name.Contains("Spreadsheet")).ToList());
    //sortedTypeNames.AddRange(typeNames.Where(name => name.Contains("Part")).ToList());
    return typeNames.ToArray();
  }

  #region SaveOptionsCommand
  /// <summary>
  /// A command to store config data
  /// </summary>
  public Command SaveOptionsCommand { [DebuggerStepThrough] get; }

  /// <summary>
  /// Execute method to store config data.
  /// </summary>
  public void SaveOptions()
  {
    if (AppDataFolder != null)
    {
      ProcessOptionsMgr.SaveInstance(this.Model);
      ProcessOptionsMgr.SaveInstanceName(AppDataFolder);
    }
  }
  #endregion

  #region RestoreOptionsCommand
  /// <summary>
  /// A command to restore config data
  /// </summary>
  public Command RestoreOptionsCommand { [DebuggerStepThrough] get; }

  /// <summary>
  /// Execute method to restore config data.
  /// </summary>
  public void RestoreOptions()
  {
    var oldData = ProcessOptionsMgr.LoadInstance(AppDataFolder);
    this.Model = oldData;
    if (InputAssembly != null)
      MainTypeNames = GetMainTypeNames(InputAssembly);
    foreach (var propInfo in typeof(ProcessOptionsViewModel).GetProperties())
      NotifyPropertyChanged(propInfo.Name);

  }
  #endregion

  #region BrowseModelDocFileCommand
  /// <summary>
  /// A command to browse model doc file.
  /// </summary>
  public Command BrowseModelDocFileCommand { [DebuggerStepThrough] get; }

  /// <summary>
  /// Execute method to browse model doc file.
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
  /// A command to browse code output path.
  /// </summary>
  public Command BrowseCodeOutputPathCommand { [DebuggerStepThrough] get; }

  /// <summary>
  /// Execute method to browse code output path.
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

  #region AddAppDataFolderCommand
  /// <summary>
  /// A command to create app data folder.
  /// </summary>
  public Command AddAppDataFolderCommand { [DebuggerStepThrough] get; }

  /// <summary>
  /// Execute method to create app data folder.
  /// </summary>
  public void AddAppDataFolder()
  {
    var dialog = new AddAppDataFolderDialog();
    var viewModel = new AddAppDataFolderViewModel { ExistingFolders = this.AppDataFolders, FolderToCopy = this.AppDataFolder };
    dialog.DataContext = viewModel;
    if (dialog.ShowDialog() == true && viewModel.NewFolderName != null)
    {
      var newFolderName = viewModel.NewFolderName.Trim();
      if (AppDataFolders.Contains(newFolderName))
      {
        MessageBox.Show(String.Format(CommonStrings.AppDataFolderAlreadyExists_1, newFolderName));
      }
      else
      if (!String.IsNullOrEmpty(newFolderName))
      {
        var appDataBase = ModelConfig.GetAppDataBase();
        var newFolderPath = Path.Combine(appDataBase, newFolderName);
        Directory.CreateDirectory(newFolderPath);
        if (viewModel.CopyContent && !String.IsNullOrEmpty(viewModel.FolderToCopy))
        {
          var folderToCopy = Path.Combine(appDataBase, viewModel.FolderToCopy);
          foreach (var file in Directory.GetFiles(folderToCopy))
          {
            try
            {
              var sourceFile = file;
              var targetFile = Path.Combine(newFolderPath, Path.GetFileName(file));
              File.Copy(sourceFile, targetFile);
            }
            catch { }
          }
          AppDataFolder = newFolderName;
        }
      }
    }
    //var appDataBase = ModelConfig.GetAppDataBase();
    //var appDataPath = appDataBase;
    //appDataPath = Path.Combine(appDataPath, AppDataFolder ?? "");
    //var dialog = new WPFFolderBrowserDialog();
    //while (!String.IsNullOrEmpty(appDataPath) && !Directory.Exists(appDataPath))
    //  appDataPath = Path.GetDirectoryName(appDataPath);
    //if (!String.IsNullOrEmpty(appDataPath))
    //  dialog.InitialDirectory = appDataPath;
    //if (dialog.ShowDialog() == true)
    //{
    //  var filename = dialog.FileName.Trim();
    //  appDataPath = filename;
    //  appDataPath = appDataPath.ReplaceStart(appDataBase, "").ReplaceStart("\\", "");
    //  AppDataFolder = appDataPath;
    //}
  }
  #endregion

  #region AvailableAssemblies selection
  public string[] AvailableAssemblies => GetAvailableAssemblies();
  #endregion

  #region GeneratorType selection
  public string[] GeneratorTypeNames => ProcessOptionsMgr.GetGeneratorTypes().Select(item => item.Name).ToArray();
  #endregion
}
