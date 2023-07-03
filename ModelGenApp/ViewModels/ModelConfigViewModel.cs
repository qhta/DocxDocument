namespace ModelGenApp.ViewModels;
public class ModelConfigViewModel: ViewModel
{
  public ModelConfigViewModel()
  {
    StoreDataCommand = new RelayCommand(StoreData, CanStoreData){ Name = "StoreDataCommand" };
    RestoreDataCommand = new RelayCommand(RestoreData, CanRestoreData){ Name = "RestoreDataCommand" };

  }

  public NamespacesConfigViewModel? Namespaces
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
  private NamespacesConfigViewModel? _Namespaces;

  private Assembly? _Assembly;

  public void GetData(ModelConfig configData, Assembly assembly)
  {
    _Assembly = assembly;
    Namespaces = new NamespacesConfigViewModel();
    Namespaces.GetData(configData, assembly);
  }

  public void ReloadData(ModelConfig configData)
  {
    if (_Assembly!=null)
    {
      configData.LoadData();
      var assembly = _Assembly;
      Namespaces = new NamespacesConfigViewModel();
      Namespaces.GetData(configData, assembly);
    }
  }

  public void SaveData(ModelConfig configData)
  {
    Namespaces?.SetData(configData);
    configData.SaveData();
  }

  #region StoreDataCommand
  public Command StoreDataCommand { get; }
  
  public bool CanStoreData()
  {
    return true;
  }

  public async void StoreData()
  {
    await Task.Run(()=>SaveData(ModelConfig.Instance));
    MessageBox.Show($"Model configuration saved in {ModelConfig.Instance.GetFilename()}");
  }
  #endregion

  #region RestoreDataCommand
  public Command RestoreDataCommand { get; }

  public bool CanRestoreData()
  {
    return _Assembly!=null;
  }

  public async void RestoreData()
  {
    await Task.Run(()=>ReloadData(ModelConfig.Instance));
    MessageBox.Show($"Model configuration restored from {ModelConfig.Instance.GetFilename()}");
  }
  #endregion

}
