namespace DocumentModel.Interop.Word;

public enum WdRecoveryType
{
  wdPasteDefault = unchecked((int)0),
  wdSingleCellText = unchecked((int)5),
  wdSingleCellTable = unchecked((int)6),
  wdListContinueNumbering = unchecked((int)7),
  wdListRestartNumbering = unchecked((int)8),
  wdTableAppendTable = unchecked((int)10),
  wdTableInsertAsRows = unchecked((int)11),
  wdTableOriginalFormatting = unchecked((int)12),
  wdChartPicture = unchecked((int)13),
  wdChart = unchecked((int)14),
  wdChartLinked = unchecked((int)15),
  wdFormatOriginalFormatting = unchecked((int)16),
  wdUseDestinationStylesRecovery = unchecked((int)19),
  wdFormatSurroundingFormattingWithEmphasis = unchecked((int)20),
  wdFormatPlainText = unchecked((int)22),
  wdTableOverwriteCells = unchecked((int)23),
  wdListCombineWithExistingList = unchecked((int)24),
  wdListDontMerge = unchecked((int)25)
}
