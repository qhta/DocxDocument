namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Diagram Relationship.
/// </summary>
public static class RelationConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMVml.ExtensionHandlingBehaviorKind? GetExtension(DXVmlO.Relation openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
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
    return openXmlElement?.SourceId?.Value;
  }
  
  private static void SetSourceId(DXVmlO.Relation openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SourceId = new StringValue { Value = value };
    else
      openXmlElement.SourceId = null;
  }
  
  /// <summary>
  /// Diagram Relationship Destination Shape
  /// </summary>
  private static String? GetDestinationId(DXVmlO.Relation openXmlElement)
  {
    return openXmlElement?.DestinationId?.Value;
  }
  
  private static void SetDestinationId(DXVmlO.Relation openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.DestinationId = new StringValue { Value = value };
    else
      openXmlElement.DestinationId = null;
  }
  
  /// <summary>
  /// Diagram Relationship Center Shape
  /// </summary>
  private static String? GetCenterShapeId(DXVmlO.Relation openXmlElement)
  {
    return openXmlElement?.CenterShapeId?.Value;
  }
  
  private static void SetCenterShapeId(DXVmlO.Relation openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CenterShapeId = new StringValue { Value = value };
    else
      openXmlElement.CenterShapeId = null;
  }
  
  public static DMVml.Relation? CreateModelElement(DXVmlO.Relation? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.Relation();
      value.Extension = GetExtension(openXmlElement);
      value.SourceId = GetSourceId(openXmlElement);
      value.DestinationId = GetDestinationId(openXmlElement);
      value.CenterShapeId = GetCenterShapeId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.Relation? value)
    where OpenXmlElementType: DXVmlO.Relation, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetSourceId(openXmlElement, value?.SourceId);
      SetDestinationId(openXmlElement, value?.DestinationId);
      SetCenterShapeId(openXmlElement, value?.CenterShapeId);
      return openXmlElement;
    }
    return default;
  }
}
