namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class RgbColorHex
{
  public bool ShouldSerializeVal() => Value is not null;
  public bool ShouldSerializeTint() => Tint is not null;
  public bool ShouldSerializeShade() => Shade is not null;
}
