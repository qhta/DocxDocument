namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the FontReference Class.
/// </summary>
public static class FontReferenceConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  public static DocumentModel.Drawings.FontCollectionIndexKind? GetIndex(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues, DocumentModel.Drawings.FontCollectionIndexKind>(openXmlElement?.Index?.Value);
  }
  
  public static void SetIndex(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement, DocumentModel.Drawings.FontCollectionIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Index = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues, DocumentModel.Drawings.FontCollectionIndexKind>(value);
  }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public static DocumentModel.ListOf<String>? GetModifiers(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetModifiers(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement, DocumentModel.ListOf<String>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.RgbColorModelPercentage? GetRgbColorModelPercentage(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRgbColorModelPercentage(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement, DocumentModel.Drawings.RgbColorModelPercentage? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.RgbColorModelHex? GetRgbColorModelHex(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRgbColorModelHex(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement, DocumentModel.Drawings.RgbColorModelHex? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.HslColor? GetHslColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHslColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement, DocumentModel.Drawings.HslColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.SystemColor? GetSystemColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSystemColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement, DocumentModel.Drawings.SystemColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.SchemeColor? GetSchemeColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSchemeColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement, DocumentModel.Drawings.SchemeColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.PresetColor? GetPresetColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPresetColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement, DocumentModel.Drawings.PresetColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ChartsStyle.StyleColor? GetStyleColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetStyleColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement, DocumentModel.Drawings.ChartsStyle.StyleColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
