namespace DocumentModel.Interop.Word;

public enum WdStyleSheetPrecedence
{
  wdStyleSheetPrecedenceLowest = unchecked((int)0),
  wdStyleSheetPrecedenceHighest = unchecked((int)1),
  wdStyleSheetPrecedenceLower = unchecked((int)-2),
  wdStyleSheetPrecedenceHigher = unchecked((int)-1)
}
