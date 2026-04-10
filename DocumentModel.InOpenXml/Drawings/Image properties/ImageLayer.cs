namespace DocumentModel.Drawings;
/// <summary>
/// Represents an image layer, which includes an embedded image reference, a collection of image effects, and additional properties.
/// </summary>
[OpenXmlType(typeof(ImageEffect))]
[XmlRoot("ImageLayer", Namespace = "DocumentModel.Drawings")]
public partial class ImageLayer : ModelElementCollection<ImageEffect, DXO10D.ImageLayer, DXO10D.ImageEffect>, IExtendableElement
{
 /// <summary>
 /// Embedded image relationship ID.
 /// </summary>
 public string? Embed { get; set; }
 /// <summary>
 /// Name of the image layer.
 /// </summary>
 public string? Name { get; set; }
 /// <summary>
 /// List of image effects applied to the image layer.
 /// </summary>
 public ExtensionList? ExtensionList { get; set; }
}