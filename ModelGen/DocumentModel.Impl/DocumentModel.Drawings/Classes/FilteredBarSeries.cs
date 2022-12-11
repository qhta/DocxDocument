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
  
  public FilteredBarSeriesImpl(): base() {}
  
  public FilteredBarSeriesImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// BarChartSeries.
  /// </summary>
  public BarChartSeries? BarChartSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
