namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of specific chart types which can be contained in a plot area.
/// </summary>
[DataContract]
[XmlRoot("Charts", Namespace = "DocumentModel.Drawings.Charts")]
public class Charts : ElementCollection<AbstractChart>
{
}