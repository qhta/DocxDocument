namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the FontReference Class.
/// </summary>
public static class FontReferenceConverter
{
  /// <summary>
  /// Identifier
  /// </summary>
  public static DocumentModel.Drawings.FontCollectionIndexKind? GetIndex(DocumentFormat.OpenXml.Drawing.FontReference? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues, DocumentModel.Drawings.FontCollectionIndexKind>(openXmlElement?.Index?.Value);
  }
  
  public static void SetIndex(DocumentFormat.OpenXml.Drawing.FontReference? openXmlElement, DocumentModel.Drawings.FontCollectionIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Index = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues, DocumentModel.Drawings.FontCollectionIndexKind>(value);
  }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  public static DocumentModel.Drawings.RgbColorModelPercentage? GetRgbColorModelPercentage(DocumentFormat.OpenXml.Drawing.FontReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRgbColorModelPercentage(DocumentFormat.OpenXml.Drawing.FontReference? openXmlElement, DocumentModel.Drawings.RgbColorModelPercentage? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// RGB Color Model - Hex Variant.
  /// </summary>
  public static DocumentModel.Drawings.RgbColorModelHex? GetRgbColorModelHex(DocumentFormat.OpenXml.Drawing.FontReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRgbColorModelHex(DocumentFormat.OpenXml.Drawing.FontReference? openXmlElement, DocumentModel.Drawings.RgbColorModelHex? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Hue, Saturation, Luminance Color Model.
  /// </summary>
  public static DocumentModel.Drawings.HslColor? GetHslColor(DocumentFormat.OpenXml.Drawing.FontReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHslColor(DocumentFormat.OpenXml.Drawing.FontReference? openXmlElement, DocumentModel.Drawings.HslColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// System Color.
  /// </summary>
  public static DocumentModel.Drawings.SystemColor? GetSystemColor(DocumentFormat.OpenXml.Drawing.FontReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSystemColor(DocumentFormat.OpenXml.Drawing.FontReference? openXmlElement, DocumentModel.Drawings.SystemColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Scheme Color.
  /// </summary>
  public static DocumentModel.Drawings.SchemeColor? GetSchemeColor(DocumentFormat.OpenXml.Drawing.FontReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSchemeColor(DocumentFormat.OpenXml.Drawing.FontReference? openXmlElement, DocumentModel.Drawings.SchemeColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  public static DocumentModel.Drawings.PresetColor? GetPresetColor(DocumentFormat.OpenXml.Drawing.FontReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPresetColor(DocumentFormat.OpenXml.Drawing.FontReference? openXmlElement, DocumentModel.Drawings.PresetColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
