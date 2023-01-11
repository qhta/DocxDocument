namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LineEndPropertiesType Class.
/// </summary>
public static class LineEndPropertiesTypeConverter
{
  /// <summary>
  /// Line Head/End Type
  /// </summary>
  public static DocumentModel.Drawings.LineEndKind? GetType(DocumentFormat.OpenXml.Drawing.LineEndPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LineEndValues, DocumentModel.Drawings.LineEndKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Drawing.LineEndPropertiesType? openXmlElement, DocumentModel.Drawings.LineEndKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LineEndValues, DocumentModel.Drawings.LineEndKind>(value);
  }
  
  /// <summary>
  /// Width of Head/End
  /// </summary>
  public static DocumentModel.Drawings.LineEndWidthKind? GetWidth(DocumentFormat.OpenXml.Drawing.LineEndPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LineEndWidthValues, DocumentModel.Drawings.LineEndWidthKind>(openXmlElement?.Width?.Value);
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Drawing.LineEndPropertiesType? openXmlElement, DocumentModel.Drawings.LineEndWidthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LineEndWidthValues, DocumentModel.Drawings.LineEndWidthKind>(value);
  }
  
  /// <summary>
  /// Length of Head/End
  /// </summary>
  public static DocumentModel.Drawings.LineEndLengthKind? GetLength(DocumentFormat.OpenXml.Drawing.LineEndPropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LineEndLengthValues, DocumentModel.Drawings.LineEndLengthKind>(openXmlElement?.Length?.Value);
  }
  
  public static void SetLength(DocumentFormat.OpenXml.Drawing.LineEndPropertiesType? openXmlElement, DocumentModel.Drawings.LineEndLengthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Length = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LineEndLengthValues, DocumentModel.Drawings.LineEndLengthKind>(value);
  }
  
  public static DocumentModel.Drawings.LineEndPropertiesType? CreateModelElement(DocumentFormat.OpenXml.Drawing.LineEndPropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LineEndPropertiesType();
      value.Type = GetType(openXmlElement);
      value.Width = GetWidth(openXmlElement);
      value.Length = GetLength(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LineEndPropertiesType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.LineEndPropertiesType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
