namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the Statistics Class.
/// </summary>
public class StatisticsImpl: ModelElementImpl, Statistics
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Statistics? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Statistics?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StatisticsImpl(): base() {}
  
  public StatisticsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Statistics openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// quartileMethod, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.QuartileMethod? QuartileMethod
  {
    get => (DocumentModel.Drawings16.Charts.QuartileMethod?)OpenXmlElement?.QuartileMethod?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.QuartileMethod = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod?)value;
    }
  }
  
}
