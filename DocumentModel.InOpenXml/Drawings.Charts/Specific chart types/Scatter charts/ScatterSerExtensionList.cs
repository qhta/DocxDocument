namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of scatter chart series extensions.
/// </summary>
[DataContract]
[XmlRoot("ScatterSerExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class ScatterSerExtensionList : ModelElementCollection<ScatterSerExtension>
{
}