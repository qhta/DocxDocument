namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of information returned about a specified selection or range.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdinformation?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdInformation")]
public enum Information
{
  /// <summary>
  /// Returns the number of the page that contains the active end of the specified selection or range. If you set a
  /// starting page number or make other manual adjustments, returns the adjusted page number (unlike
  /// wdActiveEndPageNumber).
  /// </summary>
  [InteropEnumValue("wdActiveEndAdjustedPageNumber")]
  ActiveEndAdjustedPageNumber = 1,
  /// <summary>
  /// Returns the number of the section that contains the active end of the specified selection or range.
  /// </summary>
   [InteropEnumValue("wdActiveEndSectionNumber")]
   ActiveEndSectionNumber = 2,
  /// <summary>
  /// Returns the number of the page that contains the active end of the specified selection or range, counting from
  /// the beginning of the document. Any manual adjustments to page numbering are disregarded (unlike
  /// wdActiveEndAdjustedPageNumber).
  /// </summary>
   [InteropEnumValue("wdActiveEndPageNumber")]
   ActiveEndPageNumber = 3,
  /// <summary>
  /// Returns the number of pages in the document associated with the selection or range.
  /// </summary>
   [InteropEnumValue("wdNumberOfPagesInDocument")]
   NumberOfPagesInDocument = 4,
  /// <summary>
  /// Returns the horizontal position of the specified selection or range; this is the distance from the
  /// </summary>
   [InteropEnumValue("wdHorizontalPositionRelativeToPage")]
   HorizontalPositionRelativeToPage = 5,
  /// <summary>
  /// Returns the vertical position of the selection or range; this is the distance from the top edge of the
  /// selection to the top edge of the page measured in points (1 point = 20 twips, 72 points = 1 inch). If the
  /// selection isn't visible in the document window, returns â€“ 1.
  /// </summary>
   [InteropEnumValue("wdVerticalPositionRelativeToPage")]
   VerticalPositionRelativeToPage = 6,
  /// <summary>
  /// Returns the horizontal position of the specified selection or range relative to the left edge of the nearest
  /// text boundary enclosing it, in points (1 point = 20 twips, 72 points = 1 inch). If the selection or range
  /// isn't within the screen area, returns - 1.
  /// </summary>
   [InteropEnumValue("wdHorizontalPositionRelativeToTextBoundary")]
   HorizontalPositionRelativeToTextBoundary = 7,
  /// <summary>
  /// Returns the vertical position of the selection or range relative to the top edge of the nearest text boundary
  /// enclosing it, in points (1 point = 20 twips, 72 points = 1 inch). This is useful for determining the position
  /// of the insertion point within a frame or table cell. If the selection isn't visible, returns â€“ 1.
  /// </summary>
   [InteropEnumValue("wdVerticalPositionRelativeToTextBoundary")]
   VerticalPositionRelativeToTextBoundary = 8,
  /// <summary>
  /// Returns the character position of the first character in the specified selection or range. If the selection or
  /// range is collapsed, the character number immediately to the right of the range or selection is returned (this
  /// is the same as the character column number displayed in the status bar after "Col").
  /// </summary>
   [InteropEnumValue("wdFirstCharacterColumnNumber")]
   FirstCharacterColumnNumber = 9,
  /// <summary>
  /// Returns the character position of the first character in the specified selection or range. If the selection or
  /// range is collapsed, the character number immediately to the right of the range or selection is returned (this
  /// is the same as the character line number displayed in the status bar after "Ln").
  /// </summary>
   [InteropEnumValue("wdFirstCharacterLineNumber")]
   FirstCharacterLineNumber = 10,
  /// <summary>
  /// Returns True if the selection or range is an entire frame or text box.
  /// </summary>
   [InteropEnumValue("wdFrameIsSelected")]
   FrameIsSelected = 11,
  /// <summary>
  /// Returns True if the selection is in a table.
  /// </summary>
   [InteropEnumValue("wdWithInTable")]
   WithInTable = 12,
  /// <summary>
  /// Returns the table row number that contains the beginning of the selection or range.
  /// </summary>
   [InteropEnumValue("wdStartOfRangeRowNumber")]
   StartOfRangeRowNumber = 13,
  /// <summary>
  /// Returns the table row number that contains the end of the specified selection or range.
  /// </summary>
   [InteropEnumValue("wdEndOfRangeRowNumber")]
   EndOfRangeRowNumber = 14,
  /// <summary>
  /// Returns the greatest number of table rows within the table in the specified selection or range.
  /// </summary>
   [InteropEnumValue("wdMaximumNumberOfRows")]
   MaximumNumberOfRows = 15,
  /// <summary>
  /// Returns the table column number that contains the beginning of the selection or range.
  /// </summary>
   [InteropEnumValue("wdStartOfRangeColumnNumber")]
   StartOfRangeColumnNumber = 16,
  /// <summary>
  /// Returns the table column number that contains the end of the specified selection or range.
  /// </summary>
  [InteropEnumValue("wdEndOfRangeColumnNumber")]
  EndOfRangeColumnNumber = 17,
  /// <summary>
  /// Returns the greatest number of table columns within any row in the selection or range.
  /// </summary>
   [InteropEnumValue("wdMaximumNumberOfColumns")]
   MaximumNumberOfColumns = 18,
  /// <summary>
  /// Returns the current percentage of magnification as set by the Percentage property.
  /// </summary>
   [InteropEnumValue("wdZoomPercentage")]
   ZoomPercentage = 19,
  /// <summary>
  /// Returns a value that indicates the current selection mode, as shown in the following table.
  /// </summary>
   [InteropEnumValue("wdSelectionMode")]
   SelectionMode = 20,
  /// <summary>
  /// Returns True if Caps Lock is in effect.
  /// </summary>
   [InteropEnumValue("wdCapsLock")]
   CapsLock = 21,
  /// <summary>
  /// Returns True if Num Lock is in effect.
  /// </summary>
   [InteropEnumValue("wdNumLock")]
   NumLock = 22,
  /// <summary>
  /// Returns True if Overtype mode is in effect. The Overtype property can be used to change the state of the
  /// Overtype mode.
  /// </summary>
   [InteropEnumValue("wdOverType")]
   OverType = 23,
  /// <summary>
  /// Returns True if change tracking is in effect.
  /// </summary>
   [InteropEnumValue("wdRevisionMarking")]
   RevisionMarking = 24,
  /// <summary>
  /// Returns True if the specified selection or range is in the footnote or endnote pane in normal view or in a
  /// footnote or endnote area in print layout view. For more information, see the descriptions of wdInFootnote and
  /// wdInEndnote in the preceding paragraphs.
  /// </summary>
   [InteropEnumValue("wdInFootnoteEndnotePane")]
   InFootnoteEndnotePane = 25,
  /// <summary>
  /// Returns True if the specified selection or range is in a comment pane.
  /// </summary>
   [InteropEnumValue("wdInCommentPane")]
   InCommentPane = 26,
  /// <summary>
  /// Returns True if the selection or range is in the header or footer pane or in a header or footer in print
  /// layout view.
  /// </summary>
   [InteropEnumValue("wdInHeaderFooter")]
   InHeaderFooter = 28,
  /// <summary>
  /// Returns True if the specified selection or range is at the end-of-row mark in a table.
  /// </summary>
   [InteropEnumValue("wdAtEndOfRowMarker")]
   AtEndOfRowMarker = 31,
  /// <summary>
  /// Returns a value that indicates where the selection is in relation to a footnote, endnote, or comment
  /// reference, as shown in the following table.
  /// </summary>
   [InteropEnumValue("wdReferenceOfType")]
   ReferenceOfType = 32,
  /// <summary>
  /// Returns a value that indicates the type of header or footer that contains the specified selection or range, as
  /// shown in the following table.
  /// </summary>
   [InteropEnumValue("wdHeaderFooterType")]
   HeaderFooterType = 33,
  /// <summary>
  /// Returns True if the selection or range is in a master document (that is, a document that contains at least one
  /// subdocument).
  /// </summary>
   [InteropEnumValue("wdInMasterDocument")]
   InMasterDocument = 34,
  /// <summary>
  /// Returns True if the specified selection or range is in the footnote or endnote pane in normal view or in a
  /// footnote or endnote area in print layout view. For more information, see the descriptions of wdInFootnote and
  /// wdInEndnote in the preceding paragraphs.
  /// </summary>
   [InteropEnumValue("wdInFootnote")]
   InFootnote = 35,
  /// <summary>
  /// Returns True if the specified selection or range is in an endnote area in print layout view or in the endnote
  /// pane in normal view.
  /// </summary>
   [InteropEnumValue("wdInEndnote")]
   InEndnote = 36,
  /// <summary>
  /// Returns True if the selection or range is in the header or footer pane or in a header or footer in print
  /// layout view.
  /// </summary>
   [InteropEnumValue("wdInWordMail")]
   InWordMail = 37,
  /// <summary>
  /// For information about this constant, consult the language reference Help included with Microsoft Office
  /// Macintosh Edition.
  /// </summary>
   [InteropEnumValue("wdInClipboard")]
   InClipboard = 38,
  /// <summary>
  /// Returns True if the specified selection or range is in a cover page.
  /// </summary>
   [InteropEnumValue("wdInCoverPage")]
   InCoverPage = 41,
  /// <summary>
  /// Returns True if the specified selection or range is in a bibliography.
  /// </summary>
   [InteropEnumValue("wdInBibliography")]
   InBibliography = 42,
  /// <summary>
  /// Returns True if the specified selection or range is in a citation.
  /// </summary>
   [InteropEnumValue("wdInCitation")]
   InCitation = 43,
  /// <summary>
  /// Returns True if the specified selection or range is in a field code.
  /// </summary>
   [InteropEnumValue("wdInFieldCode")]
   InFieldCode = 44,
  /// <summary>
  /// Returns True if the specified selection or range is in a field result.
  /// </summary>
   [InteropEnumValue("wdInFieldResult")]
   InFieldResult = 45,
  /// <summary>
  /// Returns True if the specified selection or range is in a content control.
  /// </summary>
   [InteropEnumValue("wdInContentControl")]
   InContentControl = 46
}
