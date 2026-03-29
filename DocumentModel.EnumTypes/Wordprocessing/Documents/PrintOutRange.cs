namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies a range to print.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdprintoutrange?view=office-pia` for Office interop details.
/// </remarks>
public enum PrintOutRange
{
  /// <summary>
  /// The entire document.
  /// </summary>
  AllDocument = 0,
  /// <summary>
  /// The current selection.
  /// </summary>
  Selection = 1,
  /// <summary>
  /// The current page.
  /// </summary>
  CurrentPage = 2,
  /// <summary>
  /// A specified range.
  /// </summary>
  FromTo = 3,
  /// <summary>
  /// A specified range of pages.
  /// </summary>
  RangeOfPages = 4
}
