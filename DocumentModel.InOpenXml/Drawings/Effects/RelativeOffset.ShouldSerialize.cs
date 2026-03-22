namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class RelativeOffset
{
  public bool ShouldSerializeOffsetX() => OffsetX is not null;
  public bool ShouldSerializeOffsetY() => OffsetY is not null;
}
