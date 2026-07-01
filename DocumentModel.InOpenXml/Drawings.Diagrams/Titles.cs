namespace DocumentModel.Drawings.Diagrams;
/// <summary>
/// Represents a collection of title elements.
/// </summary>
[DataContract]
[XmlRoot("Titles", Namespace = "DocumentModel.Drawings.Diagrams")]
public class Titles : ModelElementCollection<Title>
{
}