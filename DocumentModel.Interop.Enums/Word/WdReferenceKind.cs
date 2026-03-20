namespace DocumentModel.Interop.Word;

public enum WdReferenceKind
{
  wdEntireCaption = unchecked((int)2),
  wdOnlyLabelAndNumber = unchecked((int)3),
  wdOnlyCaptionText = unchecked((int)4),
  wdFootnoteNumber = unchecked((int)5),
  wdEndnoteNumber = unchecked((int)6),
  wdPageNumber = unchecked((int)7),
  wdPosition = unchecked((int)15),
  wdFootnoteNumberFormatted = unchecked((int)16),
  wdEndnoteNumberFormatted = unchecked((int)17),
  wdNumberFullContext = unchecked((int)-4),
  wdNumberNoContext = unchecked((int)-3),
  wdNumberRelativeContext = unchecked((int)-2),
  wdContentText = unchecked((int)-1)
}
