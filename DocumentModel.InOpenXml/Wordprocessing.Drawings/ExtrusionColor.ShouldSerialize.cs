namespace DocumentModel.Wordprocessing.Drawings;

public partial class ExtrusionColor
{
  public bool ShouldSerializeRgbColor() => RgbColor is not null;
  public bool ShouldSerializeSchemeColor() => SchemeColor is not null;
}
