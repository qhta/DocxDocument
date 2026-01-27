namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TabStop
{
  public bool ShouldSerializeVal() => Val is not null;
  public bool ShouldSerializeLeader() => Leader is not null;
  public bool ShouldSerializePosition() => Position is not null;
}
