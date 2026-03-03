namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class ParagraphSpacing
{
  public bool ShouldSerializeBefore() => Before is not null;
  public bool ShouldSerializeAfter() => After is not null;
  public bool ShouldSerializeInterlines() => Interlines is not null;
}
