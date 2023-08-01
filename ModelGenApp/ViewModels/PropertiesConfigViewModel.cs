namespace ModelGenApp.ViewModels;
public class PropertiesConfigViewModel : ModelConfigViewModel
{
  public PropertiesConfigViewModel(ModelConfig configData) : base(configData)
  {
    Caption = "Model configuration: properties";
    Properties = new DispatchedCollection<PropertyConfigViewModel>();
    Items = Properties;
    GetData(configData);
  }

  public DispatchedCollection<PropertyConfigViewModel> Properties { get; private set; }

  public override void GetData(ModelConfig configData)
  {
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

  public override void SetData(ModelConfig configData)
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

  public override bool ValidateData(ModelConfig configData)
  {
    var ok = true;
    return ok;
  }

}
