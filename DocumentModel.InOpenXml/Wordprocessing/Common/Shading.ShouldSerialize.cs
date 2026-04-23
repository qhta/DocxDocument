namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Shading
{
  public bool ShouldSerializePattern() => Pattern is not null && ShouldSerialize(Pattern);
  public bool ShouldSerializeForegroundColor() => ForegroundColor is not null && ShouldSerialize(ForegroundColor);
  public bool ShouldSerializeBackgroundColor() => BackgroundColor is not null && ShouldSerialize(BackgroundColor);
}
