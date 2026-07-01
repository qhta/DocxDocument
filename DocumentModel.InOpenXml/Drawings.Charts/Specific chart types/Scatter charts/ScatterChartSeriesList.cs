namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of scatter chart series.
/// </summary>
[DataContract]
[XmlRoot("ScatterChartSeriesList", Namespace = "DocumentModel.Drawings.Charts")]
public class ScatterChartSeriesList : ModelElementCollection<ScatterChartSeries>
{
}