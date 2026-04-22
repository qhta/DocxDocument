namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a filtered pie series for a chart, containing a reference to a pie chart series.
/// </summary>
[OpenXmlType(typeof(DXO13DC.FilteredPieSeries))]
[XmlRoot("FilteredPieSeries", Namespace = "DocumentModel.Drawings.Charts")]
public partial class FilteredPieSeries : ModelElement<DXO13DC.FilteredPieSeries>
{
 /// <summary>
 ///   Pie chart series associated with the filtered pie series.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13DC.FilteredPieSeries.PieChartSeries))]
 [OpenXmlType(typeof(DXO13DC.PieChartSeries))]
 public PieChartSeries? PieChartSeries { get => _PieChartSeries; set => UpdateField(ref _PieChartSeries, value, nameof(PieChartSeries)); }
 private PieChartSeries? _PieChartSeries;
}