namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a filtered scatter series for a chart, containing a reference to a scatter chart series.
/// </summary>
[OpenXmlType(typeof(DXO13DC.FilteredScatterSeries))]
[XmlRoot("FilteredScatterSeries", Namespace = "DocumentModel.Drawings.Charts")]
public partial class FilteredScatterSeries : ModelElement<DXO13DC.FilteredScatterSeries>
{
 /// <summary>
 ///   Scatter chart series associated with the filtered scatter series.
 /// </summary>
 [OpenXmlElement(typeof(DXO13DC.ScatterChartSeries))]
 [OpenXmlType(typeof(DXO13DC.ScatterChartSeries))]
 public ScatterChartSeries? ScatterChartSeries { get => _ScatterChartSeries; set => UpdateField(ref _ScatterChartSeries, value, nameof(ScatterChartSeries)); }
 private ScatterChartSeries? _ScatterChartSeries;
}