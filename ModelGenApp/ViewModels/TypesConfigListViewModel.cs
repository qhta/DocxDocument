namespace ModelGenApp.ViewModels;
public class TypesConfigListViewModel : ConfigListViewModel
{
  public TypesConfigListViewModel(ModelConfigViewModel owner) : base(owner)
  {
    Caption = CommonStrings.ModelConfiguration + ": " + CommonStrings.Types.ToLower();
    Items = new ListViewModel<TypeConfigViewModel>();
    CollectionViewSource = new CollectionViewSource<TypeConfigViewModel>(Items);
    VisibleItems = CollectionViewSource.GetDefaultView(Items);
    ExcludeTypesCommand = new RelayCommand<string>(ExcludeTypesExecute, ExcludeTypesCanExecute) { Name = "ExcludeTypesCommand" };
    IncludeTypesCommand = new RelayCommand<string>(IncludeTypesExecute, IncludeTypesCanExecute) { Name = "IncludeTypesCommand" };
  }

  public ListViewModel<TypeConfigViewModel> Items { [DebuggerStepThrough] get; private set; }

  private CollectionViewSource<TypeConfigViewModel> CollectionViewSource;

  /// <summary>
  /// This is the result collection view to be used in DataGrid.
  /// </summary>
  public ICollectionView VisibleItems { [DebuggerStepThrough] get; private set; }

  public void ClearItems()
  {
    Items.Clear();
    typesCount = 0;
  }

  int typesCount = 0; 

  public void CreateItems(NamespaceConfigViewModel parent, ModelConfigData configData)
  {
    var fullNameComparison = configData.AcceptedTypes.FirstOrDefault(item => item.Contains('.')) != null
                          || configData.RejectedTypes.FirstOrDefault(item => item.Contains('.')) != null;
    foreach (var type in parent.Types)
    {
      if (type != null)
      {
        var fullTypeName = (type.Namespace ?? "") + "." + type.Name;

        var item = new TypeConfigViewModel (parent, type);
        item.RecordNumber = ++typesCount;
        if (fullNameComparison)
        {
          if (configData.RejectedTypes.Contains(fullTypeName))
            item.IsExcluded = true;
          if (configData.AcceptedTypes.Contains(fullTypeName))
            item.IsIncluded = true;
        }
        else
        {
          if (configData.RejectedTypes.Contains(type.Name))
            item.IsExcluded = true;
          if (configData.AcceptedTypes.Contains(type.Name))
            item.IsIncluded = true;
        }
        if (configData.TypeConversion.TryGetValue(fullTypeName, out var conversion))
        {
          var k = conversion.LastIndexOf('.');
          if (k > 0 && k < conversion.Length - 1)
          {
            item.TargetNamespace = conversion.Substring(0, k);
            item.TargetName = conversion.Substring(k + 1);
          }
        }
        Items.Add(item);
      }
    }
  }

  public override void SetData(ModelConfigData configData)
  {
    configData.AcceptedTypes.Clear();
    configData.RejectedTypes.Clear();
    configData.TypeConversion.Clear();
    foreach (var item in Items)
    {
      var fullTypeName = item.OrigNamespace + "." + item.OrigName;
      if (item.IsIncluded && item.IsIncluded!=item.Parent.IsAccepted)
        configData.AcceptedTypes.Add(fullTypeName);
      if (item.IsExcluded && item.IsExcluded!=item.Parent.IsRejected)
        configData.RejectedTypes.Add(fullTypeName);
      if (item.TargetNamespace != null || item.TargetName != null)
      {
        var targetNamespace = item.TargetNamespace ?? item.OrigNamespace.Replace("DocumentFormat.OpenXml", "DocumentModel");
        var targetName = item.TargetName ?? item.OrigName;
        configData.TypeConversion.Add(fullTypeName, targetNamespace + "." + targetName);
      }
    }
  }

  public override bool ValidateData()
  {
    var ok = true;
    return ok;
  }

  #region ExcludeTypesCommand
  /// <summary>
  /// Command to show phase result window.
  /// </summary>
  public Command ExcludeTypesCommand { [DebuggerStepThrough] get; private set; }

  protected virtual void ExcludeTypesExecute(string? parameter)
  {
    if (parameter != null)
      foreach (var item in Items)
      {
        if (item.OrigName.IsLike(parameter))
          item.IsExcluded = true;
      }
  }

  protected virtual bool ExcludeTypesCanExecute(string? parameter)
  {
    return !String.IsNullOrEmpty(parameter);
  }
  #endregion

  #region IncludeTypesCommand
  /// <summary>
  /// Command to show phase result window.
  /// </summary>
  public Command IncludeTypesCommand { [DebuggerStepThrough] get; private set; }

  protected virtual void IncludeTypesExecute(string? parameter)
  {
    if (parameter != null)
      foreach (var item in Items)
      {
        if (item.OrigName.IsLike(parameter))
          item.IsIncluded = true;
      }
  }

  protected virtual bool IncludeTypesCanExecute(string? parameter)
  {
    return !String.IsNullOrEmpty(parameter);
  }
  #endregion


}
