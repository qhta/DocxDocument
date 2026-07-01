namespace DocumentModel.Vml;
/// <summary>
/// It is a collection of Relation elements.
/// </summary>
[DataContract]
[XmlRoot("Relations", Namespace = "DocumentModel.Vml")]
public class Relations : ElementCollection<Relation>
{
}