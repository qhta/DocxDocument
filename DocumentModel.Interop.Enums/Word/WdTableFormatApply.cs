namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how table formatting should be applied.
/// </summary>
public enum WdTableFormatApply
{
  /// <summary>
  /// Borders.
  /// </summary>
  Borders = unchecked((int)1),
  /// <summary>
  /// Shading.
  /// </summary>
  Shading = unchecked((int)2),
  /// <summary>
  /// Font.
  /// </summary>
  Font = unchecked((int)4),
  /// <summary>
  /// Color.
  /// </summary>
  Color = unchecked((int)8),
  /// <summary>
  /// AutoFit.
  /// </summary>
  AutoFit = unchecked((int)16),
  /// <summary>
  /// Apply AutoFormat to heading rows.
  /// </summary>
  HeadingRows = unchecked((int)32),
  /// <summary>
  /// Apply AutoFormat to last row.
  /// </summary>
  LastRow = unchecked((int)64),
  /// <summary>
  /// Apply AutoFormat to first column.
  /// </summary>
  FirstColumn = unchecked((int)128),
  /// <summary>
  /// Apply AutoFormat to last column.
  /// </summary>
  LastColumn = unchecked((int)256)
}
