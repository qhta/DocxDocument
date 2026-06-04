namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of pages to print.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdprintoutpages?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdPrintOutPages))]
public enum PrintOutPages
{
  /// <summary>
  /// All pages.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPrintOutPages.wdPrintAllPages))]
  AllPages = 0,
  /// <summary>
  /// Odd-numbered pages only.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPrintOutPages.wdPrintOddPagesOnly))]
  OddPagesOnly = 1,
  /// <summary>
  /// Even-numbered pages only.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPrintOutPages.wdPrintEvenPagesOnly))]
  EvenPagesOnly = 2
}
