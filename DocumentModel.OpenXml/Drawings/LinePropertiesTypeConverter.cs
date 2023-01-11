namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LinePropertiesType Class.
/// </summary>
public static class LinePropertiesTypeConverter
{
  /// <summary>
  /// line width
  /// </summary>
  public static Int32? GetWidth(DocumentFormat.OpenXml.Drawing.LinePropertiesType? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Drawing.LinePropertiesType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = value;
  }
  
  /// <summary>
  /// line cap
  /// </summary>
  public static DocumentModel.Drawings.LineCapKind? GetCapType(DocumentFormat.OpenXml.Drawing.LinePropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LineCapValues, DocumentModel.Drawings.LineCapKind>(openXmlElement?.CapType?.Value);
  }
  
  public static void SetCapType(DocumentFormat.OpenXml.Drawing.LinePropertiesType? openXmlElement, DocumentModel.Drawings.LineCapKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CapType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LineCapValues, DocumentModel.Drawings.LineCapKind>(value);
  }
  
  /// <summary>
  /// compound line type
  /// </summary>
  public static DocumentModel.Drawings.CompoundLineKind? GetCompoundLineType(DocumentFormat.OpenXml.Drawing.LinePropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues, DocumentModel.Drawings.CompoundLineKind>(openXmlElement?.CompoundLineType?.Value);
  }
  
  public static void SetCompoundLineType(DocumentFormat.OpenXml.Drawing.LinePropertiesType? openXmlElement, DocumentModel.Drawings.CompoundLineKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CompoundLineType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues, DocumentModel.Drawings.CompoundLineKind>(value);
  }
  
  /// <summary>
  /// pen alignment
  /// </summary>
  public static DocumentModel.Drawings.PenAlignmentKind? GetAlignment(DocumentFormat.OpenXml.Drawing.LinePropertiesType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues, DocumentModel.Drawings.PenAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  public static void SetAlignment(DocumentFormat.OpenXml.Drawing.LinePropertiesType? openXmlElement, DocumentModel.Drawings.PenAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues, DocumentModel.Drawings.PenAlignmentKind>(value);
  }
  
  public static DocumentModel.Drawings.LinePropertiesType? CreateModelElement(DocumentFormat.OpenXml.Drawing.LinePropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LinePropertiesType();
      value.Width = GetWidth(openXmlElement);
      value.CapType = GetCapType(openXmlElement);
      value.CompoundLineType = GetCompoundLineType(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LinePropertiesType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.LinePropertiesType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
