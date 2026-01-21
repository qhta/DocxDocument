namespace DocumentModel.Wordprocessing.Drawings;

public partial class ContourColor
{
  public bool ShouldSerializeRgbColor() => RgbColor is not null;
  public bool ShouldSerializeSchemeColor() => SchemeColor is not null;
}
