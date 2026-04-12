namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class HslColor
{
  public bool ShouldSerializeVal() => HueValue is not null;
  public bool ShouldSerializeTint() => Tint is not null;
  public bool ShouldSerializeShade() => Shade is not null;
}
