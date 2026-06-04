namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies an item to display in the active window pane.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdspecialpane?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdSpecialPane")]
public enum SpecialPane
{
  /// <summary>
  /// No display.
  /// </summary>
  [WordInteropEnumValue("wdPaneNone")]
  None = 0,
  /// <summary>
  /// The pane primary header.
  /// </summary>
  [WordInteropEnumValue("wdPanePrimaryHeader")]
  PrimaryHeader = 1,
  /// <summary>
  /// The first page header.
  /// </summary>
  [WordInteropEnumValue("wdPaneFirstPageHeader")]
  FirstPageHeader = 2,
  /// <summary>
  /// The even pages header.
  /// </summary>
  [WordInteropEnumValue("wdPaneEvenPagesHeader")]
  EvenPagesHeader = 3,
  /// <summary>
  /// The pane primary footer.
  /// </summary>
  [WordInteropEnumValue("wdPanePrimaryFooter")]
  PrimaryFooter = 4,
  /// <summary>
  /// The first page footer.
  /// </summary>
  [WordInteropEnumValue("wdPaneFirstPageFooter")]
  FirstPageFooter = 5,
  /// <summary>
  /// The even pages footer.
  /// </summary>
  [WordInteropEnumValue("wdPaneEvenPagesFooter")]
  EvenPagesFooter = 6,
  /// <summary>
  /// Footnotes.
  /// </summary>
  [WordInteropEnumValue("wdPaneFootnotes")]
  Footnotes = 7,
  /// <summary>
  /// Endnotes.
  /// </summary>
  [WordInteropEnumValue("wdPaneEndnotes")]
  Endnotes = 8,
  /// <summary>
  /// The footnote continuation notice.
  /// </summary>
  [WordInteropEnumValue("wdPaneFootnoteContinuationNotice")]
  FootnoteContinuationNotice = 9,
  /// <summary>
  /// The footnote continuation separator.
  /// </summary>
  [WordInteropEnumValue("wdPaneFootnoteContinuationSeparator")]
  FootnoteContinuationSeparator = 10,
  /// <summary>
  /// The footnote separator.
  /// </summary>
  [WordInteropEnumValue("wdPaneFootnoteSeparator")]
  FootnoteSeparator = 11,
  /// <summary>
  /// The endnote continuation notice.
  /// </summary>
  [WordInteropEnumValue("wdPaneEndnoteContinuationNotice")]
  EndnoteContinuationNotice = 12,
  /// <summary>
  /// The endnote continuation separator.
  /// </summary>
  [WordInteropEnumValue("wdPaneEndnoteContinuationSeparator")]
  EndnoteContinuationSeparator = 13,
  /// <summary>
  /// The endnote separator.
  /// </summary>
  [WordInteropEnumValue("wdPaneEndnoteSeparator")]
  EndnoteSeparator = 14,
  /// <summary>
  /// Selected comments.
  /// </summary>
  [WordInteropEnumValue("wdPaneComments")]
  Comments = 15,
  /// <summary>
  /// The page header.
  /// </summary>
  [WordInteropEnumValue("wdPaneCurrentPageHeader")]
  CurrentPageHeader = 16,
  /// <summary>
  /// The page footer.
  /// </summary>
  [WordInteropEnumValue("wdPaneCurrentPageFooter")]
  CurrentPageFooter = 17,
  /// <summary>
  /// The pane revisions.
  /// </summary>
  [WordInteropEnumValue("wdPaneRevisions")]
  Revisions = 18,
  /// <summary>
  /// The revisions pane displays along the bottom of the document window.
  /// </summary>
  [WordInteropEnumValue("wdPaneRevisionsHoriz")]
  RevisionsHoriz = 19,
  /// <summary>
  /// The revisions pane displays along the left side of the document window.
  /// </summary>
  [WordInteropEnumValue("wdPaneRevisionsVert")]
  RevisionsVert = 20
}
