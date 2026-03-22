namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a filtered bar series for a chart, containing a reference to a bar chart series.
/// </summary>
[OpenXmlType(typeof(DXO13DC.FilteredBarSeries))]
public partial class FilteredBarSeries : ModelElement<DXO13DC.FilteredBarSeries>
{
  /// <summary>
  ///   Bar chart series associated with the filtered bar series.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DC.FilteredBarSeries.BarChartSeries))]
  public BarChartSeries? BarChartSeries { get => _BarChartSeries; set => UpdateField(ref _BarChartSeries, value, nameof(BarChartSeries)); }
  private BarChartSeries? _BarChartSeries;
}