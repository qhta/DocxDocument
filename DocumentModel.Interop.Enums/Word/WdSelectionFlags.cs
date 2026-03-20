namespace DocumentModel.Interop.Word;

public enum WdSelectionFlags
{
  wdSelStartActive = unchecked((int)1),
  wdSelAtEOL = unchecked((int)2),
  wdSelOvertype = unchecked((int)4),
  wdSelActive = unchecked((int)8),
  wdSelReplace = unchecked((int)16)
}
