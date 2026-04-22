namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a filtered radar series for a chart, containing a reference to a radar chart series.
/// </summary>
[OpenXmlType(typeof(DXO13DC.FilteredRadarSeries))]
[XmlRoot("FilteredRadarSeries", Namespace = "DocumentModel.Drawings.Charts")]
public partial class FilteredRadarSeries : ModelElement<DXO13DC.FilteredRadarSeries>
{
 /// <summary>
 ///   Radar chart series associated with the filtered radar series.
 /// </summary>
 [OpenXmlElement(typeof(DXO13DC.RadarChartSeries))]
 [OpenXmlType(typeof(DXO13DC.RadarChartSeries))]
 public RadarChartSeries? RadarChartSeries { get => _RadarChartSeries; set => UpdateField(ref _RadarChartSeries, value, nameof(RadarChartSeries)); }
 private RadarChartSeries? _RadarChartSeries;
}