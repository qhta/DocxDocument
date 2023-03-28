namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Diagram Relationship converter from/to OpenXml.
///</summary>
public static class RelationConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMVml.ExtensionHandlingBehaviorKind? GetExtension(DXVmlO.Relation openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static bool CmpExtension(DXVmlO.Relation openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName);
  }
  
  private static void SetExtension(DXVmlO.Relation openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Diagram Relationship Source Shape
  /// </summary>
  private static String? GetSourceId(DXVmlO.Relation openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SourceId);
  }
  
  private static bool CmpSourceId(DXVmlO.Relation openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SourceId, value, diffs, objName, "SourceId");
  }
  
  private static void SetSourceId(DXVmlO.Relation openXmlElement, String? value)
  {
    openXmlElement.SourceId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Diagram Relationship Destination Shape
  /// </summary>
  private static String? GetDestinationId(DXVmlO.Relation openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.DestinationId);
  }
  
  private static bool CmpDestinationId(DXVmlO.Relation openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.DestinationId, value, diffs, objName, "DestinationId");
  }
  
  private static void SetDestinationId(DXVmlO.Relation openXmlElement, String? value)
  {
    openXmlElement.DestinationId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Diagram Relationship Center Shape
  /// </summary>
  private static String? GetCenterShapeId(DXVmlO.Relation openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CenterShapeId);
  }
  
  private static bool CmpCenterShapeId(DXVmlO.Relation openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CenterShapeId, value, diffs, objName, "CenterShapeId");
  }
  
  private static void SetCenterShapeId(DXVmlO.Relation openXmlElement, String? value)
  {
    openXmlElement.CenterShapeId = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Vml.Relation? CreateModelElement(DXVmlO.Relation? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Relation();
      value.Extension = GetExtension(openXmlElement);
      value.SourceId = GetSourceId(openXmlElement);
      value.DestinationId = GetDestinationId(openXmlElement);
      value.CenterShapeId = GetCenterShapeId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVmlO.Relation? openXmlElement, DMVml.Relation? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension(openXmlElement, value.Extension, diffs, objName))
        ok = false;
      if (!CmpSourceId(openXmlElement, value.SourceId, diffs, objName))
        ok = false;
      if (!CmpDestinationId(openXmlElement, value.DestinationId, diffs, objName))
        ok = false;
      if (!CmpCenterShapeId(openXmlElement, value.CenterShapeId, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVml.Relation value)
    where OpenXmlElementType: DXVmlO.Relation, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVmlO.Relation openXmlElement, DMVml.Relation value)
  {
    SetExtension(openXmlElement, value?.Extension);
    SetSourceId(openXmlElement, value?.SourceId);
    SetDestinationId(openXmlElement, value?.DestinationId);
    SetCenterShapeId(openXmlElement, value?.CenterShapeId);
  }
}
