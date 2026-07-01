namespace DocumentModel.Vml;
/// <summary>
/// Represents a collection of Proxy elements.
/// </summary>
[DataContract]
[XmlRoot("Proxies", Namespace = "DocumentModel.Vml")]
public class Proxies : ElementCollection<Proxy>
{
}