namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of area chart series extensions.
/// </summary>
[DataContract]
[XmlRoot("AreaSerExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class AreaSerExtensionList : ModelElementCollection<AreaSerExtension>
{
}