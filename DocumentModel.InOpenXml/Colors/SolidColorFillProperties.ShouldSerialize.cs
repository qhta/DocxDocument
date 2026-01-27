namespace DocumentModel;

#pragma warning disable CS1591

public partial class SolidColorFillProperties
{
  public bool ShouldSerializeRgbColor() => RgbColor is not null;
  public bool ShouldSerializeSchemeColor() => SchemeColor is not null;
}
