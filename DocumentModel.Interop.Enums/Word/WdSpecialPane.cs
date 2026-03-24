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
  /// Endnotes. wdPaneFootnoteContinuationNotice9 The footnote continuation notice.
  /// wdPaneFootnoteContinuationSeparator10 The footnote continuation separator.
  /// [System.Runtime.InteropServices.Guid("167B59A9-DBBD-34AF-AFDB-57AC30C2CE58")] public enum WdSpecialPane ﾉ
  /// Expand table
  /// </summary>
  Endnotes = 8,
  /// <summary>
  /// Specifies an item to display in the active window pane.
  /// </summary>
  FootnoteContinuationNotice = 9,
  /// <summary>
  /// Specifies an item to display in the active window pane.
  /// </summary>
  FootnoteContinuationSeparator = 10,
  /// <summary>
  /// The footnote separator. wdPaneEndnoteContinuationNotice12 The endnote continuation notice.
  /// wdPaneEndnoteContinuationSeparator13 The endnote continuation separator.
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
  /// The endnote separator.
  /// </summary>
  EndnoteSeparator = 14,
  /// <summary>
  /// Selected comments.
  /// </summary>
  Comments = 15,
  /// <summary>
  /// The page header.
  /// </summary>
  CurrentPageHeader = 16,
  /// <summary>
  /// The page footer.
  /// </summary>
  CurrentPageFooter = 17,
  /// <summary>
  /// The pane revisions.
  /// </summary>
  Revisions = 18,
  /// <summary>
  /// The revisions pane displays along the bottom of the document window.
  /// </summary>
  RevisionsHoriz = 19,
  /// <summary>
  /// The revisions pane displays along the left side of the document window.
  /// </summary>
  RevisionsVert = 20
}
