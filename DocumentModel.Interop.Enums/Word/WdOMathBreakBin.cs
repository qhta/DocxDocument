namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies where Microsoft Office Word places binary operators when equations span two or more lines.
/// </summary>
public enum WdOMathBreakBin
{
  /// <summary>
  /// Specifies where Microsoft Office Word places binary operators when equations span two or more lines.
  /// </summary>
  wdOMathBreakBinBefore = unchecked((int)0),
  /// <summary>
  /// Specifies where Microsoft Office Word places binary operators when equations span two or more lines.
  /// </summary>
  wdOMathBreakBinAfter = unchecked((int)1),
  /// <summary>
  /// Repeats the operator before a line break at the end of the line and after a line break at the beginning of the
  /// following line.
  /// </summary>
  wdOMathBreakBinRepeat = unchecked((int)2)
}
