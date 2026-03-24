namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies an item to display in the active window pane.
/// </summary>
public enum WdSpecialPane
{
  /// <summary>
  /// No display.
  /// </summary>
  None = unchecked((int)0),
  /// <summary>
  /// The pane primary header.
  /// </summary>
  PrimaryHeader = unchecked((int)1),
  /// <summary>
  /// The first page header.
  /// </summary>
  FirstPageHeader = unchecked((int)2),
  /// <summary>
  /// The even pages header.
  /// </summary>
  EvenPagesHeader = unchecked((int)3),
  /// <summary>
  /// The pane primary footer.
  /// </summary>
  PrimaryFooter = unchecked((int)4),
  /// <summary>
  /// The first page footer.
  /// </summary>
  FirstPageFooter = unchecked((int)5),
  /// <summary>
  /// The even pages footer.
  /// </summary>
  EvenPagesFooter = unchecked((int)6),
  /// <summary>
  /// Footnotes.
  /// </summary>
  Footnotes = unchecked((int)7),
  /// <summary>
  /// Endnotes. wdPaneFootnoteContinuationNotice9 The footnote continuation notice.
  /// wdPaneFootnoteContinuationSeparator10 The footnote continuation separator.
  /// [System.Runtime.InteropServices.Guid("167B59A9-DBBD-34AF-AFDB-57AC30C2CE58")] public enum WdSpecialPane ﾉ
  /// Expand table
  /// </summary>
  Endnotes = unchecked((int)8),
  /// <summary>
  /// Specifies an item to display in the active window pane.
  /// </summary>
  FootnoteContinuationNotice = unchecked((int)9),
  /// <summary>
  /// Specifies an item to display in the active window pane.
  /// </summary>
  FootnoteContinuationSeparator = unchecked((int)10),
  /// <summary>
  /// The footnote separator. wdPaneEndnoteContinuationNotice12 The endnote continuation notice.
  /// wdPaneEndnoteContinuationSeparator13 The endnote continuation separator.
  /// </summary>
  FootnoteSeparator = unchecked((int)11),
  /// <summary>
  /// Specifies an item to display in the active window pane.
  /// </summary>
  EndnoteContinuationNotice = unchecked((int)12),
  /// <summary>
  /// Specifies an item to display in the active window pane.
  /// </summary>
  EndnoteContinuationSeparator = unchecked((int)13),
  /// <summary>
  /// The endnote separator.
  /// </summary>
  EndnoteSeparator = unchecked((int)14),
  /// <summary>
  /// Selected comments.
  /// </summary>
  Comments = unchecked((int)15),
  /// <summary>
  /// The page header.
  /// </summary>
  CurrentPageHeader = unchecked((int)16),
  /// <summary>
  /// The page footer.
  /// </summary>
  CurrentPageFooter = unchecked((int)17),
  /// <summary>
  /// The pane revisions.
  /// </summary>
  Revisions = unchecked((int)18),
  /// <summary>
  /// The revisions pane displays along the bottom of the document window.
  /// </summary>
  RevisionsHoriz = unchecked((int)19),
  /// <summary>
  /// The revisions pane displays along the left side of the document window.
  /// </summary>
  RevisionsVert = unchecked((int)20)
}
