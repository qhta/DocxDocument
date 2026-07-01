namespace DocumentModel.Drawings;
/// <summary>
///   Represents a collection of hyperlink extension elements for future extensibility in drawing objects.
/// </summary>
[OpenXmlType(typeof(DXD.HyperlinkExtension))]
[DataContract]
[XmlRoot("HyperlinkExtensionList", Namespace = "DocumentModel.Drawings")]
public class HyperlinkExtensionList : ModelElementCollection<HyperlinkExtension, DXD.HyperlinkExtensionList, DXD.HyperlinkExtension>
{
}