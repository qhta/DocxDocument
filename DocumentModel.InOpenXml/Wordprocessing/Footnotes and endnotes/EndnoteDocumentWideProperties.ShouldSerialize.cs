namespace DocumentModel.Wordprocessing;

public partial class EndnoteDocumentWideProperties
{
  public bool ShouldSerializeEndnotePosition() => EndnotePosition is not null;
  public bool ShouldSerializeNumberingFormat() => NumberingFormat is not null;
  public bool ShouldSerializeNumberingStart() => NumberingStart is not null;
  public bool ShouldSerializeNumberingRestart() => NumberingRestart is not null;
  public bool ShouldSerializeEndnoteSeparators() => EndnoteSeparators is not null;
}
