namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class Tile
{
  public bool ShouldSerializeHorizontalOffset() => HorizontalOffset is not null;
  public bool ShouldSerializeVerticalOffset() => VerticalOffset is not null;
  public bool ShouldSerializeHorizontalRatio() => HorizontalRatio is not null;
  public bool ShouldSerializeVerticalRatio() => VerticalRatio is not null;
  public bool ShouldSerializeFlip() => Flip is not null;
  public bool ShouldSerializeAlignment() => Alignment is not null;
}
