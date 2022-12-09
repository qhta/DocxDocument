namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FilteredScatterSeries Class.
/// </summary>
public class FilteredScatterSeriesImpl: ModelElementImpl, FilteredScatterSeries
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredScatterSeries? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredScatterSeries?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// ScatterChartSeries.
  /// </summary>
  public ScatterChartSeries2? ScatterChartSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
