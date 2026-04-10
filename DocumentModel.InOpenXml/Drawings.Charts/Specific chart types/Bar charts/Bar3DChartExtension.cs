namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an extension for a 3D bar chart, providing additional series filtering and metadata.
/// </summary>
[OpenXmlType(typeof(DXDC.Bar3DChartExtension))]
[XmlRoot("Bar3DChartExtension", Namespace = "DocumentModel.Drawings.Charts")]
public partial class Bar3DChartExtension : Extension<DXDC.Bar3DChartExtension>
{
 /// <summary>
 ///   Filtered bar series for the chart extension.
 /// </summary>
 public FilteredBarSeries? FilteredBarSeries { get => _FilteredBarSeries; set => UpdateField(ref _FilteredBarSeries, value, nameof(FilteredBarSeries)); }

 private FilteredBarSeries? _FilteredBarSeries;
}