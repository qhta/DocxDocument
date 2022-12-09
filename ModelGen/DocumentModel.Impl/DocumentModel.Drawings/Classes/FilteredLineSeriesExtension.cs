namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FilteredLineSeriesExtension Class.
/// </summary>
public class FilteredLineSeriesExtensionImpl: ModelElementImpl, FilteredLineSeriesExtension
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// LineChartSeries.
  /// </summary>
  public LineChartSeries2? LineChartSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
