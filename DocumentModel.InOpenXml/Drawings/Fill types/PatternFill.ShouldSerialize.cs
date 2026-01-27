namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class PatternFill
{
  public bool ShouldSerializePreset() => Preset is not null;
  public bool ShouldSerializeForegroundColor() => ForegroundColor is not null;
  public bool ShouldSerializeBackgroundColor() => BackgroundColor is not null;
}
