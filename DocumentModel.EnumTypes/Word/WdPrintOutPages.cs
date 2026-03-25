namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of pages to print.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdprintoutpages?view=office-pia` for Office interop details.
/// </remarks>
public enum WdPrintOutPages
{
  /// <summary>
  /// All pages.
  /// </summary>
  AllPages = 0,
  /// <summary>
  /// Odd-numbered pages only.
  /// </summary>
  OddPagesOnly = 1,
  /// <summary>
  /// Even-numbered pages only.
  /// </summary>
  EvenPagesOnly = 2
}
