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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Drawing.LinePropertiesType? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
  
}
