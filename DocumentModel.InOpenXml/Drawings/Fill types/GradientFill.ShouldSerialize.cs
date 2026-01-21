namespace DocumentModel.Drawings;

public partial class GradientFill
{
  public bool ShouldSerializeFlip() => Flip is not null;
  public bool ShouldSerializeRotateWithShape() => RotateWithShape is not null;
  public bool ShouldSerializeGradientStopList() => GradientStopList is not null;
  public bool ShouldSerializeTileRectangle() => TileRectangle is not null;
}
