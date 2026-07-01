namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of area chart series.
/// </summary>
[DataContract]
[XmlRoot("AreaChartSeriesList", Namespace = "DocumentModel.Drawings.Charts")]
public class AreaChartSeriesList : ModelElementCollection<AreaChartSeries>
{
}