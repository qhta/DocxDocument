namespace ModelGenApp.ViewModels;
public class PropertiesConfigListViewModel : ConfigListViewModel
{
  public PropertiesConfigListViewModel(ModelConfigViewModel owner) : base(owner)
  {
    Caption = CommonStrings.ModelConfiguration + ": " + CommonStrings.Properties.ToLower();
    Items = new ListViewModel<PropertyConfigViewModel>();
    CollectionViewSource = new CollectionViewSource<PropertyConfigViewModel>(Items);
    VisibleItems = CollectionViewSource.GetDefaultView(Items);
    ShowProgressBar = true;
    BeginInvokeActionEnabled = false;
  }

  public ListViewModel<PropertyConfigViewModel> Items { [DebuggerStepThrough] get; private set; }

  private CollectionViewSource<PropertyConfigViewModel> CollectionViewSource;

  /// <summary>
  /// This is the result collection view to be used in DataGrid.
  /// </summary>
  public ICollectionView VisibleItems { [DebuggerStepThrough] get; private set; }


  public void ClearItems()
  {
    Items.Clear();
    typesCount = 0;
    propCount = 0;
    ProgressBarMaximum = Owner.TypesConfigList.Items.Count;
  }

  int typesCount = 0;
  int propCount = 0;

  public void CreateItems(TypeConfigViewModel parent, ModelConfigData configData)
  {
    var fullNameComparison = configData.AcceptedTypes.FirstOrDefault(item => item.Contains('.')) != null
                        || configData.RejectedTypes.FirstOrDefault(item => item.Contains('.')) != null;
    ProgressBarValue = ++typesCount;
    var _Properties = new List<PropertyConfigViewModel>();
    var type = parent.Type;
    foreach (var propertyInfo in type.GetProperties())
    {
      var propName = propertyInfo.Name;
      var typedPropName = propName;
      var fullPropName = propName;
      string propTypename = "";
      string propNamespace = "";
      var propDeclaringType = propertyInfo.DeclaringType;
      if (propDeclaringType != null)
      {
        propTypename = propDeclaringType.Name;
        typedPropName = propTypename + "." + typedPropName;
        fullPropName = propTypename + "." + fullPropName;
        if (propDeclaringType.Namespace != null)
        {
          propNamespace = propDeclaringType.Namespace;
          fullPropName = propNamespace + "." + fullPropName;
        }
      }
      var valueType = propertyInfo.PropertyType;
      var valueTypeName = valueType.GetExpandedName(propDeclaringType?.Namespace);
      string valueTypeNamespace = valueType.Namespace ?? "";
      var item = new PropertyConfigViewModel(parent, propertyInfo)
      {
        RecordNumber = ++propCount,
        OrigValueNamespace = valueTypeNamespace,
        OrigValueType = valueTypeName
      };

      if (configData.RejectedProperties.Contains(fullPropName)
        || configData.RejectedProperties.Contains(typedPropName)
        || configData.RejectedProperties.Contains(propName))
        item.IsExcluded = true;

      item.ExcludedValueType =
        (configData.RejectedNamespaces.Contains(valueTypeNamespace) && !configData.AcceptedTypes.Contains(valueType.Name))
        || configData.RejectedTypes.Contains(valueType.Name);
      if (configData.PropertyTranslateTable.TryGetValue(fullPropName, out var newName)
       || configData.PropertyTranslateTable.TryGetValue(propName, out newName))
        item.TargetName = newName;
      else
        item.TargetName = null;
      _Properties.Add(item);
    }
    Items.AddRange(_Properties);
    if (typesCount>=ProgressBarMaximum)
      ProgressBarValue = 0;
  }

  public override void SetData(ModelConfigData configData)
  {
    configData.RejectedProperties.Clear();
    foreach (var item in Items.Where(item => item.IsExcluded && item.IsExcluded!=item.Parent.IsExcluded))
      configData.RejectedProperties.Add(ModelConfig.JoinTypeAndProperty(item.DeclaringType, item.OrigName));

    configData.PropertyTranslateTable.Clear();
    foreach (var item in Items.Where(item => !String.IsNullOrEmpty(item.TargetName)))
      configData.PropertyTranslateTable.Add(ModelConfig.JoinTypeAndProperty(item.DeclaringType, item.OrigName), item.TargetName ?? "");

    configData.PropertyTypeConversion.Clear();
    foreach (var item in Items.Where(item => !String.IsNullOrEmpty(item.TargetPropertyType)))
      configData.PropertyTypeConversion.Add(ModelConfig.JoinTypeAndProperty(item.DeclaringType, item.OrigName), item.TargetPropertyType ?? "");

  }

  public override bool ValidateData()
  {
    var ok = true;
    return ok;
  }

}
