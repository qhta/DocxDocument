namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class Shading
{
  public bool ShouldSerializePattern() => Pattern is not null;
  public bool ShouldSerializeForegroundColor() => ForegroundColor is not null;
  public bool ShouldSerializeBackgroundColor() => BackgroundColor is not null;
}
