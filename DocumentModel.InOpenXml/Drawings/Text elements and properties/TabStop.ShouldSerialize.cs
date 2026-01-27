namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class TabStop
{
  public bool ShouldSerializePosition() => Position is not null;
  public bool ShouldSerializeAlignment() => Alignment is not null;
}
