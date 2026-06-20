namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class PresetColor
{
  public bool ShouldSerializeVal() => Index is not null;
  public bool ShouldSerializeTint() => Tint is not null;
  public bool ShouldSerializeShade() => Shade is not null;
}
