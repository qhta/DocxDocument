namespace ModelGenApp.ViewModels;
public class PropertyConfigListViewModel : ModelConfigViewModel
{
  public PropertyConfigListViewModel(ModelConfigData configData) : base(configData)
  {
    Caption = CommonStrings.ModelConfiguration + ": " + CommonStrings.Properties.ToLower();
    Properties = new ListViewModel<PropertyConfigViewModel>();
    Properties.NotificationDelay = 500;
    CollectionViewSource = new CollectionViewSource<PropertyConfigViewModel>(Properties);
    VisibleItems = CollectionViewSource.GetDefaultView(Properties);
    ShowProgressBar = true;
    BeginInvokeActionEnabled = false;
    //GetData(configData);
    Task.Factory.StartNew(()=>GetData(configData));
  }

  public ListViewModel<PropertyConfigViewModel> Properties { get; private set; }

  private CollectionViewSource<PropertyConfigViewModel> CollectionViewSource;

  /// <summary>
  /// This is the result collection view to be used in DataGrid.
  /// </summary>
  public ICollectionView VisibleItems { get; private set; }

  public override void GetData(ModelConfigData configData)
  {
    Debug.WriteLine("GetData");
    Properties.Clear();
    base.GetData(configData);
    var types = _Assembly.GetExportedTypes()
      .OrderBy(t => t.Name)
      .ToList();
    ProgressBarMaximum = types.Count;
    ProgressBarValue = 0;
    var fullNameComparison = configData.IncludedTypes.FirstOrDefault(item => item.Contains('.')) != null
                          || configData.ExcludedTypes.FirstOrDefault(item => item.Contains('.')) != null;
    int typesCount=0;
    int propCount = 0;
    foreach (var type in types)
    {
      ProgressBarValue = ++typesCount;
      var _Properties = new List<PropertyConfigViewModel>();
      foreach (var property in type.GetProperties())
      {
        var propName = property.Name;
        var typedPropName = propName;
        var fullPropName = propName;
        string propTypename = "";
        string propNamespace = "";
        var propDeclaringType = property.DeclaringType;
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
        var valueType = property.PropertyType;
        var valueTypeName = valueType.GetExpandedName(propDeclaringType?.Namespace);
        string valueTypeNamespace = valueType.Namespace ?? "";
        var item = new PropertyConfigViewModel
        {
          RecordNumber = ++propCount,
          OrigName = propName,
          OrigType = propTypename,
          OrigNamespace = propNamespace,
          OrigValueNamespace = valueTypeNamespace,
          OrigValueType = valueTypeName
        };
        item.ExcludedNamespace = configData.ExcludedNamespaces.Contains(propNamespace);
        item.ExcludedType = configData.ExcludedTypes.Contains(propTypename);
        item.ExcludedProperty = configData.ExcludedProperties.Contains(fullPropName) 
          || configData.ExcludedProperties.Contains(typedPropName)
          || configData.ExcludedProperties.Contains(propName);
        item.ExcludedValueType = 
          (configData.ExcludedNamespaces.Contains(valueTypeNamespace) && !configData.IncludedTypes.Contains(valueType.Name))
          || configData.ExcludedTypes.Contains(valueType.Name);
        if (configData.PropertyTranslateTable.TryGetValue(fullPropName, out var newName)
         || configData.PropertyTranslateTable.TryGetValue(propName, out newName)) 
          item.TargetName = newName;
        else
          item.TargetName = null;
        _Properties.Add(item);
      }
      Properties.AddRange(_Properties);
    }
    ProgressBarValue = 0;
    //foreach (var propName in configData.ExcludedProperties)
    //{
    //  (var origType, var origName) = ModelConfig.SplitNameToTypeAndProperty(propName);
    //  var item = new PropertyConfigViewModel { OrigType = origType, OrigName = origName, ExcludedProperty = true };
    //  Properties.Add(item);
    //}
    //foreach (var itemPair in configData.PropertyTranslateTable)
    //{
    //  (var origType, var origName) = ModelConfig.SplitNameToTypeAndProperty(itemPair.Key);
    //  var targetPropName = itemPair.Value;
    //  var item = Properties.FirstOrDefault(prop => prop.OrigType == origType && prop.OrigName == origName);
    //  if (item != null)
    //    item.TargetName = targetPropName;
    //  else
    //  {
    //    item = new PropertyConfigViewModel { OrigType = origType, OrigName = origName, TargetName = targetPropName };
    //    Properties.Add(item);
    //  }
    //}
    //foreach (var itemPair in configData.PropertyTypeConversion)
    //{
    //  (var origType, var origName) = ModelConfig.SplitNameToTypeAndProperty(itemPair.Key);
    //  var targetPropType = itemPair.Value;
    //  var item = Properties.FirstOrDefault(prop => prop.OrigType == origType && prop.OrigName == origName);
    //  if (item != null)
    //    item.TargetPropertyType = targetPropType;
    //  else
    //  {
    //    item = new PropertyConfigViewModel { OrigType = origType, OrigName = origName, TargetPropertyType = targetPropType };
    //    Properties.Add(item);
    //  }
    //}
  }

  public override void SetData(ModelConfigData configData)
  {
    configData.ExcludedProperties.Clear();
    foreach (var item in Properties.Where(item => item.ExcludedProperty))
      configData.ExcludedProperties.Add(ModelConfig.JoinTypeAndProperty(item.OrigType, item.OrigName));

    configData.PropertyTranslateTable.Clear();
    foreach (var item in Properties.Where(item => !String.IsNullOrEmpty(item.TargetName)))
      configData.PropertyTranslateTable.Add(ModelConfig.JoinTypeAndProperty(item.OrigType, item.OrigName), item.TargetName ?? "");

    configData.PropertyTypeConversion.Clear();
    foreach (var item in Properties.Where(item => !String.IsNullOrEmpty(item.TargetPropertyType)))
      configData.PropertyTypeConversion.Add(ModelConfig.JoinTypeAndProperty(item.OrigType, item.OrigName), item.TargetPropertyType ?? "");

  }

  public override bool ValidateData()
  {
    var ok = true;
    return ok;
  }

}
