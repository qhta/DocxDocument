namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Diagram Relationship.
/// </summary>
public static class RelationConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.Relation openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static void SetExtension(DocumentFormat.OpenXml.Vml.Office.Relation openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Diagram Relationship Source Shape
  /// </summary>
  private static String? GetSourceId(DocumentFormat.OpenXml.Vml.Office.Relation openXmlElement)
  {
    return openXmlElement?.SourceId?.Value;
  }
  
  private static void SetSourceId(DocumentFormat.OpenXml.Vml.Office.Relation openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SourceId = new StringValue { Value = value };
    else
      openXmlElement.SourceId = null;
  }
  
  /// <summary>
  /// Diagram Relationship Destination Shape
  /// </summary>
  private static String? GetDestinationId(DocumentFormat.OpenXml.Vml.Office.Relation openXmlElement)
  {
    return openXmlElement?.DestinationId?.Value;
  }
  
  private static void SetDestinationId(DocumentFormat.OpenXml.Vml.Office.Relation openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.DestinationId = new StringValue { Value = value };
    else
      openXmlElement.DestinationId = null;
  }
  
  /// <summary>
  /// Diagram Relationship Center Shape
  /// </summary>
  private static String? GetCenterShapeId(DocumentFormat.OpenXml.Vml.Office.Relation openXmlElement)
  {
    return openXmlElement?.CenterShapeId?.Value;
  }
  
  private static void SetCenterShapeId(DocumentFormat.OpenXml.Vml.Office.Relation openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CenterShapeId = new StringValue { Value = value };
    else
      openXmlElement.CenterShapeId = null;
  }
  
  public static DocumentModel.Vml.Relation? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.Relation? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Relation? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.Relation, new()
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
