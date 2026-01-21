namespace DocumentModel.Wordprocessing.Drawings;

public partial class Shadow2
{
  public bool ShouldSerializeBlurRadius() => BlurRadius is not null;
  public bool ShouldSerializeDistanceFromText() => DistanceFromText is not null;
  public bool ShouldSerializeDirectionAngle() => DirectionAngle is not null;
  public bool ShouldSerializeHorizontalScalingFactor() => HorizontalScalingFactor is not null;
  public bool ShouldSerializeVerticalScalingFactor() => VerticalScalingFactor is not null;
  public bool ShouldSerializeHorizontalSkewAngle() => HorizontalSkewAngle is not null;
  public bool ShouldSerializeVerticalSkewAngle() => VerticalSkewAngle is not null;
  public bool ShouldSerializeAlignment() => Alignment is not null;
  public bool ShouldSerializeRgbColor() => RgbColor is not null;
  public bool ShouldSerializeSchemeColor() => SchemeColor is not null;
}
