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
  
}
