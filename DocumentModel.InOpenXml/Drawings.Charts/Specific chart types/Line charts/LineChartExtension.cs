namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an extension for a line chart, providing additional series extension capabilities.
/// </summary>
[OpenXmlType(typeof(DXDC.LineChartExtension))]
[XmlRoot("LineChartExtension", Namespace = "DocumentModel.Drawings.Charts")]
public partial class LineChartExtension : Extension<DXDC.LineChartExtension>
{
 /// <summary>
 ///   Filtered line series extension for the chart extension.
 /// </summary>
 [OpenXmlElement(typeof(DXO13DC.FilteredLineSeriesExtension))]
 public FilteredLineSeriesExtension? FilteredLineSeriesExtension { get => _FilteredLineSeriesExtension; set => UpdateField(ref _FilteredLineSeriesExtension, value, nameof(FilteredLineSeriesExtension)); }
 private FilteredLineSeriesExtension? _FilteredLineSeriesExtension;
}