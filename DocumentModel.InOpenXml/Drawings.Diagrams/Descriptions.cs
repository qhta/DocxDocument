namespace DocumentModel.Drawings.Diagrams;
/// <summary>
/// Represents a collection of description elements.
/// </summary>
[DataContract]
[XmlRoot("Descriptions", Namespace = "DocumentModel.Drawings.Diagrams")]
public class Descriptions : ModelElementCollection<Description>
{
}