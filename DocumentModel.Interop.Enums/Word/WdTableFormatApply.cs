namespace DocumentModel.Interop.Word;

public enum WdTableFormatApply
{
  wdTableFormatApplyBorders = unchecked((int)1),
  wdTableFormatApplyShading = unchecked((int)2),
  wdTableFormatApplyFont = unchecked((int)4),
  wdTableFormatApplyColor = unchecked((int)8),
  wdTableFormatApplyAutoFit = unchecked((int)16),
  wdTableFormatApplyHeadingRows = unchecked((int)32),
  wdTableFormatApplyLastRow = unchecked((int)64),
  wdTableFormatApplyFirstColumn = unchecked((int)128),
  wdTableFormatApplyLastColumn = unchecked((int)256)
}
