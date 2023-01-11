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
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.ByteValue");
  }
  
  public static void SetSize(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties? openXmlElement, Byte? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.ByteValue");
  }
  
  public static DocumentModel.Drawings.ChartsStyle.MarkerLayoutProperties? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartsStyle.MarkerLayoutProperties();
      value.Symbol = GetSymbol(openXmlElement);
      value.Size = GetSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartsStyle.MarkerLayoutProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
