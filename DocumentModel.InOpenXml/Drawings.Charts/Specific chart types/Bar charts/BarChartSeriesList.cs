namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of bar chart series.
/// </summary>
[XmlRoot("BarChartSeriesList", Namespace = "DocumentModel.Drawings.Charts")]
public class BarChartSeriesList : ModelElementCollection<BarChartSeries>
{
}