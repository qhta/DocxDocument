namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Rule Set.
/// </summary>
public static class RulesConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMVml.ExtensionHandlingBehaviorKind? GetExtension(DXVmlO.Rules openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static void SetExtension(DXVmlO.Rules openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(value);
  }
  
  private static Collection<DMVml.Rule> GetItems(DXVmlO.Rules openXmlElement)
  {
    var collection = new Collection<DMVml.Rule>();
    foreach (var item in openXmlElement.Elements<DXVmlO.Rule>())
    {
      var newItem = DMXVml.RuleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DXVmlO.Rules openXmlElement, Collection<DMVml.Rule>? value)
  {
    openXmlElement.RemoveAllChildren<DXVmlO.Rule>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXVml.RuleConverter.CreateOpenXmlElement<DXVmlO.Rule>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMVml.Rules? CreateModelElement(DXVmlO.Rules? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.Rules();
      value.Extension = GetExtension(openXmlElement);
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.Rules? value)
    where OpenXmlElementType: DXVmlO.Rules, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
