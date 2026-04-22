namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an extension for a radar chart, providing additional series filtering capabilities.
/// </summary>
[OpenXmlType(typeof(DXDC.RadarChartExtension))]
[XmlRoot("RadarChartExtension", Namespace = "DocumentModel.Drawings.Charts")]
public partial class RadarChartExtension : Extension<DXDC.RadarChartExtension>
{
 /// <summary>
 ///   Filtered radar series for the chart extension.
 /// </summary>
 [OpenXmlElement(typeof(DXO13DC.FilteredRadarSeries))]
 public FilteredRadarSeries? FilteredRadarSeries { get => _FilteredRadarSeries; set => UpdateField(ref _FilteredRadarSeries, value, nameof(FilteredRadarSeries)); }
 private FilteredRadarSeries? _FilteredRadarSeries;
}