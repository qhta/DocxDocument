namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BevelType Class.
/// </summary>
public static class BevelTypeConverter
{
  /// <summary>
  /// Width
  /// </summary>
  public static Int64? GetWidth(DocumentFormat.OpenXml.Drawing.BevelType? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Drawing.BevelType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = value;
  }
  
  /// <summary>
  /// Height
  /// </summary>
  public static Int64? GetHeight(DocumentFormat.OpenXml.Drawing.BevelType? openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }
  
  public static void SetHeight(DocumentFormat.OpenXml.Drawing.BevelType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Height = value;
  }
  
  /// <summary>
  /// Preset Bevel
  /// </summary>
  public static DocumentModel.Drawings.BevelPresetKind? GetPreset(DocumentFormat.OpenXml.Drawing.BevelType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BevelPresetValues, DocumentModel.Drawings.BevelPresetKind>(openXmlElement?.Preset?.Value);
  }
  
  public static void SetPreset(DocumentFormat.OpenXml.Drawing.BevelType? openXmlElement, DocumentModel.Drawings.BevelPresetKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BevelPresetValues, DocumentModel.Drawings.BevelPresetKind>(value);
  }
  
  public static DocumentModel.Drawings.BevelType? CreateModelElement(DocumentFormat.OpenXml.Drawing.BevelType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BevelType();
      value.Width = GetWidth(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.Preset = GetPreset(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.BevelType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.BevelType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
