namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the ColorsType Class.
/// </summary>
public static class ColorsTypeConverter
{
  /// <summary>
  /// Color Application Method Type
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.ColorApplicationMethodKind? GetMethod(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues, DocumentModel.Drawings.Diagrams.ColorApplicationMethodKind>(openXmlElement?.Method?.Value);
  }
  
  private static void SetMethod(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType openXmlElement, DocumentModel.Drawings.Diagrams.ColorApplicationMethodKind? value)
  {
    openXmlElement.Method = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues, DocumentModel.Drawings.Diagrams.ColorApplicationMethodKind>(value);
  }
  
  /// <summary>
  /// Hue Direction
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.HueDirectionKind? GetHueDirection(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.HueDirectionValues, DocumentModel.Drawings.Diagrams.HueDirectionKind>(openXmlElement?.HueDirection?.Value);
  }
  
  private static void SetHueDirection(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType openXmlElement, DocumentModel.Drawings.Diagrams.HueDirectionKind? value)
  {
    openXmlElement.HueDirection = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HueDirectionValues, DocumentModel.Drawings.Diagrams.HueDirectionKind>(value);
  }
  
  public static DocumentModel.Drawings.Diagrams.ColorsType? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ColorsType();
      value.Method = GetMethod(openXmlElement);
      value.HueDirection = GetHueDirection(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.ColorsType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMethod(openXmlElement, value?.Method);
      SetHueDirection(openXmlElement, value?.HueDirection);
      return openXmlElement;
    }
    return default;
  }
}
