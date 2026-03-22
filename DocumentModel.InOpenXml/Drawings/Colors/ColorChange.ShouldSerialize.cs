namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class ColorChange
{
  public bool ShouldSerializeUseAlpha() => UseAlpha is not null;
  public bool ShouldSerializeColorFrom() => ColorFrom is not null;
  public bool ShouldSerializeColorTo() => ColorTo is not null;
}
