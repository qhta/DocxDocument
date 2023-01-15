using DocumentFormat.OpenXml.Vml;
using DocumentModel.Vml;
using Relation = DocumentFormat.OpenXml.Vml.Office.Relation;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Diagram Relationship.
/// </summary>
public static class RelationConverter
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public static ExtensionHandlingBehaviorKind? GetExtension(Relation? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }

  public static void SetExtension(Relation? openXmlElement, ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(value);
  }

  /// <summary>
  ///   Diagram Relationship Source Shape
  /// </summary>
  public static String? GetSourceId(Relation? openXmlElement)
  {
    return openXmlElement?.SourceId?.Value;
  }

  public static void SetSourceId(Relation? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SourceId = new StringValue { Value = value };
      else
        openXmlElement.SourceId = null;
  }

  /// <summary>
  ///   Diagram Relationship Destination Shape
  /// </summary>
  public static String? GetDestinationId(Relation? openXmlElement)
  {
    return openXmlElement?.DestinationId?.Value;
  }

  public static void SetDestinationId(Relation? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DestinationId = new StringValue { Value = value };
      else
        openXmlElement.DestinationId = null;
  }

  /// <summary>
  ///   Diagram Relationship Center Shape
  /// </summary>
  public static String? GetCenterShapeId(Relation? openXmlElement)
  {
    return openXmlElement?.CenterShapeId?.Value;
  }

  public static void SetCenterShapeId(Relation? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CenterShapeId = new StringValue { Value = value };
      else
        openXmlElement.CenterShapeId = null;
  }

  public static DocumentModel.Vml.Relation? CreateModelElement(Relation? openXmlElement)
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
    where OpenXmlElementType : Relation, new()
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