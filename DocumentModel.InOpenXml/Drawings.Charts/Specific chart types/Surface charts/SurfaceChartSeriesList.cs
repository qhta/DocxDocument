namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of surface chart series.
/// </summary>
[DataContract]
[XmlRoot("SurfaceChartSeriesList", Namespace = "DocumentModel.Drawings.Charts")]
public class SurfaceChartSeriesList : ModelElementCollection<SurfaceChartSeries>
{
}