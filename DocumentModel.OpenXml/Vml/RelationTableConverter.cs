namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Diagram Relationship Table.
/// </summary>
public static class RelationTableConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMVml.ExtensionHandlingBehaviorKind? GetExtension(DXVmlO.RelationTable openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static void SetExtension(DXVmlO.RelationTable openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(value);
  }
  
  private static Collection<DMVml.Relation> GetRelations(DXVmlO.RelationTable openXmlElement)
  {
    var collection = new Collection<DMVml.Relation>();
    foreach (var item in openXmlElement.Elements<DXVmlO.Relation>())
    {
      var newItem = DMXVml.RelationConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetRelations(DXVmlO.RelationTable openXmlElement, Collection<DMVml.Relation>? value)
  {
    openXmlElement.RemoveAllChildren<DXVmlO.Relation>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXVml.RelationConverter.CreateOpenXmlElement<DXVmlO.Relation>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMVml.RelationTable? CreateModelElement(DXVmlO.RelationTable? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.RelationTable();
      value.Extension = GetExtension(openXmlElement);
      value.Relations = GetRelations(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.RelationTable? value)
    where OpenXmlElementType: DXVmlO.RelationTable, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetRelations(openXmlElement, value?.Relations);
      return openXmlElement;
    }
    return default;
  }
}
