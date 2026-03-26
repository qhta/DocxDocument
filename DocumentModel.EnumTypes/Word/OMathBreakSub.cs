namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Office Word handles a subtraction operator that falls before a line break.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathbreaksub?view=office-pia` for Office interop details.
/// </remarks>
public enum OMathBreakSub
{
  /// <summary>
  /// Repeats a minus sign that ends before a line break at the beginning of the next line. Default.
  /// </summary>
  MinusMinus = 0,
  /// <summary>
  /// Inserts a plus sign at the end of the first line, before the line break, and a minus sign at the beginning of
  /// the following line, before the number.
  /// </summary>
  PlusMinus = 1,
  /// <summary>
  /// Inserts a minus sign at the end of the first line, before the line break, and a plus sign at the beginning of
  /// the following line, before the number.
  /// </summary>
  MinusPlus = 2
}
