namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an extension for a 3D line chart, providing additional series extension capabilities.
/// </summary>
[OpenXmlType(typeof(DXDC.Line3DChartExtension))]
[XmlRoot("Line3DChartExtension", Namespace = "DocumentModel.Drawings.Charts")]
public partial class Line3DChartExtension : Extension<DXDC.Line3DChartExtension>
{
 /// <summary>
 ///   Filtered line series extension for the chart extension.
 /// </summary>
 [OpenXmlElement(typeof(DXO13DC.FilteredLineSeriesExtension))]
 public FilteredLineSeriesExtension? FilteredLineSeriesExtension { get => _FilteredLineSeriesExtension; set => UpdateField(ref _FilteredLineSeriesExtension, value, nameof(FilteredLineSeriesExtension)); }

 private FilteredLineSeriesExtension? _FilteredLineSeriesExtension;
}