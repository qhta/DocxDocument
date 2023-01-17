namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ObjectEmbed Class.
/// </summary>
public static class ObjectEmbedConverter
{
  /// <summary>
  /// drawAspect
  /// </summary>
  private static DocumentModel.Wordprocessing.ObjectDrawAspect? GetdrawAspect(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect, DocumentModel.Wordprocessing.ObjectDrawAspect>(openXmlElement?.drawAspect?.Value);
  }
  
  private static void SetdrawAspect(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed openXmlElement, DocumentModel.Wordprocessing.ObjectDrawAspect? value)
  {
    openXmlElement.drawAspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect, DocumentModel.Wordprocessing.ObjectDrawAspect>(value);
  }
  
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// progId
  /// </summary>
  private static String? GetProgId(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed openXmlElement)
  {
    return openXmlElement?.ProgId?.Value;
  }
  
  private static void SetProgId(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ProgId = new StringValue { Value = value };
    else
      openXmlElement.ProgId = null;
  }
  
  /// <summary>
  /// shapeId
  /// </summary>
  private static String? GetShapeId(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed openXmlElement)
  {
    return openXmlElement?.ShapeId?.Value;
  }
  
  private static void SetShapeId(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ShapeId = new StringValue { Value = value };
    else
      openXmlElement.ShapeId = null;
  }
  
  /// <summary>
  /// fieldCodes
  /// </summary>
  private static String? GetFieldCodes(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed openXmlElement)
  {
    return openXmlElement?.FieldCodes?.Value;
  }
  
  private static void SetFieldCodes(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FieldCodes = new StringValue { Value = value };
    else
      openXmlElement.FieldCodes = null;
  }
  
  public static DocumentModel.Wordprocessing.ObjectEmbed? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ObjectEmbed();
      value.drawAspect = GetdrawAspect(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.ProgId = GetProgId(openXmlElement);
      value.ShapeId = GetShapeId(openXmlElement);
      value.FieldCodes = GetFieldCodes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ObjectEmbed? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetdrawAspect(openXmlElement, value?.drawAspect);
      SetId(openXmlElement, value?.Id);
      SetProgId(openXmlElement, value?.ProgId);
      SetShapeId(openXmlElement, value?.ShapeId);
      SetFieldCodes(openXmlElement, value?.FieldCodes);
      return openXmlElement;
    }
    return default;
  }
}
