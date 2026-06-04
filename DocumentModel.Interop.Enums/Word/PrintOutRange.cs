namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a range to print.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdprintoutrange?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdPrintOutRange))]
public enum PrintOutRange
{
  /// <summary>
  /// The entire document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPrintOutRange.wdPrintAllDocument))]
  AllDocument = 0,
  /// <summary>
  /// The current selection.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPrintOutRange.wdPrintSelection))]
  Selection = 1,
  /// <summary>
  /// The current page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPrintOutRange.wdPrintCurrentPage))]
  CurrentPage = 2,
  /// <summary>
  /// A specified range.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPrintOutRange.wdPrintFromTo))]
  FromTo = 3,
  /// <summary>
  /// A specified range of pages.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPrintOutRange.wdPrintRangeOfPages))]
  RangeOfPages = 4
}
