namespace DocumentModel.Drawings;

public partial class LuminanceEffect
{
  public bool ShouldSerializeBrightness() => Brightness is not null;
  public bool ShouldSerializeContrast() => Contrast is not null;
}
