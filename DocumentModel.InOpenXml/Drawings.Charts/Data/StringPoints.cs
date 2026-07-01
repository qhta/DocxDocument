namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of string points in a chart.
///   Each point contains a string value used for categories or labels in the chart.
/// </summary>
[DataContract]
[XmlRoot("StringPoints", Namespace = "DocumentModel.Drawings.Charts")]
public class StringPoints : ModelElementCollection<StringPoint>
{
}