namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class FootnoteSeparator
{
  public bool ShouldSerializeFootnote() => Footnote is not null && ShouldSerialize(Footnote);
}
