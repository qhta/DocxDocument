using System.Collections.Immutable;

namespace ModelGenApp.ViewModels;

/// <summary>
/// Compound view model of model config data. Inherited classes specify some group of settings.
/// </summary>
public class ModelConfigViewModel : ViewModel
{
  /// <summary>
  /// Default initializing constructor
  /// </summary>
  public ModelConfigViewModel(string assemblyName, ModelConfigData configData)
  {
    AssemblyName = assemblyName;
    Assembly entryAssembly = Assembly.GetEntryAssembly()!;
    var entryAssemblyName = entryAssembly.GetName();
    var assemblyNames = new List<AssemblyName>();//entryAssembly.GetReferencedAssemblies().OrderBy(item => item.FullName).ToList();
    string binFolder = Path.GetDirectoryName(entryAssembly.Location)!;
    var dllFiles = Directory.EnumerateFiles(binFolder, "*.dll");
    foreach (var dllFile in dllFiles)
    {
      if (!Path.GetFileName(dllFile).StartsWith("ModelGen"))
      {
        var asm = Assembly.LoadFile(dllFile);
        var asmName = asm!.GetName();
        if (asmName.Name != entryAssemblyName.Name)
        {
          if (asmName != null && !assemblyNames.Any(item => item.Name == asmName.Name))
          {
            assemblyNames.Add(asmName);
          }
        }
      }
    }
    ReferencedAssemblyNames = assemblyNames.OrderBy(item => item.FullName).ToList();
    LoadedAssemblies = LoadAssemblies(assemblyName);
    LoadedTypes = GetTypes(LoadedAssemblies);
    LoadedNamespaces = GetNamespaces(LoadedTypes);
    LoadedProperties = GetProperties(LoadedTypes);
    ConfigData = configData;
    LibrariesConfigList = new LibrariesConfigListViewModel(this);
    NamespacesConfigList = new NamespacesConfigListViewModel(this);
    TypesConfigList = new TypesConfigListViewModel(this);
    PropertiesConfigList = new PropertiesConfigListViewModel(this);
    //StoreDataCommand = new RelayCommand(StoreData, CanStoreData) { Name = "StoreDataCommand" };
    //RestoreDataCommand = new RelayCommand(RestoreData, CanRestoreData) { Name = "RestoreDataCommand" };
    CreateViewModelItemsAsync(configData);
  }

  /// <summary>
  /// Stores loaded assemblies.
  /// </summary>
  public IEnumerable<AssemblyName> ReferencedAssemblyNames { [DebuggerStepThrough] get; private set; }

  /// <summary>
  /// Stores loaded assembly name. 
  /// </summary>
  public string AssemblyName { [DebuggerStepThrough] get; private set; }
  /// <summary>
  /// Stores loaded assemblies.
  /// </summary>
  public IEnumerable<Assembly> LoadedAssemblies { [DebuggerStepThrough] get; private set; }

  /// <summary>
  /// Load main assembly and its references assemblies.
  /// </summary>
  private IEnumerable<Assembly> LoadAssemblies(string assemblyName)
  {
    var loadedAssemblies = new List<Assembly>();
    var mainAssembly = Assembly.Load(AssemblyName);
    loadedAssemblies.Add(mainAssembly);
    foreach (var asm in mainAssembly.GetReferencedAssemblies())
    {
      try
      {
        var refAssembly = Assembly.Load(asm);
        loadedAssemblies.Add(refAssembly);
      }
      catch (Exception ex)
      {
        Debug.WriteLine(ex.Message + $" in assembly {asm}");
      }
    }
    return loadedAssemblies;
  }

  /// <summary>
  /// List of all types exported by loaded assemblies.
  /// </summary>
  public IEnumerable<Type> LoadedTypes { [DebuggerStepThrough] get; private set; }

