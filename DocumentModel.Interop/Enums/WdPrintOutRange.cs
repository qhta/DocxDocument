namespace DocumentModel.Interop.Word;

public enum WdPrintOutRange
{
  wdPrintAllDocument = unchecked((int)0),
  wdPrintSelection = unchecked((int)1),
  wdPrintCurrentPage = unchecked((int)2),
  wdPrintFromTo = unchecked((int)3),
  wdPrintRangeOfPages = unchecked((int)4)
}
