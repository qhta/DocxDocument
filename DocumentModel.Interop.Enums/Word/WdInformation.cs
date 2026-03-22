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
  wdActiveEndAdjustedPageNumber = unchecked((int)1),
  /// <summary>
  /// Returns the number of the section that contains the active end of the specified selection or range.
  /// </summary>
  wdActiveEndSectionNumber = unchecked((int)2),
  /// <summary>
  /// Returns the number of the page that contains the active end of the specified selection or range, counting from
  /// the beginning of the document. Any manual adjustments to page numbering are disregarded (unlike
  /// wdActiveEndAdjustedPageNumber).
  /// </summary>
  wdActiveEndPageNumber = unchecked((int)3),
  /// <summary>
  /// Returns the number of pages in the document associated with the selection or range.
  /// </summary>
  wdNumberOfPagesInDocument = unchecked((int)4),
  /// <summary>
  /// Returns the horizontal position of the specified selection or range; this is the distance from the
  /// [System.Runtime.InteropServices.Guid("26E3C1D3-6937-3EFA-8859-7FFC81869CE5")] public enum WdInformation ﾉ
  /// Expand table left edge of the selection or range to the left edge of the page measured in points (1 point = 20
  /// twips, 72 points = 1 inch). If the selection or range isn't within the screen area, returns – 1.
  /// </summary>
  wdHorizontalPositionRelativeToPage = unchecked((int)5),
  /// <summary>
  /// Returns the vertical position of the selection or range; this is the distance from the top edge of the
  /// selection to the top edge of the page measured in points (1 point = 20 twips, 72 points = 1 inch). If the
  /// selection isn't visible in the document window, returns – 1. wdHorizontalPositionRelativeToTextBoundary7
  /// Returns the horizontal position of the specified selection or range relative to the left edge of the nearest
  /// text boundary enclosing it, in points (1 point = 20 twips, 72 points = 1 inch). If the selection or range
  /// isn't within the screen area, returns - 1.
  /// </summary>
  wdVerticalPositionRelativeToPage = unchecked((int)6),
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
  wdHorizontalPositionRelativeToTextBoundary = unchecked((int)7),
  /// <summary>
  /// Returns the vertical position of the selection or range relative to the top edge of the nearest text boundary
  /// enclosing it, in points (1 point = 20 twips, 72 points = 1 inch). This is useful for determining the position
  /// of the insertion point within a frame or table cell. If the selection isn't visible, returns – 1.
  /// </summary>
  wdVerticalPositionRelativeToTextBoundary = unchecked((int)8),
  /// <summary>
  /// Returns the character position of the first character in the specified selection or range. If the selection or
  /// range is collapsed, the character number immediately to the right of the range or selection is returned (this
  /// is the same as the character column number displayed in the status bar after "Col").
  /// </summary>
  wdFirstCharacterColumnNumber = unchecked((int)9),
  /// <summary>
  /// Returns the character position of the first character in the specified selection or range. If the selection or
  /// range is collapsed, the character number immediately to the right of the range or selection is returned (this
  /// is the same as the character line number displayed in the status bar after "Ln").
  /// </summary>
  wdFirstCharacterLineNumber = unchecked((int)10),
  /// <summary>
  /// Returns True if the selection or range is an entire frame or text box.
  /// </summary>
  wdFrameIsSelected = unchecked((int)11),
  /// <summary>
  /// Returns True if the selection is in a table.
  /// </summary>
  wdWithInTable = unchecked((int)12),
  /// <summary>
  /// Returns the table row number that contains the beginning of the selection or range.
  /// </summary>
  wdStartOfRangeRowNumber = unchecked((int)13),
  /// <summary>
  /// Returns the table row number that contains the end of the specified selection or range.
  /// </summary>
  wdEndOfRangeRowNumber = unchecked((int)14),
  /// <summary>
  /// Returns the greatest number of table rows within the table in the specified selection or range.
  /// </summary>
  wdMaximumNumberOfRows = unchecked((int)15),
  /// <summary>
  /// Returns the table column number that contains the beginning of the selection or range.
  /// </summary>
  wdStartOfRangeColumnNumber = unchecked((int)16),
  /// <summary>
  /// Returns the table column number that contains the end of the specified selection or range.
  /// </summary>
  wdEndOfRangeColumnNumber = unchecked((int)17),
  /// <summary>
  /// Returns the greatest number of table columns within any row in the selection or range.
  /// </summary>
  wdMaximumNumberOfColumns = unchecked((int)18),
  /// <summary>
  /// Returns the current percentage of magnification as set by the Percentage property.
  /// </summary>
  wdZoomPercentage = unchecked((int)19),
  /// <summary>
  /// Returns a value that indicates the current selection mode, as shown in the following table.
  /// </summary>
  wdSelectionMode = unchecked((int)20),
  /// <summary>
  /// Returns True if Caps Lock is in effect.
  /// </summary>
  wdCapsLock = unchecked((int)21),
  /// <summary>
  /// Returns True if Num Lock is in effect.
  /// </summary>
  wdNumLock = unchecked((int)22),
  /// <summary>
  /// Returns True if Overtype mode is in effect. The Overtype property can be used to change the state of the
  /// Overtype mode.
  /// </summary>
  wdOverType = unchecked((int)23),
  /// <summary>
  /// Returns True if change tracking is in effect.
  /// </summary>
  wdRevisionMarking = unchecked((int)24),
  /// <summary>
  /// Returns True if the specified selection or range is in the footnote or endnote pane in normal view or in a
  /// footnote or endnote area in print layout view. For more information, see the descriptions of wdInFootnote and
  /// wdInEndnote in the preceding paragraphs.
  /// </summary>
  wdInFootnoteEndnotePane = unchecked((int)25),
  /// <summary>
  /// Returns True if the specified selection or range is in a comment pane.
  /// </summary>
  wdInCommentPane = unchecked((int)26),
  /// <summary>
  /// Returns True if the selection or range is in the header or footer pane or in a header or footer in print
  /// layout view.
  /// </summary>
  wdInHeaderFooter = unchecked((int)28),
  /// <summary>
  /// Returns True if the specified selection or range is at the end-of-row mark in a table.
  /// </summary>
  wdAtEndOfRowMarker = unchecked((int)31),
  /// <summary>
  /// Returns a value that indicates where the selection is in relation to a footnote, endnote, or comment
  /// reference, as shown in the following table.
  /// </summary>
  wdReferenceOfType = unchecked((int)32),
  /// <summary>
  /// Returns a value that indicates the type of header or footer that contains the specified selection or range, as
  /// shown in the following table.
  /// </summary>
  wdHeaderFooterType = unchecked((int)33),
  /// <summary>
  /// Returns True if the selection or range is in a master document (that is, a document that contains at least one
  /// subdocument).
  /// </summary>
  wdInMasterDocument = unchecked((int)34),
  /// <summary>
  /// Returns True if the specified selection or range is in a footnote area in print layout view or in the footnote
  /// pane in normal view.
  /// </summary>
  wdInFootnote = unchecked((int)35),
  /// <summary>
  /// Returns True if the specified selection or range is in an endnote area in print layout view or in the endnote
  /// pane in normal view.
  /// </summary>
  wdInEndnote = unchecked((int)36),
  /// <summary>
  /// Returns True if the selection or range is in the header or footer pane or in a header or footer in print
  /// layout view.
  /// </summary>
  wdInWordMail = unchecked((int)37),
  /// <summary>
  /// For information about this constant, consult the language reference Help included with Microsoft Office
  /// Macintosh Edition.
  /// </summary>
  wdInClipboard = unchecked((int)38),
  /// <summary>
  /// Returns True if the specified selection or range is in a cover page.
  /// </summary>
  wdInCoverPage = unchecked((int)41),
  /// <summary>
  /// Returns True if the specified selection or range is in a bibliography.
  /// </summary>
  wdInBibliography = unchecked((int)42),
  /// <summary>
  /// Returns True if the specified selection or range is in a citation.
  /// </summary>
  wdInCitation = unchecked((int)43),
  /// <summary>
  /// Returns True if the specified selection or range is in a field code.
  /// </summary>
  wdInFieldCode = unchecked((int)44),
  /// <summary>
  /// Returns True if the specified selection or range is in a field result.
  /// </summary>
  wdInFieldResult = unchecked((int)45),
  /// <summary>
  /// Returns True if the specified selection or range is in a content control.
  /// </summary>
  wdInContentControl = unchecked((int)46)
}
