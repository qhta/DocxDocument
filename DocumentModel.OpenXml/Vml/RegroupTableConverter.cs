namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Grouping History.
/// </summary>
public static class RegroupTableConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMVml.ExtensionHandlingBehaviorKind? GetExtension(DXVmlO.RegroupTable openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static void SetExtension(DXVmlO.RegroupTable openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(value);
  }
  
  private static Collection<DMVml.Entry> GetEntries(DXVmlO.RegroupTable openXmlElement)
  {
    var collection = new Collection<DMVml.Entry>();
    foreach (var item in openXmlElement.Elements<DXVmlO.Entry>())
    {
      var newItem = DMXVml.EntryConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetEntries(DXVmlO.RegroupTable openXmlElement, Collection<DMVml.Entry>? value)
  {
    openXmlElement.RemoveAllChildren<DXVmlO.Entry>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXVml.EntryConverter.CreateOpenXmlElement<DXVmlO.Entry>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMVml.RegroupTable? CreateModelElement(DXVmlO.RegroupTable? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.RegroupTable();
      value.Extension = GetExtension(openXmlElement);
      value.Entries = GetEntries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.RegroupTable? value)
    where OpenXmlElementType: DXVmlO.RegroupTable, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetEntries(openXmlElement, value?.Entries);
      return openXmlElement;
    }
    return default;
  }
}
