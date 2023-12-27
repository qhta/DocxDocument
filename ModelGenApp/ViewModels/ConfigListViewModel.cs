namespace ModelGenApp.ViewModels;

/// <summary>
/// Abstract list of view model of model config data. Inherited classes specify some group of settings.
/// </summary>
public abstract class ConfigListViewModel : ViewModel
{
  public ConfigListViewModel(ModelConfigViewModel parent)
  {
    Parent = parent;
    StoreDataCommand = new RelayCommand(StoreData);
    RestoreDataCommand = new RelayCommand(RestoreData);
  }

  protected ModelConfigViewModel Parent { get; private set; }

  public virtual string Caption { get; protected set; } = CommonStrings.ModelConfiguration;

  /// <summary>
  /// Is progress bar visible. Should be true if data is loaded in backround.
  /// </summary>
  public bool ShowProgressBar
  {
   [DebuggerStepThrough] get { return _ShowProgressBar; }
    set
    {
      if (_ShowProgressBar != value)
      {
        _ShowProgressBar = value;
        NotifyPropertyChanged(nameof(ShowProgressBar));
      }
    }
  }
  private bool _ShowProgressBar;

  /// <summary>
  /// Maximum value of progress bar. Considered only when progress bar is visible.
  /// </summary>
  public int ProgressBarMaximum
  {
   [DebuggerStepThrough] get { return _ProgressBarMaximum; }
    set
    {
      if (_ProgressBarMaximum != value)
      {
        _ProgressBarMaximum = value;
        NotifyPropertyChanged(nameof(ProgressBarMaximum));
      }
    }
  }
  private int _ProgressBarMaximum;

  /// <summary>
  /// Actual value of progress bar. Considered only when progress bar is visible.
  /// </summary>
  public int ProgressBarValue
  {
   [DebuggerStepThrough] get { return _ProgressBarValue; }
    set
    {
      if (_ProgressBarValue != value)
      {
        _ProgressBarValue = value;
        NotifyPropertyChanged(nameof(ProgressBarValue));
      }
    }
  }
  private int _ProgressBarValue;

  /// <summary>
  /// Creates items basing on info loaded in parent view model and config data.
  /// </summary>
  public abstract void CreateItems(ModelConfigData configData);

  /// <summary>
  /// Refreshes items using config data.
  /// </summary>
  public void RefeshItems(ModelConfigData configData)
  {
    CreateItems(configData);
  }

  /// <summary>
  /// Stores data from items to config data
  /// and saves it.
  /// </summary>
  public virtual void SaveData(ModelConfigData configData)
  {
    SetData(configData);
    Parent.SaveData(configData);
  }

  /// <summary>
  /// Refreshes data in config items basing on view model items.
  /// </summary>
  /// <param name="configData"></param>
  public abstract void SetData(ModelConfigData configData);

  /// <summary>
  /// Validates config data. Used in <see cref="StoreData"/> method.
  /// </summary>
  /// <param name="configData"></param>
  /// <returns></returns>
  public abstract bool ValidateData();

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
    MessageBoxResult dlgResult = MessageBoxResult.Yes;
    if (!ValidateData())
      dlgResult = MessageBox.Show(CommonStrings.Model_configuration_is_invalid + " " + CommonStrings.SaveConfigurationAnyway, null, MessageBoxButton.YesNo);
    if (dlgResult == MessageBoxResult.Yes)
    {
      if (ModelConfig.Instance != null)
      {
        var filename = ModelConfig.Instance.GetFilename();
        if (!File.Exists(filename))
          File.Copy(filename, Path.ChangeExtension(filename, ".bak"));
        SaveData(ModelConfig.Instance);
        MessageBox.Show(String.Format(CommonStrings.Model_configuration_saved_in_0, filename));
      }
      else
        MessageBox.Show(String.Format(CommonStrings.Model_configuration_not_defined));
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
    return true;
  }

  /// <summary>
  /// Execute method of config data restore.
  /// </summary>
  public void RestoreData()
  {
    //if (ModelConfig.Instance != null)
    //  ReloadData(ModelConfig.Instance);
  }
  #endregion

}
