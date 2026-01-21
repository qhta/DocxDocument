namespace DocumentModel.Wordprocessing;

public partial class ParagraphSpacing
{
  public bool ShouldSerializeBefore() => Before is not null;
  public bool ShouldSerializeAfter() => After is not null;
  public bool ShouldSerializeBetween() => Between is not null;
}
