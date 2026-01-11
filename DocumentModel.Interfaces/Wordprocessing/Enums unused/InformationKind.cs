namespace DocumentModel.Wordprocessing;

/// <summary>
/// Information types for range queries.
/// </summary>
public enum InformationKind
{
  /// <summary>Active end adjusted</summary>
  ActiveEndAdjusted,
  /// <summary>Active end section number</summary>
  ActiveEndSectionNumber,
  /// <summary>Active end page number</summary>
  ActiveEndPageNumber,
  /// <summary>At end of row marker</summary>
  AtEndOfRowMarker,
  /// <summary>Caps lock</summary>
  CapsLock,
  /// <summary>End of range column number</summary>
  EndOfRangeColumnNumber,
  /// <summary>End of range row number</summary>
  EndOfRangeRowNumber,
  /// <summary>Frame is selected</summary>
  FrameIsSelected,
  /// <summary>Header footer type</summary>
  HeaderFooterType,
  /// <summary>Horizontal position relative to page</summary>
  HorizontalPositionRelativeToPage,
  /// <summary>Horizontal position relative to text boundary</summary>
  HorizontalPositionRelativeToTextBoundary,
  /// <summary>In comment</summary>
  InComment,
  /// <summary>In cover page</summary>
  InCoverPage,
  /// <summary>In endnote</summary>
  InEndnote,
  /// <summary>In footnote</summary>
  InFootnote,
  /// <summary>In footnote or endnote</summary>
  InFootnoteEndnote,
  /// <summary>In header footer</summary>
  InHeaderFooter,
  /// <summary>In master document</summary>
  InMasterDocument,
  /// <summary>In table</summary>
  InTable,
  /// <summary>In word mail</summary>
  InWordMail,
  /// <summary>Maximum number of columns</summary>
  MaximumNumberOfColumns,
  /// <summary>Maximum number of rows</summary>
  MaximumNumberOfRows,
  /// <summary>Number of pages in document</summary>
  NumberOfPagesInDocument,
  /// <summary>Number lock</summary>
  NumLock,
  /// <summary>Overtype mode</summary>
  OverType,
  /// <summary>Reference of type</summary>
  ReferenceOfType,
  /// <summary>Revision marking</summary>
  RevisionMarking,
  /// <summary>Selection mode</summary>
  SelectionMode,
  /// <summary>Start of range column number</summary>
  StartOfRangeColumnNumber,
  /// <summary>Start of range row number</summary>
  StartOfRangeRowNumber,
  /// <summary>Vertical position relative to page</summary>
  VerticalPositionRelativeToPage,
  /// <summary>Vertical position relative to text boundary</summary>
  VerticalPositionRelativeToTextBoundary,
  /// <summary>In bibliography</summary>
  InBibliography,
  /// <summary>In citation</summary>
  InCitation,
  /// <summary>In field code</summary>
  InFieldCode,
  /// <summary>In field result</summary>
  InFieldResult,
  /// <summary>In content control</summary>
  InContentControl,
  /// <summary>Content control type</summary>
  ContentControlType
}