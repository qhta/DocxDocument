namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of information returned about a specified selection or range.
/// </summary>
public enum WdInformation
{
  /// <summary>
  /// Returns the number of the page that contains the active end of the specified selection or range. If you set a
  /// starting page number or make other manual adjustments, returns the adjusted page number (unlike
  /// wdActiveEndPageNumber).
  /// </summary>
  ActiveEndAdjustedPageNumber = unchecked((int)1),
  /// <summary>
  /// Returns the number of the section that contains the active end of the specified selection or range.
  /// </summary>
  ActiveEndSectionNumber = unchecked((int)2),
  /// <summary>
  /// Returns the number of the page that contains the active end of the specified selection or range, counting from
  /// the beginning of the document. Any manual adjustments to page numbering are disregarded (unlike
  /// wdActiveEndAdjustedPageNumber).
  /// </summary>
  ActiveEndPageNumber = unchecked((int)3),
  /// <summary>
  /// Returns the number of pages in the document associated with the selection or range.
  /// </summary>
  NumberOfPagesInDocument = unchecked((int)4),
  /// <summary>
  /// Returns the horizontal position of the specified selection or range; this is the distance from the
  /// [System.Runtime.InteropServices.Guid("26E3C1D3-6937-3EFA-8859-7FFC81869CE5")] public enum WdInformation ﾉ
  /// Expand table left edge of the selection or range to the left edge of the page measured in points (1 point = 20
  /// twips, 72 points = 1 inch). If the selection or range isn't within the screen area, returns – 1.
  /// </summary>
  HorizontalPositionRelativeToPage = unchecked((int)5),
  /// <summary>
  /// Returns the vertical position of the selection or range; this is the distance from the top edge of the
  /// selection to the top edge of the page measured in points (1 point = 20 twips, 72 points = 1 inch). If the
  /// selection isn't visible in the document window, returns – 1. wdHorizontalPositionRelativeToTextBoundary7
  /// Returns the horizontal position of the specified selection or range relative to the left edge of the nearest
  /// text boundary enclosing it, in points (1 point = 20 twips, 72 points = 1 inch). If the selection or range
  /// isn't within the screen area, returns - 1.
  /// </summary>
  VerticalPositionRelativeToPage = unchecked((int)6),
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
  HorizontalPositionRelativeToTextBoundary = unchecked((int)7),
  /// <summary>
  /// Returns the vertical position of the selection or range relative to the top edge of the nearest text boundary
  /// enclosing it, in points (1 point = 20 twips, 72 points = 1 inch). This is useful for determining the position
  /// of the insertion point within a frame or table cell. If the selection isn't visible, returns – 1.
  /// </summary>
  VerticalPositionRelativeToTextBoundary = unchecked((int)8),
  /// <summary>
  /// Returns the character position of the first character in the specified selection or range. If the selection or
  /// range is collapsed, the character number immediately to the right of the range or selection is returned (this
  /// is the same as the character column number displayed in the status bar after "Col").
  /// </summary>
  FirstCharacterColumnNumber = unchecked((int)9),
  /// <summary>
  /// Returns the character position of the first character in the specified selection or range. If the selection or
  /// range is collapsed, the character number immediately to the right of the range or selection is returned (this
  /// is the same as the character line number displayed in the status bar after "Ln").
  /// </summary>
  FirstCharacterLineNumber = unchecked((int)10),
  /// <summary>
  /// Returns True if the selection or range is an entire frame or text box.
  /// </summary>
  FrameIsSelected = unchecked((int)11),
  /// <summary>
  /// Returns True if the selection is in a table.
  /// </summary>
  WithInTable = unchecked((int)12),
  /// <summary>
  /// Returns the table row number that contains the beginning of the selection or range.
  /// </summary>
  StartOfRangeRowNumber = unchecked((int)13),
  /// <summary>
  /// Returns the table row number that contains the end of the specified selection or range.
  /// </summary>
  EndOfRangeRowNumber = unchecked((int)14),
  /// <summary>
  /// Returns the greatest number of table rows within the table in the specified selection or range.
  /// </summary>
  MaximumNumberOfRows = unchecked((int)15),
  /// <summary>
  /// Returns the table column number that contains the beginning of the selection or range.
  /// </summary>
  StartOfRangeColumnNumber = unchecked((int)16),
  /// <summary>
  /// Returns the table column number that contains the end of the specified selection or range.
  /// </summary>
  EndOfRangeColumnNumber = unchecked((int)17),
  /// <summary>
  /// Returns the greatest number of table columns within any row in the selection or range.
  /// </summary>
  MaximumNumberOfColumns = unchecked((int)18),
  /// <summary>
  /// Returns the current percentage of magnification as set by the Percentage property.
  /// </summary>
  ZoomPercentage = unchecked((int)19),
  /// <summary>
  /// Returns a value that indicates the current selection mode, as shown in the following table.
  /// </summary>
  SelectionMode = unchecked((int)20),
  /// <summary>
  /// Returns True if Caps Lock is in effect.
  /// </summary>
  CapsLock = unchecked((int)21),
  /// <summary>
  /// Returns True if Num Lock is in effect.
  /// </summary>
  NumLock = unchecked((int)22),
  /// <summary>
  /// Returns True if Overtype mode is in effect. The Overtype property can be used to change the state of the
  /// Overtype mode.
  /// </summary>
  OverType = unchecked((int)23),
  /// <summary>
  /// Returns True if change tracking is in effect.
  /// </summary>
  RevisionMarking = unchecked((int)24),
  /// <summary>
  /// Returns True if the specified selection or range is in the footnote or endnote pane in normal view or in a
  /// footnote or endnote area in print layout view. For more information, see the descriptions of wdInFootnote and
  /// wdInEndnote in the preceding paragraphs.
  /// </summary>
  InFootnoteEndnotePane = unchecked((int)25),
  /// <summary>
  /// Returns True if the specified selection or range is in a comment pane.
  /// </summary>
  InCommentPane = unchecked((int)26),
  /// <summary>
  /// Returns True if the selection or range is in the header or footer pane or in a header or footer in print
  /// layout view.
  /// </summary>
  InHeaderFooter = unchecked((int)28),
  /// <summary>
  /// Returns True if the specified selection or range is at the end-of-row mark in a table.
  /// </summary>
  AtEndOfRowMarker = unchecked((int)31),
  /// <summary>
  /// Returns a value that indicates where the selection is in relation to a footnote, endnote, or comment
  /// reference, as shown in the following table.
  /// </summary>
  ReferenceOfType = unchecked((int)32),
  /// <summary>
  /// Returns a value that indicates the type of header or footer that contains the specified selection or range, as
  /// shown in the following table.
  /// </summary>
  HeaderFooterType = unchecked((int)33),
  /// <summary>
  /// Returns True if the selection or range is in a master document (that is, a document that contains at least one
  /// subdocument).
  /// </summary>
  InMasterDocument = unchecked((int)34),
  /// <summary>
  /// Returns True if the specified selection or range is in a footnote area in print layout view or in the footnote
  /// pane in normal view.
  /// </summary>
  InFootnote = unchecked((int)35),
  /// <summary>
  /// Returns True if the specified selection or range is in an endnote area in print layout view or in the endnote
  /// pane in normal view.
  /// </summary>
  InEndnote = unchecked((int)36),
  /// <summary>
  /// Returns True if the selection or range is in the header or footer pane or in a header or footer in print
  /// layout view.
  /// </summary>
  InWordMail = unchecked((int)37),
  /// <summary>
  /// For information about this constant, consult the language reference Help included with Microsoft Office
  /// Macintosh Edition.
  /// </summary>
  InClipboard = unchecked((int)38),
  /// <summary>
  /// Returns True if the specified selection or range is in a cover page.
  /// </summary>
  InCoverPage = unchecked((int)41),
  /// <summary>
  /// Returns True if the specified selection or range is in a bibliography.
  /// </summary>
  InBibliography = unchecked((int)42),
  /// <summary>
  /// Returns True if the specified selection or range is in a citation.
  /// </summary>
  InCitation = unchecked((int)43),
  /// <summary>
  /// Returns True if the specified selection or range is in a field code.
  /// </summary>
  InFieldCode = unchecked((int)44),
  /// <summary>
  /// Returns True if the specified selection or range is in a field result.
  /// </summary>
  InFieldResult = unchecked((int)45),
  /// <summary>
  /// Returns True if the specified selection or range is in a content control.
  /// </summary>
  InContentControl = unchecked((int)46)
}
