namespace DocumentModel.Drawings;

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
  
  /// <summary>
  /// RadarChartSeries.
  /// </summary>
  public RadarChartSeries2? RadarChartSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
