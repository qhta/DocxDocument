namespace DocumentModel.Drawings;

public partial class BrightnessContrast
{
  public bool ShouldSerializeBright() => Bright is not null;
  public bool ShouldSerializeContrast() => Contrast is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
