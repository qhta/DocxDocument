namespace DocumentModel.Drawings.Diagrams;
/// <summary>
/// Represents a collection of parameter elements used within a model.
/// </summary>
[DataContract]
[XmlRoot("Parameters", Namespace = "DocumentModel.Drawings.Diagrams")]
public class Parameters : ModelElementCollection<Parameter>
{
}