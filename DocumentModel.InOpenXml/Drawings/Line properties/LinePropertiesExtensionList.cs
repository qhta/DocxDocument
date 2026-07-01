namespace DocumentModel.Drawings;
/// <summary>
///   Represents a collection of line properties extensions for future extensibility.
/// </summary>
[OpenXmlType(typeof(LinePropertiesExtension))]
[DataContract]
[XmlRoot("LinePropertiesExtensionList", Namespace = "DocumentModel.Drawings")]
public class LinePropertiesExtensionList : ModelElementCollection<LinePropertiesExtension, DXD.LinePropertiesExtensionList, DXD.LinePropertiesExtension>
{
}