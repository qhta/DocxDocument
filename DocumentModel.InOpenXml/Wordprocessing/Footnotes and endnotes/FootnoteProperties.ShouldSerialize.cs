namespace DocumentModel.Wordprocessing;

public partial class FootnoteProperties
{
  public bool ShouldSerializeFootnotePosition() => FootnotePosition is not null;
  public bool ShouldSerializeNumberingFormat() => NumberingFormat is not null;
  public bool ShouldSerializeNumberingStart() => NumberingStart is not null;
  public bool ShouldSerializeNumberingRestart() => NumberingRestart is not null;
}
