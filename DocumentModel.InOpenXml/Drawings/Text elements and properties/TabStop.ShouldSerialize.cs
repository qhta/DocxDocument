namespace DocumentModel.Drawings;

public partial class TabStop
{
  public bool ShouldSerializePosition() => Position is not null;
  public bool ShouldSerializeAlignment() => Alignment is not null;
}
