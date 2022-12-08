namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FilteredBarSeries Class.
/// </summary>
public class FilteredBarSeriesImpl: ModelElementImpl, FilteredBarSeries
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// BarChartSeries.
  /// </summary>
  public BarChartSeries1? BarChartSeries
  {
    get;
    set;
  }
  
}
