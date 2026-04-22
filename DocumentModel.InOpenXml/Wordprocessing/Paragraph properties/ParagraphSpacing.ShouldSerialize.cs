namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class ParagraphSpacing
{
  public bool ShouldSerializeVal() => Val is not null;
  public bool ShouldSerializeLines() => Lines is not null;
  public bool ShouldSerializeAutoSpacing() => AutoSpacing is not null;
}
