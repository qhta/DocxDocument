namespace DocumentModel.Wordprocessing.Drawings;

public partial class Shading
{
  public bool ShouldSerializePattern() => Pattern is not null;
  public bool ShouldSerializeForegroundColor() => ForegroundColor is not null;
  public bool ShouldSerializeBackgroundColor() => BackgroundColor is not null;
}
