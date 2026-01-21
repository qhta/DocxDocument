namespace DocumentModel.Drawings;

public partial class RelativeOffset
{
  public bool ShouldSerializeOffsetX() => OffsetX is not null;
  public bool ShouldSerializeOffsetY() => OffsetY is not null;
}
