namespace DocumentModel.Interop.Word;

public enum WdPasteOptions
{
  wdKeepSourceFormatting = unchecked((int)0),
  wdMatchDestinationFormatting = unchecked((int)1),
  wdKeepTextOnly = unchecked((int)2),
  wdUseDestinationStyles = unchecked((int)3)
}
