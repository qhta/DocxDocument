namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies an item to display in the active window pane.
/// </summary>
public enum WdSpecialPane
{
  /// <summary>
  /// No display.
  /// </summary>
  wdPaneNone = unchecked((int)0),
  /// <summary>
  /// The pane primary header.
  /// </summary>
  wdPanePrimaryHeader = unchecked((int)1),
  /// <summary>
  /// The first page header.
  /// </summary>
  wdPaneFirstPageHeader = unchecked((int)2),
  /// <summary>
  /// The even pages header.
  /// </summary>
  wdPaneEvenPagesHeader = unchecked((int)3),
  /// <summary>
  /// The pane primary footer.
  /// </summary>
  wdPanePrimaryFooter = unchecked((int)4),
  /// <summary>
  /// The first page footer.
  /// </summary>
  wdPaneFirstPageFooter = unchecked((int)5),
  /// <summary>
  /// The even pages footer.
  /// </summary>
  wdPaneEvenPagesFooter = unchecked((int)6),
  /// <summary>
  /// Footnotes.
  /// </summary>
  wdPaneFootnotes = unchecked((int)7),
  /// <summary>
  /// Endnotes. wdPaneFootnoteContinuationNotice9 The footnote continuation notice.
  /// wdPaneFootnoteContinuationSeparator10 The footnote continuation separator.
  /// [System.Runtime.InteropServices.Guid("167B59A9-DBBD-34AF-AFDB-57AC30C2CE58")] public enum WdSpecialPane ﾉ
  /// Expand table
  /// </summary>
  wdPaneEndnotes = unchecked((int)8),
  /// <summary>
  /// Specifies an item to display in the active window pane.
  /// </summary>
  wdPaneFootnoteContinuationNotice = unchecked((int)9),
  /// <summary>
  /// Specifies an item to display in the active window pane.
  /// </summary>
  wdPaneFootnoteContinuationSeparator = unchecked((int)10),
  /// <summary>
  /// The footnote separator. wdPaneEndnoteContinuationNotice12 The endnote continuation notice.
  /// wdPaneEndnoteContinuationSeparator13 The endnote continuation separator.
  /// </summary>
  wdPaneFootnoteSeparator = unchecked((int)11),
  /// <summary>
  /// Specifies an item to display in the active window pane.
  /// </summary>
  wdPaneEndnoteContinuationNotice = unchecked((int)12),
  /// <summary>
  /// Specifies an item to display in the active window pane.
  /// </summary>
  wdPaneEndnoteContinuationSeparator = unchecked((int)13),
  /// <summary>
  /// The endnote separator.
  /// </summary>
  wdPaneEndnoteSeparator = unchecked((int)14),
  /// <summary>
  /// Selected comments.
  /// </summary>
  wdPaneComments = unchecked((int)15),
  /// <summary>
  /// The page header.
  /// </summary>
  wdPaneCurrentPageHeader = unchecked((int)16),
  /// <summary>
  /// The page footer.
  /// </summary>
  wdPaneCurrentPageFooter = unchecked((int)17),
  /// <summary>
  /// The pane revisions.
  /// </summary>
  wdPaneRevisions = unchecked((int)18),
  /// <summary>
  /// The revisions pane displays along the bottom of the document window.
  /// </summary>
  wdPaneRevisionsHoriz = unchecked((int)19),
  /// <summary>
  /// The revisions pane displays along the left side of the document window.
  /// </summary>
  wdPaneRevisionsVert = unchecked((int)20)
}
