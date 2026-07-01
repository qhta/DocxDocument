namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of line chart series.
/// </summary>
[DataContract]
[XmlRoot("LineChartSeriesList", Namespace = "DocumentModel.Drawings.Charts")]
public class LineChartSeriesList : ModelElementCollection<LineChartSeries>
{
}