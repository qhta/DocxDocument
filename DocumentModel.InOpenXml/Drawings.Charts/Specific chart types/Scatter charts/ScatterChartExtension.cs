namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an extension for a scatter chart, providing additional series filtering capabilities.
/// </summary>
[OpenXmlType(typeof(DXDC.ScatterChartExtension))]
[XmlRoot("ScatterChartExtension", Namespace = "DocumentModel.Drawings.Charts")]
public partial class ScatterChartExtension : Extension<DXDC.ScatterChartExtension>
{
 /// <summary>
 ///   Filtered scatter series for the chart extension.
 /// </summary>
 [OpenXmlElement(typeof(DXO13DC.FilteredScatterSeries))]
 public FilteredScatterSeries? FilteredScatterSeries { get => _FilteredScatterSeries; set => UpdateField(ref _FilteredScatterSeries, value, nameof(FilteredScatterSeries)); }

 private FilteredScatterSeries? _FilteredScatterSeries;
}