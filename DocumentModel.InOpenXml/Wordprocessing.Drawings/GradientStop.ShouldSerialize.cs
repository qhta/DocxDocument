namespace DocumentModel.Wordprocessing.Drawings;

public partial class GradientStop
{
  public bool ShouldSerializeStopPosition() => StopPosition is not null;
  public bool ShouldSerializeRgbColor() => RgbColor is not null;
  public bool ShouldSerializeSchemeColor() => SchemeColor is not null;
}
