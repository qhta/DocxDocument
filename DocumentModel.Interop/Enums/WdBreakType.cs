namespace DocumentModel.Interop.Word;

public enum WdBreakType
{
  wdSectionBreakNextPage = unchecked((int)2),
  wdSectionBreakContinuous = unchecked((int)3),
  wdSectionBreakEvenPage = unchecked((int)4),
  wdSectionBreakOddPage = unchecked((int)5),
  wdLineBreak = unchecked((int)6),
  wdPageBreak = unchecked((int)7),
  wdColumnBreak = unchecked((int)8),
  wdLineBreakClearLeft = unchecked((int)9),
  wdLineBreakClearRight = unchecked((int)10),
  wdTextWrappingBreak = unchecked((int)11)
}
