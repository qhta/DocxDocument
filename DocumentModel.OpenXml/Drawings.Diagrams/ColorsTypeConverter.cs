namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the ColorsType Class.
/// </summary>
public static class ColorsTypeConverter
{
  /// <summary>
  /// Color Application Method Type
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ColorApplicationMethodKind? GetMethod(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues, DocumentModel.Drawings.Diagrams.ColorApplicationMethodKind>(openXmlElement?.Method?.Value);
  }
  
  public static void SetMethod(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType? openXmlElement, DocumentModel.Drawings.Diagrams.ColorApplicationMethodKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Method = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues, DocumentModel.Drawings.Diagrams.ColorApplicationMethodKind>(value);
  }
  
  /// <summary>
  /// Hue Direction
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.HueDirectionKind? GetHueDirection(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.HueDirectionValues, DocumentModel.Drawings.Diagrams.HueDirectionKind>(openXmlElement?.HueDirection?.Value);
  }
  
  public static void SetHueDirection(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType? openXmlElement, DocumentModel.Drawings.Diagrams.HueDirectionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.HueDirection = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HueDirectionValues, DocumentModel.Drawings.Diagrams.HueDirectionKind>(value);
  }
  
}
