namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an extension for a bar chart, providing additional series filtering capabilities.
/// </summary>
[OpenXmlType(typeof(DXDC.BarChartExtension))]
[XmlRoot("BarChartExtension", Namespace = "DocumentModel.Drawings.Charts")]
public partial class BarChartExtension : Extension<DXDC.BarChartExtension>
{
 /// <summary>
 ///   Filtered bar series for the chart extension.
 /// </summary>
 [OpenXmlElement(typeof(DXO13DC.FilteredBarSeries))]
 public FilteredBarSeries? FilteredBarSeries { get => _FilteredBarSeries; set => UpdateField(ref _FilteredBarSeries, value, nameof(FilteredBarSeries)); }
 private FilteredBarSeries? _FilteredBarSeries;
}