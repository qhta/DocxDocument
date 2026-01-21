namespace DocumentModel.Wordprocessing;

public partial class SpacingBeforeOrAfter
{
  public bool ShouldSerializeVal() => Val is not null;
  public bool ShouldSerializeLines() => Lines is not null;
  public bool ShouldSerializeAutoSpacing() => AutoSpacing is not null;
}
