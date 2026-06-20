namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class SchemeColor
{
  public bool ShouldSerializeIndex() => Index is not null;
  public bool ShouldSerializeTint() => Tint is not null;
  public bool ShouldSerializeShade() => Shade is not null;
}
