namespace ModelGenApp.ViewModels;
public class ModelConfigViewModel : ViewModel
{
  public ModelConfigViewModel()
  {
    StoreDataCommand = new RelayCommand(StoreData, CanStoreData) { Name = "StoreDataCommand" };
    RestoreDataCommand = new RelayCommand(RestoreData, CanRestoreData) { Name = "RestoreDataCommand" };

  }

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

  private Assembly? _Assembly;

  public void GetData(ModelConfig configData, Assembly assembly)
  {
    _Assembly = assembly;
    Namespaces = new NamespacesConfigViewModel();
    Namespaces.GetData(configData, assembly);
  }

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

  public void SaveData(ModelConfig configData)
  {
    Namespaces.SetData(configData);
    configData.SaveData();
    ReloadData(configData);
  }

  public bool ValidateData(ModelConfig configData)
  {
    var ok = true;
    if (!Namespaces.ValidateData(configData))
      ok = false;
    return ok;
  }

  #region StoreDataCommand
  public Command StoreDataCommand { get; }

  public bool CanStoreData()
  {
    return true;
  }

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
  public Command RestoreDataCommand { get; }

  public bool CanRestoreData()
  {
    return _Assembly != null;
  }

  public void RestoreData()
  {
    ReloadData(ModelConfig.Instance);
    MessageBox.Show($"Model configuration restored from {ModelConfig.Instance.GetFilename()}");
  }
  #endregion

}
