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
  /// Places the operator before a line break, at the end of the line.
  /// </summary>
  Before = 0,
  /// <summary>
  /// Places the operator after a line break, at the beginning of the following line.
  /// </summary>
  After = 1,
  /// <summary>
  /// Repeats the operator before a line break at the end of the line and after a line break at the beginning of the
  /// following line.
  /// </summary>
  Repeat = 2
}
