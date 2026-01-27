namespace DocumentModel.Wordprocessing.Drawings;

#pragma warning disable CS1591

public partial class Reflection
{
  public bool ShouldSerializeBlurRadius() => BlurRadius is not null;
  public bool ShouldSerializeStartingOpacity() => StartingOpacity is not null;
  public bool ShouldSerializeStartPosition() => StartPosition is not null;
  public bool ShouldSerializeEndingOpacity() => EndingOpacity is not null;
  public bool ShouldSerializeEndPosition() => EndPosition is not null;
  public bool ShouldSerializeDistanceFromText() => DistanceFromText is not null;
  public bool ShouldSerializeDirectionAngle() => DirectionAngle is not null;
  public bool ShouldSerializeFadeDirection() => FadeDirection is not null;
  public bool ShouldSerializeHorizontalScalingFactor() => HorizontalScalingFactor is not null;
  public bool ShouldSerializeVerticalScalingFactor() => VerticalScalingFactor is not null;
  public bool ShouldSerializeHorizontalSkewAngle() => HorizontalSkewAngle is not null;
  public bool ShouldSerializeVerticalSkewAngle() => VerticalSkewAngle is not null;
  public bool ShouldSerializeAlignment() => Alignment is not null;
}
