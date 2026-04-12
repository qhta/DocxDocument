namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class RgbColorModelPercentage
{
  public bool ShouldSerializeRed() => Red is not null;
  public bool ShouldSerializeGreen() => Green is not null;
  public bool ShouldSerializeBlue() => Blue is not null;
  public bool ShouldSerializeTint() => Tint is not null;
  public bool ShouldSerializeShade() => Shade is not null;
}
