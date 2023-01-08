namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ObjectEmbed Class.
/// </summary>
public static class ObjectEmbedConverter
{
  /// <summary>
  /// drawAspect
  /// </summary>
  public static DocumentModel.Wordprocessing.ObjectDrawAspect? GetdrawAspect(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect, DocumentModel.Wordprocessing.ObjectDrawAspect>(openXmlElement?.drawAspect?.Value);
  }
  
  public static void SetdrawAspect(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed? openXmlElement, DocumentModel.Wordprocessing.ObjectDrawAspect? value)
  {
    if (openXmlElement != null)
      openXmlElement.drawAspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect, DocumentModel.Wordprocessing.ObjectDrawAspect>(value);
  }
  
  /// <summary>
  /// id
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// progId
  /// </summary>
  public static String? GetProgId(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetProgId(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// shapeId
  /// </summary>
  public static String? GetShapeId(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetShapeId(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// fieldCodes
  /// </summary>
  public static String? GetFieldCodes(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetFieldCodes(DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
