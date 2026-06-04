namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Information enumeration.
/// Used in types such as ShouldSerializeCodeFixProvider, AssemblyInfo, ShapeKind.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Information
{
  /// <summary>
  /// Returns the number of the page that contains the active end of the specified selection or range. If you set a
  /// starting page number or make other manual adjustments, returns the adjusted page number (unlike
  /// wdActiveEndPageNumber).
  /// </summary>
  [OpenXmlEnumValue("ActiveEndAdjusted")]
  ActiveEndAdjustedPageNumber = 1,
  /// <summary>
  /// Returns the number of the section that contains the active end of the specified selection or range.
  /// </summary>
  [OpenXmlEnumValue("ActiveEndSectionNumber")]
  ActiveEndSectionNumber = 2,
  /// <summary>
  /// Returns the number of the page that contains the active end of the specified selection or range, counting from
  /// the beginning of the document. Any manual adjustments to page numbering are disregarded (unlike
  /// wdActiveEndAdjustedPageNumber).
  /// </summary>
  [OpenXmlEnumValue("ActiveEndPageNumber")]
  ActiveEndPageNumber = 3,
  /// <summary>
  /// Returns the number of pages in the document associated with the selection or range.
  /// </summary>
  [OpenXmlEnumValue("NumberOfPagesInDocument")]
  NumberOfPagesInDocument = 4,
  /// <summary>
  /// Returns the horizontal position of the specified selection or range; this is the distance from the
  /// left edge of the page measured in points (1 point = 20 twips, 72 points = 1 inch). If the selection or range
  /// isn't within the screen area, returns -1.
  /// </summary>
  [OpenXmlEnumValue("HorizontalPositionRelativeToPage")]
  HorizontalPositionRelativeToPage = 5,
  /// <summary>
  /// Returns the vertical position of the selection or range; this is the distance from the top edge of the
  /// selection to the top edge of the page measured in points (1 point = 20 twips, 72 points = 1 inch). If the
  /// selection isn't visible in the document window, returns – 1. wdHorizontalPositionRelativeToTextBoundary7
  /// Returns the horizontal position of the specified selection or range relative to the left edge of the nearest
  /// text boundary enclosing it, in points (1 point = 20 twips, 72 points = 1 inch). If the selection or range
  /// isn't within the screen area, returns - 1.
  /// </summary>
  [OpenXmlEnumValue("VerticalPositionRelativeToPage")]
  VerticalPositionRelativeToPage = 6,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
  [OpenXmlEnumValue("HorizontalPositionRelativeToTextBoundary")]
  HorizontalPositionRelativeToTextBoundary = 7,
  /// <summary>
  /// Returns the vertical position of the selection or range relative to the top edge of the nearest text boundary
  /// enclosing it, in points (1 point = 20 twips, 72 points = 1 inch). This is useful for determining the position
  /// of the insertion point within a frame or table cell. If the selection isn't visible, returns – 1.
  /// </summary>
  [OpenXmlEnumValue("VerticalPositionRelativeToTextBoundary")]
  VerticalPositionRelativeToTextBoundary = 8,
  /// <summary>
  /// Returns the character position of the first character in the specified selection or range. If the selection or
  /// range is collapsed, the character number immediately to the right of the range or selection is returned (this
  /// is the same as the character column number displayed in the status bar after "Col").
  /// </summary>
  [OpenXmlEnumValue("StartOfRangeColumnNumber")]
  FirstCharacterColumnNumber = 9,
  /// <summary>
  /// Returns the character position of the first character in the specified selection or range. If the selection or
  /// range is collapsed, the character number immediately to the right of the range or selection is returned (this
  /// is the same as the character line number displayed in the status bar after "Ln").
  /// </summary>
  [OpenXmlEnumValue("StartOfRangeLineNumber")]
  FirstCharacterLineNumber = 10,
  /// <summary>
  /// Returns True if the selection or range is an entire frame or text box.
  /// </summary>
  [OpenXmlEnumValue("FrameIsSelected")]
  FrameIsSelected = 11,
  /// <summary>
  /// Returns True if the selection is in a table.
  /// </summary>
  [OpenXmlEnumValue("InTable")]
  WithInTable = 12,
  /// <summary>
  /// Returns the table row number that contains the beginning of the selection or range.
  /// </summary>
  [OpenXmlEnumValue("StartOfRangeRowNumber")]
  StartOfRangeRowNumber = 13,
  /// <summary>
  /// Returns the table row number that contains the end of the specified selection or range.
  /// </summary>
  [OpenXmlEnumValue("EndOfRangeRowNumber")]
  EndOfRangeRowNumber = 14,
  /// <summary>
  /// Returns the greatest number of table rows within the table in the specified selection or range.
  /// </summary>
  [OpenXmlEnumValue("MaximumNumberOfRows")]
  MaximumNumberOfRows = 15,
  /// <summary>
  /// Returns the table column number that contains the beginning of the selection or range.
  /// </summary>
  [OpenXmlEnumValue("StartOfRangeColumnNumber")]
  StartOfRangeColumnNumber = 16,
  /// <summary>
  /// Returns the table column number that contains the end of the specified selection or range.
  /// </summary>
  EndOfRangeColumnNumber = 17,
  /// <summary>
  /// Returns the greatest number of table columns within any row in the selection or range.
  /// </summary>
  [OpenXmlEnumValue("MaximumNumberOfColumns")]
  MaximumNumberOfColumns = 18,
  /// <summary>
  /// Returns the current percentage of magnification as set by the Percentage property.
  /// </summary>
  [OpenXmlEnumValue("ZoomPercentage")]
  ZoomPercentage = 19,
  /// <summary>
  /// Returns a value that indicates the current selection mode, as shown in the following table.
  /// </summary>
  [OpenXmlEnumValue("SelectionMode")]
  SelectionMode = 20,
  /// <summary>
  /// Returns True if Caps Lock is in effect.
  /// </summary>
  [OpenXmlEnumValue("CapsLock")]
  CapsLock = 21,
  /// <summary>
  /// Returns True if Num Lock is in effect.
  /// </summary>
  [OpenXmlEnumValue("NumLock")]
  NumLock = 22,
  /// <summary>
  /// Returns True if Overtype mode is in effect. The Overtype property can be used to change the state of the
  /// Overtype mode.
  /// </summary>
  [OpenXmlEnumValue("OverType")]
  OverType = 23,
  /// <summary>
  /// Returns True if change tracking is in effect.
  /// </summary>
  [OpenXmlEnumValue("RevisionMarking")]
  RevisionMarking = 24,
  /// <summary>
  /// Returns True if the specified selection or range is in the footnote or endnote pane in normal view or in a
  /// footnote or endnote area in print layout view. For more information, see the descriptions of wdInFootnote and
  /// wdInEndnote in the preceding paragraphs.
  /// </summary>
  [OpenXmlEnumValue("InFootnoteEndnote")]
  InFootnoteEndnotePane = 25,
  /// <summary>
  /// Returns True if the specified selection or range is in a comment pane.
  /// </summary>
  [OpenXmlEnumValue("InComment")]
  InCommentPane = 26,
  /// <summary>
  /// Returns True if the selection or range is in the header or footer pane or in a header or footer in print
  /// layout view.
  /// </summary>
  [OpenXmlEnumValue("InHeaderFooter")]
  InHeaderFooter = 28,
  /// <summary>
  /// Returns True if the specified selection or range is at the end-of-row mark in a table.
  /// </summary>
  [OpenXmlEnumValue("AtEndOfRowMarker")]
  AtEndOfRowMarker = 31,
  /// <summary>
  /// Returns a value that indicates where the selection is in relation to a footnote, endnote, or comment
  /// reference, as shown in the following table.
  /// </summary>
  [OpenXmlEnumValue("ReferenceOfType")]
  ReferenceOfType = 32,
  /// <summary>
  /// Returns a value that indicates the type of header or footer that contains the specified selection or range, as
  /// shown in the following table.
  /// </summary>
  [OpenXmlEnumValue("HeaderFooterType")]
  HeaderFooterType = 33,
  /// <summary>
  /// Returns True if the selection or range is in a master document (that is, a document that contains at least one
  /// subdocument).
  /// </summary>
  [OpenXmlEnumValue("InMasterDocument")]
  InMasterDocument = 34,
  /// <summary>
  /// Returns True if the specified selection or range is in a footnote area in print layout view or in the footnote
  /// pane in normal view.
  /// </summary>
  [OpenXmlEnumValue("InFootnote")]
  InFootnote = 35,
  /// <summary>
  /// Returns True if the specified selection or range is in an endnote area in print layout view or in the endnote
  /// pane in normal view.
  /// </summary>
  [OpenXmlEnumValue("InEndnote")]
  InEndnote = 36,
  /// <summary>
  /// Returns True if the selection or range is in the header or footer pane or in a header or footer in print
  /// layout view.
  /// </summary>
  [OpenXmlEnumValue("InWordMail")]
  InWordMail = 37,
  /// <summary>
  /// For information about this constant, consult the language reference Help included with Microsoft Office
  /// Macintosh Edition.
  /// </summary>
  [OpenXmlEnumValue("InClipboard")]
  InClipboard = 38,
  /// <summary>
  /// Returns True if the specified selection or range is in a cover page.
  /// </summary>
  [OpenXmlEnumValue("InCoverPage")]
  InCoverPage = 41,
  /// <summary>
  /// Returns True if the specified selection or range is in a bibliography.
  /// </summary>
  [OpenXmlEnumValue("InBibliography")]
  InBibliography = 42,
  /// <summary>
  /// Returns True if the specified selection or range is in a citation.
  /// </summary>
  [OpenXmlEnumValue("InCitation")]
  InCitation = 43,
  /// <summary>
  /// Returns True if the specified selection or range is in a field code.
  /// </summary>
  [OpenXmlEnumValue("InFieldCode")]
  InFieldCode = 44,
  /// <summary>
  /// Returns True if the specified selection or range is in a field result.
  /// </summary>
  [OpenXmlEnumValue("InFieldResult")]
  InFieldResult = 45,
  /// <summary>
  /// Returns True if the specified selection or range is in a content control.
  /// </summary>
  [OpenXmlEnumValue("InContentControl")]
  InContentControl = 46
}
