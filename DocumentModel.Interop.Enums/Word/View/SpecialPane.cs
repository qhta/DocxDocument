namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies an item to display in the active window pane.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdspecialpane?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdSpecialPane")]
public enum SpecialPane
{
  /// <summary>
  /// No display.
  /// </summary>
  [InteropEnumValue("wdPaneNone")]
  None = 0,
  /// <summary>
  /// The pane primary header.
  /// </summary>
  [InteropEnumValue("wdPanePrimaryHeader")]
  PrimaryHeader = 1,
  /// <summary>
  /// The first page header.
  /// </summary>
  [InteropEnumValue("wdPaneFirstPageHeader")]
  FirstPageHeader = 2,
  /// <summary>
  /// The even pages header.
  /// </summary>
  [InteropEnumValue("wdPaneEvenPagesHeader")]
  EvenPagesHeader = 3,
  /// <summary>
  /// The pane primary footer.
  /// </summary>
  [InteropEnumValue("wdPanePrimaryFooter")]
  PrimaryFooter = 4,
  /// <summary>
  /// The first page footer.
  /// </summary>
  [InteropEnumValue("wdPaneFirstPageFooter")]
  FirstPageFooter = 5,
  /// <summary>
  /// The even pages footer.
  /// </summary>
  [InteropEnumValue("wdPaneEvenPagesFooter")]
  EvenPagesFooter = 6,
  /// <summary>
  /// Footnotes.
  /// </summary>
  [InteropEnumValue("wdPaneFootnotes")]
  Footnotes = 7,
  /// <summary>
  /// Endnotes.
  /// </summary>
  [InteropEnumValue("wdPaneEndnotes")]
  Endnotes = 8,
  /// <summary>
  /// The footnote continuation notice.
  /// </summary>
  [InteropEnumValue("wdPaneFootnoteContinuationNotice")]
  FootnoteContinuationNotice = 9,
  /// <summary>
  /// The footnote continuation separator.
  /// </summary>
  [InteropEnumValue("wdPaneFootnoteContinuationSeparator")]
  FootnoteContinuationSeparator = 10,
  /// <summary>
  /// The footnote separator.
  /// </summary>
  [InteropEnumValue("wdPaneFootnoteSeparator")]
  FootnoteSeparator = 11,
  /// <summary>
  /// The endnote continuation notice.
  /// </summary>
  [InteropEnumValue("wdPaneEndnoteContinuationNotice")]
  EndnoteContinuationNotice = 12,
  /// <summary>
  /// The endnote continuation separator.
  /// </summary>
  [InteropEnumValue("wdPaneEndnoteContinuationSeparator")]
  EndnoteContinuationSeparator = 13,
  /// <summary>
  /// The endnote separator.
  /// </summary>
  [InteropEnumValue("wdPaneEndnoteSeparator")]
  EndnoteSeparator = 14,
  /// <summary>
  /// Selected comments.
  /// </summary>
  [InteropEnumValue("wdPaneComments")]
  Comments = 15,
  /// <summary>
  /// The page header.
  /// </summary>
  [InteropEnumValue("wdPaneCurrentPageHeader")]
  CurrentPageHeader = 16,
  /// <summary>
  /// The page footer.
  /// </summary>
  [InteropEnumValue("wdPaneCurrentPageFooter")]
  CurrentPageFooter = 17,
  /// <summary>
  /// The pane revisions.
  /// </summary>
  [InteropEnumValue("wdPaneRevisions")]
  Revisions = 18,
  /// <summary>
  /// The revisions pane displays along the bottom of the document window.
  /// </summary>
  [InteropEnumValue("wdPaneRevisionsHoriz")]
  RevisionsHoriz = 19,
  /// <summary>
  /// The revisions pane displays along the left side of the document window.
  /// </summary>
  [InteropEnumValue("wdPaneRevisionsVert")]
  RevisionsVert = 20
}
