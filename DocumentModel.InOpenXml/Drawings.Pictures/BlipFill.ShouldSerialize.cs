namespace DocumentModel.Drawings.Pictures;

public partial class BlipFill
{
  public bool ShouldSerializeDpi() => Dpi is not null;
  public bool ShouldSerializeRotateWithShape() => RotateWithShape is not null;
  public bool ShouldSerializeBlip() => Blip is not null;
  public bool ShouldSerializeSourceRectangle() => SourceRectangle is not null;
  public bool ShouldSerializeTile() => Tile is not null;
  public bool ShouldSerializeStretch() => Stretch is not null;
}
