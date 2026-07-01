namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
/// Represents a collection of data point elements.
/// </summary>
[DataContract]
[XmlRoot("DataPoints", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class DataPoints : ModelElementCollection<DataPoint>
{
}