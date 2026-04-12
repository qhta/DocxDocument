namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class SystemColor
{
  public bool ShouldSerializeVal() => Val is not null;
  public bool ShouldSerializeLastColor() => LastColor is not null;
  public bool ShouldSerializeTint() => Tint is not null;
  public bool ShouldSerializeShade() => Shade is not null;
}
