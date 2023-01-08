namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the MarkerLayoutProperties Class.
/// </summary>
public static class MarkerLayoutPropertiesConverter
{
  /// <summary>
  /// symbol, this property is only available in Office 2013 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartsStyle.MarkerStyle? GetSymbol(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerStyle, DocumentModel.Drawings.ChartsStyle.MarkerStyle>(openXmlElement?.Symbol?.Value);
  }
  
  public static void SetSymbol(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties? openXmlElement, DocumentModel.Drawings.ChartsStyle.MarkerStyle? value)
  {
    if (openXmlElement != null)
      openXmlElement.Symbol = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerStyle, DocumentModel.Drawings.ChartsStyle.MarkerStyle>(value);
  }
  
  /// <summary>
  /// size, this property is only available in Office 2013 and later.
  /// </summary>
  public static Byte? GetSize(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSize(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties? openXmlElement, Byte? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
