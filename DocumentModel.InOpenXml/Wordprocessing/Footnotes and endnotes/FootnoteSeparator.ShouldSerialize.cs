namespace DocumentModel.Wordprocessing;

public partial class FootnoteSeparator
{
  public bool ShouldSerializeFootnote() => Footnote is not null;
}
