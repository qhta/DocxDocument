namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Preset Shadow.
/// </summary>
public static class PresetShadowConverter
{
  /// <summary>
  /// Preset Shadow
  /// </summary>
  public static DocumentModel.Drawings.PresetShadowKind? GetPreset(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetShadowValues, DocumentModel.Drawings.PresetShadowKind>(openXmlElement?.Preset?.Value);
  }
  
  public static void SetPreset(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement, DocumentModel.Drawings.PresetShadowKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetShadowValues, DocumentModel.Drawings.PresetShadowKind>(value);
  }
  
  /// <summary>
  /// Distance
  /// </summary>
  public static Int64? GetDistance(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDistance(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Direction
  /// </summary>
  public static Int32? GetDirection(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDirection(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  public static DocumentModel.Drawings.RgbColorModelPercentage? GetRgbColorModelPercentage(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRgbColorModelPercentage(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement, DocumentModel.Drawings.RgbColorModelPercentage? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// RGB Color Model - Hex Variant.
  /// </summary>
  public static DocumentModel.Drawings.RgbColorModelHex? GetRgbColorModelHex(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRgbColorModelHex(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement, DocumentModel.Drawings.RgbColorModelHex? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Hue, Saturation, Luminance Color Model.
  /// </summary>
  public static DocumentModel.Drawings.HslColor? GetHslColor(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHslColor(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement, DocumentModel.Drawings.HslColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// System Color.
  /// </summary>
  public static DocumentModel.Drawings.SystemColor? GetSystemColor(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSystemColor(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement, DocumentModel.Drawings.SystemColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Scheme Color.
  /// </summary>
  public static DocumentModel.Drawings.SchemeColor? GetSchemeColor(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSchemeColor(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement, DocumentModel.Drawings.SchemeColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  public static DocumentModel.Drawings.PresetColor? GetPresetColor(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPresetColor(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement, DocumentModel.Drawings.PresetColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
