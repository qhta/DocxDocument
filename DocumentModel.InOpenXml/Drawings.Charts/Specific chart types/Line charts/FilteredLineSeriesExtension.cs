namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an extension for a filtered line series, containing a reference to a line chart series.
/// </summary>
[OpenXmlType(typeof(DXO13DC.FilteredLineSeriesExtension))]
[DataContract]
[XmlRoot("FilteredLineSeriesExtension", Namespace = "DocumentModel.Drawings.Charts")]
public partial class FilteredLineSeriesExtension : Extension<DXO13DC.FilteredLineSeriesExtension>
{
 /// <summary>
 ///   Line chart series associated with the filtered line series extension.
 /// </summary>
 [OpenXmlType(typeof(DXO13DC.LineChartSeries))]
 public LineChartSeries? LineChartSeries { get => _LineChartSeries; set => UpdateField(ref _LineChartSeries, value, nameof(LineChartSeries)); }
 private LineChartSeries? _LineChartSeries;
}