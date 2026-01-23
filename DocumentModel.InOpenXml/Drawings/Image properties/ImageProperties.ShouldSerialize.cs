namespace DocumentModel.Drawings;

public partial class ImageProperties
{
  public bool ShouldSerializeImageLayer() => ImageLayer is not null;
  public bool ShouldSerializeBrightnessContrast() => BrightnessContrast is not null;
  public bool ShouldSerializeImageEffect() => ImageEffect is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
