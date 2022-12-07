namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Statistics Class.
/// </summary>
public class StatisticsImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Statistics>, Statistics
{
  /// <summary>
  /// quartileMethod, this property is only available in Office 2016 and later.
  /// </summary>
  public QuartileMethod? QuartileMethod
  {
    get => (QuartileMethod?)OpenXmlElement?.QuartileMethod?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.QuartileMethod = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod?)value;
    }
  }
  
}
