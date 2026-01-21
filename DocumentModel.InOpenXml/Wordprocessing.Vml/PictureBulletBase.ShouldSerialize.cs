namespace DocumentModel.Wordprocessing.Vml;

public partial class PictureBulletBase
{
  public bool ShouldSerializeGroup() => Group is not null;
  public bool ShouldSerializeImageFile() => ImageFile is not null;
  public bool ShouldSerializeLine() => Line is not null;
  public bool ShouldSerializeOval() => Oval is not null;
  public bool ShouldSerializePolyLine() => PolyLine is not null;
  public bool ShouldSerializeRectangle() => Rectangle is not null;
  public bool ShouldSerializeRoundRectangle() => RoundRectangle is not null;
  public bool ShouldSerializeShape() => Shape is not null;
  public bool ShouldSerializeShapeType() => ShapeType is not null;
}
