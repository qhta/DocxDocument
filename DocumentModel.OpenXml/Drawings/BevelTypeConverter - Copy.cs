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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Drawing.BevelType? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Height
  /// </summary>
  public static Int64? GetHeight(DocumentFormat.OpenXml.Drawing.BevelType? openXmlElement)
  {
    if (openXmlElement?.Height?.HasValue == true)
      return openXmlElement.Height.Value;
    return null;
  }
  
  public static void SetHeight(DocumentFormat.OpenXml.Drawing.BevelType? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
  
}
