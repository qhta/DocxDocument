namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies an item to display in the active window pane.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdspecialpane?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdSpecialPane))]
public enum SpecialPane
{
  /// <summary>
  /// No display.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpecialPane.wdPaneNone))]
  None = 0,
  /// <summary>
  /// The pane primary header.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpecialPane.wdPanePrimaryHeader))]
  PrimaryHeader = 1,
  /// <summary>
  /// The first page header.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpecialPane.wdPaneFirstPageHeader))]
  FirstPageHeader = 2,
  /// <summary>
  /// The even pages header.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpecialPane.wdPaneEvenPagesHeader))]
  EvenPagesHeader = 3,
  /// <summary>
  /// The pane primary footer.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpecialPane.wdPanePrimaryFooter))]
  PrimaryFooter = 4,
  /// <summary>
  /// The first page footer.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpecialPane.wdPaneFirstPageFooter))]
  FirstPageFooter = 5,
  /// <summary>
  /// The even pages footer.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpecialPane.wdPaneEvenPagesFooter))]
  EvenPagesFooter = 6,
  /// <summary>
  /// Footnotes.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpecialPane.wdPaneFootnotes))]
  Footnotes = 7,
  /// <summary>
  /// Endnotes.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpecialPane.wdPaneEndnotes))]
  Endnotes = 8,
  /// <summary>
  /// The footnote continuation notice.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpecialPane.wdPaneFootnoteContinuationNotice))]
  FootnoteContinuationNotice = 9,
  /// <summary>
  /// The footnote continuation separator.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpecialPane.wdPaneFootnoteContinuationSeparator))]
  FootnoteContinuationSeparator = 10,
  /// <summary>
  /// The footnote separator.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpecialPane.wdPaneFootnoteSeparator))]
  FootnoteSeparator = 11,
  /// <summary>
  /// The endnote continuation notice.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpecialPane.wdPaneEndnoteContinuationNotice))]
  EndnoteContinuationNotice = 12,
  /// <summary>
  /// The endnote continuation separator.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpecialPane.wdPaneEndnoteContinuationSeparator))]
  EndnoteContinuationSeparator = 13,
  /// <summary>
  /// The endnote separator.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpecialPane.wdPaneEndnoteSeparator))]
  EndnoteSeparator = 14,
  /// <summary>
  /// Selected comments.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpecialPane.wdPaneComments))]
  Comments = 15,
  /// <summary>
  /// The page header.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpecialPane.wdPaneCurrentPageHeader))]
  CurrentPageHeader = 16,
  /// <summary>
  /// The page footer.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpecialPane.wdPaneCurrentPageFooter))]
  CurrentPageFooter = 17,
  /// <summary>
  /// The pane revisions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpecialPane.wdPaneRevisions))]
  Revisions = 18,
  /// <summary>
  /// The revisions pane displays along the bottom of the document window.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpecialPane.wdPaneRevisionsHoriz))]
  RevisionsHoriz = 19,
  /// <summary>
  /// The revisions pane displays along the left side of the document window.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSpecialPane.wdPaneRevisionsVert))]
  RevisionsVert = 20
}
