namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the document element to display in the print layout view.
/// </summary>
public enum WdSeekView
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
  /// The current page footer. [System.Runtime.InteropServices.Guid("8472D0A9-03EA-3253-8BC8-F66718CF09A6")] public
  /// enum WdSeekView ﾉ Expand table
  /// </summary>
  CurrentPageFooter = 10
}
