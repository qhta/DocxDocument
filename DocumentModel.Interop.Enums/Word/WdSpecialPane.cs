namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies an item to display in the active window pane.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdspecialpane?view=office-pia` for Office interop details.
/// </remarks>
public enum WdSpecialPane
{
  /// <summary>
  /// No display.
  /// </summary>
  None = 0,
  /// <summary>
  /// The pane primary header.
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
  /// The pane primary footer.
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
  /// The footnote continuation notice.
  /// </summary>
  FootnoteContinuationNotice = 9,
  /// <summary>
  /// The footnote continuation separator.
  /// </summary>
  FootnoteContinuationSeparator = 10,
  /// <summary>
  /// Specifies an item to display in the active window pane.
  /// </summary>
  FootnoteSeparator = 11,
  /// <summary>
  /// Specifies an item to display in the active window pane.
  /// </summary>
  EndnoteContinuationNotice = 12,
  /// <summary>
  /// Specifies an item to display in the active window pane.
  /// </summary>
  EndnoteContinuationSeparator = 13,
  /// <summary>
  /// Specifies an item to display in the active window pane.
  /// </summary>
  EndnoteSeparator = 14,
  /// <summary>
  /// Specifies an item to display in the active window pane.
  /// </summary>
  Comments = 15,
  /// <summary>
  /// Specifies an item to display in the active window pane.
  /// </summary>
  CurrentPageHeader = 16,
  /// <summary>
  /// Specifies an item to display in the active window pane.
  /// </summary>
  CurrentPageFooter = 17,
  /// <summary>
  /// Specifies an item to display in the active window pane.
  /// </summary>
  Revisions = 18,
  /// <summary>
  /// Specifies an item to display in the active window pane.
  /// </summary>
  RevisionsHoriz = 19,
  /// <summary>
  /// Specifies an item to display in the active window pane.
  /// </summary>
  RevisionsVert = 20
}
