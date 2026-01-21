namespace DocumentModel.Drawings;

public partial class Reflection
{
  public bool ShouldSerializeBlurRadius() => BlurRadius is not null;
  public bool ShouldSerializeStartOpacity() => StartOpacity is not null;
  public bool ShouldSerializeStartPosition() => StartPosition is not null;
  public bool ShouldSerializeEndAlpha() => EndAlpha is not null;
  public bool ShouldSerializeEndPosition() => EndPosition is not null;
  public bool ShouldSerializeDistance() => Distance is not null;
  public bool ShouldSerializeDirection() => Direction is not null;
  public bool ShouldSerializeFadeDirection() => FadeDirection is not null;
  public bool ShouldSerializeHorizontalRatio() => HorizontalRatio is not null;
  public bool ShouldSerializeVerticalRatio() => VerticalRatio is not null;
  public bool ShouldSerializeHorizontalSkew() => HorizontalSkew is not null;
  public bool ShouldSerializeVerticalSkew() => VerticalSkew is not null;
  public bool ShouldSerializeAlignment() => Alignment is not null;
  public bool ShouldSerializeRotateWithShape() => RotateWithShape is not null;
}
