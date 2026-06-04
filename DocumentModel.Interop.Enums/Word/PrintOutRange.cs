namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a range to print.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdprintoutrange?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdPrintOutRange")]
public enum PrintOutRange
{
  /// <summary>
  /// The entire document.
  /// </summary>
  [WordInteropEnumValue("wdPrintAllDocument")]
  AllDocument = 0,
  /// <summary>
  /// The current selection.
  /// </summary>
  [WordInteropEnumValue("wdPrintSelection")]
  Selection = 1,
  /// <summary>
  /// The current page.
  /// </summary>
  [WordInteropEnumValue("wdPrintCurrentPage")]
  CurrentPage = 2,
  /// <summary>
  /// A specified range.
  /// </summary>
  [WordInteropEnumValue("wdPrintFromTo")]
  FromTo = 3,
  /// <summary>
  /// A specified range of pages.
  /// </summary>
  [WordInteropEnumValue("wdPrintRangeOfPages")]
  RangeOfPages = 4
}
