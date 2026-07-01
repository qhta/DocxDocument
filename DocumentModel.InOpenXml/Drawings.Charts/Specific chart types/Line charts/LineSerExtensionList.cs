namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of line chart series extensions.
/// </summary>
[DataContract]
[XmlRoot("LineSerExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class LineSerExtensionList : ModelElementCollection<LineSerExtension>
{
}