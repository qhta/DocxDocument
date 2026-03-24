namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of information returned about a specified selection or range.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdinformation?view=office-pia` for Office interop details.
/// </remarks>
public enum WdInformation
{
  /// <summary>
  /// Returns the number of the page that contains the active end of the specified selection or range. If you set a
  /// starting page number or make other manual adjustments, returns the adjusted page number (unlike
  /// wdActiveEndPageNumber).
  /// </summary>
  ActiveEndAdjustedPageNumber = 1,
  /// <summary>
  /// Returns the number of the section that contains the active end of the specified selection or range.
  /// </summary>
   ActiveEndSectionNumber = 2,
  /// <summary>
  /// Returns the number of the page that contains the active end of the specified selection or range, counting from
  /// the beginning of the document. Any manual adjustments to page numbering are disregarded (unlike
  /// wdActiveEndAdjustedPageNumber).
  /// </summary>
   ActiveEndPageNumber = 3,
  /// <summary>
  /// Returns the number of pages in the document associated with the selection or range.
  /// </summary>
   NumberOfPagesInDocument = 4,
  /// <summary>
  /// Returns the horizontal position of the specified selection or range; this is the distance from the
  /// </summary>
   HorizontalPositionRelativeToPage = 5,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   VerticalPositionRelativeToPage = 6,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   HorizontalPositionRelativeToTextBoundary = 7,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   VerticalPositionRelativeToTextBoundary = 8,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   FirstCharacterColumnNumber = 9,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   FirstCharacterLineNumber = 10,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   FrameIsSelected = 11,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   WithInTable = 12,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   StartOfRangeRowNumber = 13,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   EndOfRangeRowNumber = 14,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   MaximumNumberOfRows = 15,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   StartOfRangeColumnNumber = 16,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
  EndOfRangeColumnNumber = 17,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   MaximumNumberOfColumns = 18,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   ZoomPercentage = 19,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   SelectionMode = 20,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   CapsLock = 21,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   NumLock = 22,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   OverType = 23,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   RevisionMarking = 24,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   InFootnoteEndnotePane = 25,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   InCommentPane = 26,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   InHeaderFooter = 28,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   AtEndOfRowMarker = 31,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   ReferenceOfType = 32,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   HeaderFooterType = 33,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   InMasterDocument = 34,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   InFootnote = 35,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   InEndnote = 36,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   InWordMail = 37,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   InClipboard = 38,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   InCoverPage = 41,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   InBibliography = 42,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   InCitation = 43,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   InFieldCode = 44,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   InFieldResult = 45,
  /// <summary>
  /// Specifies the type of information returned about a specified selection or range.
  /// </summary>
   InContentControl = 46
}
