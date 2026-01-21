namespace DocumentModel.Wordprocessing;

public partial class EndnoteSeparator
{
  public bool ShouldSerializeEndnote() => Endnote is not null;
}
