namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of scatter chart series.
/// </summary>
[XmlRoot("ScatterChartSeriesList", Namespace = "DocumentModel.Drawings.Charts")]
public class ScatterChartSeriesList : ModelElementCollection<ScatterChartSeries>
{
}