namespace DocumentModel.Drawings;
/// <summary>
/// Represents a collection of extensions specific to BLIP (Binary Large Image or Picture) elements
/// in DrawingML. These extensions enable enhanced image features, modern image formats, and advanced
/// image processing capabilities while maintaining backward compatibility with older Office versions.
/// </summary>
[OpenXmlType(typeof(BlipExtension))]
[XmlRoot("BlipExtensionList", Namespace = "DocumentModel.Drawings")]
public class BlipExtensionList : ElementCollection<BlipExtension>
// DXD.BlipExtensionList, DXD.BlipExtension>
{
}