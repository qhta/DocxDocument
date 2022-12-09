namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FilteredPieSeries Class.
/// </summary>
public class FilteredPieSeriesImpl: ModelElementImpl, FilteredPieSeries
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// PieChartSeries.
  /// </summary>
  public PieChartSeries2? PieChartSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
