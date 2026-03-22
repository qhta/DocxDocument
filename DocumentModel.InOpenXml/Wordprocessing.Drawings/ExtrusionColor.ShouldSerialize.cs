namespace DocumentModel.Wordprocessing.Drawings;
#pragma warning disable CS1591
public partial class ExtrusionColor
{
  public bool ShouldSerializeRgbColor() => RgbColor is not null;
  public bool ShouldSerializeSchemeColor() => SchemeColor is not null;
}
