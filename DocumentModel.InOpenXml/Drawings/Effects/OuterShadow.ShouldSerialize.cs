namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class OuterShadow
{
  public bool ShouldSerializeBlurRadius() => BlurRadius is not null;
  public bool ShouldSerializeDistance() => Distance is not null;
  public bool ShouldSerializeDirection() => Direction is not null;
  public bool ShouldSerializeHorizontalRatio() => HorizontalRatio is not null;
  public bool ShouldSerializeVerticalRatio() => VerticalRatio is not null;
  public bool ShouldSerializeHorizontalSkew() => HorizontalSkew is not null;
  public bool ShouldSerializeVerticalSkew() => VerticalSkew is not null;
  public bool ShouldSerializeAlignment() => Alignment is not null;
  public bool ShouldSerializeRotateWithShape() => RotateWithShape is not null;
  public bool ShouldSerializeColor() => Color is not null;

}
