namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the FilteredRadarSeries Class.
/// </summary>
public class FilteredRadarSeriesImpl: ModelElementImpl, FilteredRadarSeries
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredRadarSeries? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredRadarSeries?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FilteredRadarSeriesImpl(): base() {}
  
  public FilteredRadarSeriesImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredRadarSeries openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// RadarChartSeries.
  /// </summary>
  public DocumentModel.Drawings.Charts.RadarChartSeries3? RadarChartSeries
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.RadarChartSeries>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.RadarChartSeries3Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.RadarChartSeries>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.RadarChartSeries3Impl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
