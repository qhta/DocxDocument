namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class LuminanceEffect
{
  public bool ShouldSerializeBrightness() => Brightness is not null;
  public bool ShouldSerializeContrast() => Contrast is not null;
}
