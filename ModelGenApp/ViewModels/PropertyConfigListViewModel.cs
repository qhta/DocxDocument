namespace ModelGenApp.ViewModels;
public class PropertyConfigListViewModel : ModelConfigViewModel
{
  public PropertyConfigListViewModel(ModelConfigData configData) : base(configData)
  {
    Caption = CommonStrings.ModelConfiguration +": "+CommonStrings.Properties.ToLower();
    Properties = new ListViewModel<PropertyConfigViewModel>();
    CollectionViewSource = new CollectionViewSource<PropertyConfigViewModel>(Properties);
    VisibleItems = CollectionViewSource.GetDefaultView(Properties);
    GetData(configData);
  }

  public ListViewModel<PropertyConfigViewModel> Properties { get; private set; }

  private CollectionViewSource<PropertyConfigViewModel> CollectionViewSource;

  /// <summary>
  /// This is the result collection view to be used in DataGrid.
  /// </summary>
  public ICollectionView VisibleItems { get; private set; }


  public override void GetData(ModelConfigData configData)
  {
    Properties.Clear();
    base.GetData(configData);
    foreach (var propName in configData.ExcludedProperties)
    {
      (var origType, var origName) = ModelConfig.SplitNameToTypeAndProperty(propName);
      var item = new PropertyConfigViewModel { OrigType = origType, OrigName = origName, ExcludedProperty = true };
      Properties.Add(item);
    }
    foreach (var itemPair in configData.PropertyTranslateTable)
    {
      (var origType, var origName) = ModelConfig.SplitNameToTypeAndProperty(itemPair.Key);
      var targetPropName = itemPair.Value;
      var item = Properties.FirstOrDefault(prop => prop.OrigType == origType && prop.OrigName == origName);
      if (item != null)
        item.TargetName = targetPropName;
      else
      {
        item = new PropertyConfigViewModel { OrigType = origType, OrigName = origName, TargetName = targetPropName };
        Properties.Add(item);
      }
    }
    foreach (var itemPair in configData.PropertyTypeConversion)
    {
      (var origType, var origName) = ModelConfig.SplitNameToTypeAndProperty(itemPair.Key);
      var targetPropType = itemPair.Value;
      var item = Properties.FirstOrDefault(prop => prop.OrigType == origType && prop.OrigName == origName);
      if (item != null)
        item.TargetPropertyType = targetPropType;
      else
      {
        item = new PropertyConfigViewModel { OrigType = origType, OrigName = origName, TargetPropertyType = targetPropType };
        Properties.Add(item);
      }
    }
  }

  public override void SetData(ModelConfigData configData)
  {
    configData.ExcludedProperties.Clear();
    foreach (var item in Properties.Where(item => item.ExcludedProperty))
      configData.ExcludedProperties.Add(ModelConfig.JoinTypeAndProperty(item.OrigType, item.OrigName));
    
    configData.PropertyTranslateTable.Clear();
    foreach (var item in Properties.Where(item => !String.IsNullOrEmpty(item.TargetName)))
      configData.PropertyTranslateTable.Add(ModelConfig.JoinTypeAndProperty(item.OrigType, item.OrigName), item.TargetName??"");

    configData.PropertyTypeConversion.Clear();
    foreach (var item in Properties.Where(item => !String.IsNullOrEmpty(item.TargetPropertyType)))
      configData.PropertyTypeConversion.Add(ModelConfig.JoinTypeAndProperty(item.OrigType, item.OrigName), item.TargetPropertyType??"");

  }

  public override bool ValidateData()
  {
    var ok = true;
    return ok;
  }

}
