namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of pie chart series.
/// </summary>
[XmlRoot("PieChartSeriesList", Namespace = "DocumentModel.Drawings.Charts")]
public class PieChartSeriesList : ModelElementCollection<PieChartSeries>
{
}