  /// <summary>
  /// Gets types from loaded assemblies to the list of loaded types.
  /// Compiler-generated types are not loaded.
  /// </summary>
  private IEnumerable<Type> GetTypes(IEnumerable<Assembly> loadedAssemblies)
  {
    var loadedTypes = new List<Type>();
    foreach (var assembly in loadedAssemblies)
    {
      var types = assembly.GetExportedTypes().Where(type => !type.IsCompilerGenerated());
      loadedTypes.AddRange(types);
    }
    return loadedTypes;
  }

  /// <summary>
  /// List of all namespaces in loaded assemblies.
  /// </summary>
  public IEnumerable<string> LoadedNamespaces { [DebuggerStepThrough] get; private set; }

  /// <summary>
  /// Loads unique namespaces from loaded types to the list of loaded namespaces.
  /// </summary>
  private IEnumerable<string> GetNamespaces(IEnumerable<Type> loadedTypes)
  {
    var loadedNamespaces = new List<string>();
    foreach (var type in loadedTypes)
    {
      var ns = type.Namespace!;
      if (!loadedNamespaces.Contains(ns))
        loadedNamespaces.Add(ns);
    }
    return loadedNamespaces;
  }

  /// <summary>
  /// List of all public properties of loaded types.
  /// </summary>
  public IEnumerable<PropertyInfo> LoadedProperties { [DebuggerStepThrough] get; private set; }

  /// <summary>
  /// Gets property infos from loaded types to the list of loaded properties.
  /// </summary>
  private IEnumerable<PropertyInfo> GetProperties(IEnumerable<Type> loadedTypes)
  {
    var loadedProperties = new List<PropertyInfo>();
    foreach (var type in loadedTypes)
    {
      var properties = type.GetProperties();
      loadedProperties.AddRange(properties);
    }
    return loadedProperties;
  }

  public ModelConfigData ConfigData { [DebuggerStepThrough] get; set; }

  public LibrariesConfigListViewModel LibrariesConfigList { [DebuggerStepThrough] get; private set; }

  public NamespacesConfigListViewModel NamespacesConfigList { [DebuggerStepThrough] get; private set; }

  public TypesConfigListViewModel TypesConfigList { [DebuggerStepThrough] get; private set; }

  public PropertiesConfigListViewModel PropertiesConfigList { [DebuggerStepThrough] get; private set; }

  /// <summary>
  /// Asynchronously Loads data defined in the assembly.
  /// </summary>
  public async void CreateViewModelItemsAsync(ModelConfigData configData)
  {
    await Task.Run(() => CreateViewModelItems(configData));
  }

  /// <summary>
  /// Create view model items basing on current config data.
  /// </summary>
  /// <param name="configData"></param>
  public void CreateViewModelItems(ModelConfigData configData)
  {
    LibrariesConfigList.ClearItems();
    LibrariesConfigList.CreateItems(configData);
    NamespacesConfigList.ClearItems();
    NamespacesConfigList.CreateItems(configData);
    TypesConfigList.ClearItems();
    foreach (var nsVM in NamespacesConfigList.Items)
    {
      TypesConfigList.CreateItems(nsVM, configData);
    }
    PropertiesConfigList.ClearItems();
    foreach (var typeVM in TypesConfigList.Items)
      PropertiesConfigList.CreateItems(typeVM, configData);
  }

  /// <summary>
  /// Stores config data in the config file.
  /// </summary>
  public void SaveData(ModelConfigData configData)
  {
    configData.SaveData();
  }

  //#region RestoreDataCommand

  ///// <summary>
  ///// A command to restore config data.
  ///// </summary>
  //public Command RestoreDataCommand { [DebuggerStepThrough] get; }

  ///// <summary>
  ///// Checks if config data can be restored (true if it was loaded previously).
  ///// </summary>
  ///// <returns></returns>
  //public bool CanRestoreData()
  //{
  //  return MainAssembly != null;
  //}

  ///// <summary>
  ///// Execute method of config data restore.
  ///// </summary>
  //public void RestoreData()
  //{
  //  if (ConfigData != null)
  //    ReloadData();
  //}
  //#endregion

}
