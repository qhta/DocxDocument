namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the document element to display in the print layout view.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdseekview?view=office-pia` for Office interop details.
/// </remarks>
public enum SeekView
{
  /// <summary>
  /// The main document.
  /// </summary>
  MainDocument = 0,
  /// <summary>
  /// The primary header.
  /// </summary>
  PrimaryHeader = 1,
  /// <summary>
  /// The first page header.
  /// </summary>
  FirstPageHeader = 2,
  /// <summary>
  /// The even pages header.
  /// </summary>
  EvenPagesHeader = 3,
  /// <summary>
  /// The primary footer.
  /// </summary>
  PrimaryFooter = 4,
  /// <summary>
  /// The first page footer.
  /// </summary>
  FirstPageFooter = 5,
  /// <summary>
  /// The even pages footer.
  /// </summary>
  EvenPagesFooter = 6,
  /// <summary>
  /// Footnotes.
  /// </summary>
  Footnotes = 7,
  /// <summary>
  /// Endnotes.
  /// </summary>
  Endnotes = 8,
  /// <summary>
  /// The current page header.
  /// </summary>
  CurrentPageHeader = 9,
  /// <summary>
  /// The current page footer.
  /// </summary>
  CurrentPageFooter = 10
}
