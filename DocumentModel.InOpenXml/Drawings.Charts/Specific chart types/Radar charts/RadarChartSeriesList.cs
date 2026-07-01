namespace DocumentModel.Drawings.Charts;
/// <summary>
/// Collection of radar chart series, representing the individual data series displayed in a radar chart.
/// </summary>
[DataContract]
[XmlRoot("RadarChartSeriesList", Namespace = "DocumentModel.Drawings.Charts")]
public class RadarChartSeriesList : ModelElementCollection<RadarChartSeries>
{
}