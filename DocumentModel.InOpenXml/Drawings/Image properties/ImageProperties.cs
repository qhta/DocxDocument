namespace DocumentModel.Drawings;
/// <summary>
/// Represents image properties for a drawing element, including image layers, adjustments, effects, and extensions.
/// </summary>
[OpenXmlType(typeof(DXO10D.ImageProperties))]
public partial class ImageProperties : ModelElement<DXO10D.ImageProperties>, IExtendableElement
{
 /// <summary>
 /// Image layer, which defines the base image and its properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageProperties.ImageLayer))]
 [OpenXmlElement(typeof(DXO10D.ImageProperties))]
 public ImageLayer? ImageLayer { get => _ImageLayer; set => UpdateField(ref _ImageLayer, value, nameof(ImageLayer)); }

 private ImageLayer? _ImageLayer;
 /// <summary>
 /// Brightness and contrast adjustment for the image.
 /// </summary>
 [OpenXmlElement(typeof(DXO10D.ImageProperties))]
 public BrightnessContrast? BrightnessContrast { get => _BrightnessContrast; set => UpdateField(ref _BrightnessContrast, value, nameof(BrightnessContrast)); }

 private BrightnessContrast? _BrightnessContrast;
 /// <summary>
 /// Image effect applied to the image.
 /// </summary>
 [OpenXmlElement(typeof(DXO10D.ImageProperties))]
 public ImageEffect? ImageEffect { get => _ImageEffect; set => UpdateField(ref _ImageEffect, value, nameof(ImageEffect)); }

 private ImageEffect? _ImageEffect;
 /// <summary>
 /// List of visual effects applied to the image.
 /// </summary>
 [OpenXmlElement(typeof(DXO10D.ImageProperties))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

 private ExtensionList? _ExtensionList;
}