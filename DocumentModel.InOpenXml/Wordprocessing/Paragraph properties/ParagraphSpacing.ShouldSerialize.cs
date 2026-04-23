namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class ParagraphSpacing
{
  public bool ShouldSerializeVal() => Val is not null && ShouldSerialize(Val);
  public bool ShouldSerializeLines() => Lines is not null && ShouldSerialize(Lines);
  public bool ShouldSerializeAutoSpacing() => AutoSpacing is not null;
}
