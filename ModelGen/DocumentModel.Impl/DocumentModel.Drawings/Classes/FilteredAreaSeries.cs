namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FilteredAreaSeries Class.
/// </summary>
public class FilteredAreaSeriesImpl: ModelElementImpl, FilteredAreaSeries
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// AreaChartSeries.
  /// </summary>
  public AreaChartSeries1? AreaChartSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
