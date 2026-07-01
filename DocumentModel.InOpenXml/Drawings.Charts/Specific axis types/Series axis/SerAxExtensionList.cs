namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of series axis extensions.
/// </summary>
[DataContract]
[XmlRoot("SerAxExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class SerAxExtensionList : ModelElementCollection<SerAxExtension>
{
}