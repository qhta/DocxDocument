namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class FootnoteDocumentWideProperties
{
  public bool ShouldSerializeFootnotePosition() => FootnotePosition is not null && ShouldSerialize(FootnotePosition);
  public bool ShouldSerializeNumberingFormat() => NumberingFormat is not null && ShouldSerialize(NumberingFormat);
  public bool ShouldSerializeNumberingStart() => NumberingStart is not null && ShouldSerialize(NumberingStart);
  public bool ShouldSerializeNumberingRestart() => NumberingRestart is not null && ShouldSerialize(NumberingRestart);
  public bool ShouldSerializeFootnoteSeparators() => FootnoteSeparators is not null && ShouldSerialize(FootnoteSeparators);
}
