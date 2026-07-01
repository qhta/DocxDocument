namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of bubble chart series extensions.
/// </summary>
[DataContract]
[XmlRoot("BubbleSerExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class BubbleSerExtensionList : ModelElementCollection<BubbleSerExtension>
{
}