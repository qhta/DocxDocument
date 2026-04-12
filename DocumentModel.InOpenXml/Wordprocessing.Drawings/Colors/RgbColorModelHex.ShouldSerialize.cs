namespace DocumentModel.Wordprocessing.Drawings;

#pragma warning disable CS1591

public partial class RgbColorModelHex
{
  public bool ShouldSerializeVal() => Val is not null;
  public bool ShouldSerializeTint() => Tint is not null;
  public bool ShouldSerializeShade() => Shade is not null;
}
