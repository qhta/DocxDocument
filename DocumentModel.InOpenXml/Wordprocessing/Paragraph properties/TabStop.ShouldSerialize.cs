namespace DocumentModel.Wordprocessing;

public partial class TabStop
{
  public bool ShouldSerializeVal() => Val is not null;
  public bool ShouldSerializeLeader() => Leader is not null;
  public bool ShouldSerializePosition() => Position is not null;
}
