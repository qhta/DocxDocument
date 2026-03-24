namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies where Microsoft Office Word places binary operators when equations span two or more lines.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathbreakbin?view=office-pia` for Office interop details.
/// </remarks>
public enum WdOMathBreakBin
{
  /// <summary>
  /// Specifies where Microsoft Office Word places binary operators when equations span two or more lines.
  /// </summary>
  Before = 0,
  /// <summary>
  /// Specifies where Microsoft Office Word places binary operators when equations span two or more lines.
  /// </summary>
  After = 1,
  /// <summary>
  /// Repeats the operator before a line break at the end of the line and after a line break at the beginning of the
  /// following line.
  /// </summary>
  Repeat = 2
}
