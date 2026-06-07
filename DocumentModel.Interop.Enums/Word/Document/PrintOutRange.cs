namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a range to print.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdprintoutrange?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdPrintOutRange")]
public enum PrintOutRange
{
  /// <summary>
  /// The entire document.
  /// </summary>
  [InteropEnumValue("wdPrintAllDocument")]
  AllDocument = 0,
  /// <summary>
  /// The current selection.
  /// </summary>
  [InteropEnumValue("wdPrintSelection")]
  Selection = 1,
  /// <summary>
  /// The current page.
  /// </summary>
  [InteropEnumValue("wdPrintCurrentPage")]
  CurrentPage = 2,
  /// <summary>
  /// A specified range.
  /// </summary>
  [InteropEnumValue("wdPrintFromTo")]
  FromTo = 3,
  /// <summary>
  /// A specified range of pages.
  /// </summary>
  [InteropEnumValue("wdPrintRangeOfPages")]
  RangeOfPages = 4
}
