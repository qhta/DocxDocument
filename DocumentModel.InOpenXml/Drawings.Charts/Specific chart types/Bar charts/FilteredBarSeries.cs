namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a filtered bar series for a chart, containing a reference to a bar chart series.
/// </summary>
public class FilteredBarSeries: ModelElement<DXO13DC.FilteredBarSeries>
{
  /// <summary>
  ///   Bar chart series associated with the filtered bar series.
  /// </summary>
  public BarChartSeries? BarChartSeries { get; set; }
}