namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Statistics Class.
/// </summary>
public static class StatisticsConverter
{
  /// <summary>
  /// quartileMethod, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.QuartileMethod? GetQuartileMethod(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Statistics? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod, DocumentModel.Drawings.ChartDrawings.QuartileMethod>(openXmlElement?.QuartileMethod?.Value);
  }
  
  public static void SetQuartileMethod(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Statistics? openXmlElement, DocumentModel.Drawings.ChartDrawings.QuartileMethod? value)
  {
    if (openXmlElement != null)
      openXmlElement.QuartileMethod = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod, DocumentModel.Drawings.ChartDrawings.QuartileMethod>(value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Statistics? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Statistics? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Statistics();
      value.QuartileMethod = GetQuartileMethod(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Statistics? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Statistics, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
