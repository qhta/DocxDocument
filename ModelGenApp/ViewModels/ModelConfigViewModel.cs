namespace ModelGenApp.ViewModels;

/// <summary>
/// View model of model config data. Used to edit this data in application.
/// </summary>
public class ModelConfigViewModel : ViewModel
{
  /// <summary>
  /// Default initializing constructor
  /// </summary>
  public ModelConfigViewModel()
  {
    StoreDataCommand = new RelayCommand(StoreData, CanStoreData) { Name = "StoreDataCommand" };
    RestoreDataCommand = new RelayCommand(RestoreData, CanRestoreData) { Name = "RestoreDataCommand" };

  }

  /// <summary>
  /// ViewModel of namespaces defined in the assembly.
  /// </summary>
  public NamespacesConfigViewModel Namespaces
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
  private NamespacesConfigViewModel _Namespaces = null!;

  /// <summary>
  /// Stores loaded assembly reference. Used in <see cref="ReloadData"/>
  /// </summary>
  private Assembly? _Assembly;

  /// <summary>
  /// Loads namespaces defined in the assembly.
  /// </summary>
  /// <param name="configData"></param>
  /// <param name="assembly"></param>
  public void GetData(ModelConfig configData, Assembly assembly)
  {
    _Assembly = assembly;
    Namespaces = new NamespacesConfigViewModel();
    Namespaces.GetData(configData, assembly);
  }

  /// <summary>
  /// Reload namespaces after config data reload.
  /// </summary>
  /// <param name="configData"></param>
  public void ReloadData(ModelConfig configData)
  {
    if (_Assembly != null)
    {
      configData.LoadData();
      var assembly = _Assembly;
      Namespaces = new NamespacesConfigViewModel();
      Namespaces.GetData(configData, assembly);
    }
  }

  /// <summary>
  /// Stores config data in the config file.
  /// </summary>
  /// <param name="configData"></param>
  public void SaveData(ModelConfig configData)
  {
    Namespaces.SetData(configData);
    configData.SaveData();
    ReloadData(configData);
  }

  /// <summary>
  /// Validates config data. Used in <see cref="StoreData"/> method.
  /// </summary>
  /// <param name="configData"></param>
  /// <returns></returns>
  public bool ValidateData(ModelConfig configData)
  {
    var ok = true;
    if (!Namespaces.ValidateData(configData))
      ok = false;
    return ok;
  }

  #region StoreDataCommand
  /// <summary>
  /// A command to store config data
  /// </summary>
  public Command StoreDataCommand { get; }

  /// <summary>
  /// Checks if config data can be stored (always true).
  /// </summary>
  /// <returns></returns>
  public bool CanStoreData()
  {
    return true;
  }

  /// <summary>
  /// Execute method of config data store.
  /// </summary>
  public void StoreData()
  {
    if (!ValidateData(ModelConfig.Instance))
      MessageBox.Show($"Model configuration is invalid. See marks in the table.");
    else
    {
      var filename = ModelConfig.Instance.GetFilename();
      if (!File.Exists(filename))
        File.Copy(filename, Path.ChangeExtension(filename, ".bak"));
      SaveData(ModelConfig.Instance);
      MessageBox.Show($"Model configuration saved in {filename}");
    }
  }
  #endregion

  #region RestoreDataCommand

  /// <summary>
  /// A command to restore config data.
  /// </summary>
  public Command RestoreDataCommand { get; }

  /// <summary>
  /// Checks if config data can be restored (true if it was loaded previously).
  /// </summary>
  /// <returns></returns>
  public bool CanRestoreData()
  {
    return _Assembly != null;
  }

  /// <summary>
  /// Execute method of config data restore.
  /// </summary>
  public void RestoreData()
  {
    ReloadData(ModelConfig.Instance);
    MessageBox.Show($"Model configuration restored from {ModelConfig.Instance.GetFilename()}");
  }
  #endregion

}
