namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class EndnoteDocumentWideProperties
{
  public bool ShouldSerializeEndnotePosition() => EndnotePosition is not null && ShouldSerialize(EndnotePosition);
  public bool ShouldSerializeNumberingFormat() => NumberingFormat is not null && ShouldSerialize(NumberingFormat);
  public bool ShouldSerializeNumberingStart() => NumberingStart is not null && ShouldSerialize(NumberingStart);
  public bool ShouldSerializeNumberingRestart() => NumberingRestart is not null && ShouldSerialize(NumberingRestart);
  public bool ShouldSerializeEndnoteSeparators() => EndnoteSeparators is not null && ShouldSerialize(EndnoteSeparators);
}
