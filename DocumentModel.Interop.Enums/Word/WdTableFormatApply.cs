namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how table formatting should be applied.
/// </summary>
public enum WdTableFormatApply
{
  /// <summary>
  /// Borders.
  /// </summary>
  wdTableFormatApplyBorders = unchecked((int)1),
  /// <summary>
  /// Shading.
  /// </summary>
  wdTableFormatApplyShading = unchecked((int)2),
  /// <summary>
  /// Font.
  /// </summary>
  wdTableFormatApplyFont = unchecked((int)4),
  /// <summary>
  /// Color.
  /// </summary>
  wdTableFormatApplyColor = unchecked((int)8),
  /// <summary>
  /// AutoFit.
  /// </summary>
  wdTableFormatApplyAutoFit = unchecked((int)16),
  /// <summary>
  /// Apply AutoFormat to heading rows.
  /// </summary>
  wdTableFormatApplyHeadingRows = unchecked((int)32),
  /// <summary>
  /// Apply AutoFormat to last row.
  /// </summary>
  wdTableFormatApplyLastRow = unchecked((int)64),
  /// <summary>
  /// Apply AutoFormat to first column.
  /// </summary>
  wdTableFormatApplyFirstColumn = unchecked((int)128),
  /// <summary>
  /// Apply AutoFormat to last column.
  /// </summary>
  wdTableFormatApplyLastColumn = unchecked((int)256)
}
