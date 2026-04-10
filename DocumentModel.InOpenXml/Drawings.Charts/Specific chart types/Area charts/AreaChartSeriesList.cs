namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of area chart series.
/// </summary>
[XmlRoot("AreaChartSeriesList", Namespace = "DocumentModel.Drawings.Charts")]
public class AreaChartSeriesList : ModelElementCollection<AreaChartSeries>
{
}