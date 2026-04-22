namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class BorderBoxProperties
{
  public bool ShouldSerializeHideTop() => HideTop is not null;
  public bool ShouldSerializeHideBottom() => HideBottom is not null;
  public bool ShouldSerializeHideLeft() => HideLeft is not null;
  public bool ShouldSerializeHideRight() => HideRight is not null;
  public bool ShouldSerializeStrikeHorizontal() => StrikeHorizontal is not null;
  public bool ShouldSerializeStrikeVertical() => StrikeVertical is not null;
  public bool ShouldSerializeStrikeBottomLeftToTopRight() => StrikeBottomLeftToTopRight is not null;
  public bool ShouldSerializeStrikeTopLeftToBottomRight() => StrikeTopLeftToBottomRight is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
