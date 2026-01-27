namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class EndnoteSeparator
{
  public bool ShouldSerializeEndnote() => Endnote is not null;
}
