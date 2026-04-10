namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of bubble chart series.
/// </summary>
[XmlRoot("BubbleChartSeriesList", Namespace = "DocumentModel.Drawings.Charts")]
public class BubbleChartSeriesList : ModelElementCollection<BubbleChartSeries>
{
}