namespace DocumentModel.Drawings;
/// <summary>
///   Represents a collection of shape properties extensions for additional or future extensibility.
/// </summary>
[OpenXmlType(typeof(ShapePropertiesExtension))]
[DataContract]
[XmlRoot("ShapePropertiesExtensionList", Namespace = "DocumentModel.Drawings")]
public class ShapePropertiesExtensionList : ElementCollection<ShapePropertiesExtension>
{
}