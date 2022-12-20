namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the RadarChartExtension Class.
/// </summary>
public partial class RadarChartExtensionImpl: ModelElementImpl, RadarChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RadarChartExtensionImpl(): base() {}
  
  public RadarChartExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings.Charts.FilteredRadarSeries? FilteredRadarSeries
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredRadarSeries>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.FilteredRadarSeriesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredRadarSeries>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.FilteredRadarSeriesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
