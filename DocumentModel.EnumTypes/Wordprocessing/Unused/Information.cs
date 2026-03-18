namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Information enumeration.
/// Used in types such as ShouldSerializeCodeFixProvider, AssemblyInfo, ShapeKind.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum Information
{
  /// <summary>Active end adjusted</summary>
  [OpenXmlEnumValue("ActiveEndAdjusted")]
  ActiveEndAdjusted,
  /// <summary>Active end section number</summary>
  [OpenXmlEnumValue("ActiveEndSectionNumber")]
  ActiveEndSectionNumber,
  /// <summary>Active end page number</summary>
  [OpenXmlEnumValue("ActiveEndPageNumber")]
  ActiveEndPageNumber,
  /// <summary>At end of row marker</summary>
  [OpenXmlEnumValue("AtEndOfRowMarker")]
  AtEndOfRowMarker,
  /// <summary>Caps lock</summary>
  [OpenXmlEnumValue("CapsLock")]
  CapsLock,
  /// <summary>End of range column number</summary>
  [OpenXmlEnumValue("EndOfRangeColumnNumber")]
  EndOfRangeColumnNumber,
  /// <summary>End of range row number</summary>
  [OpenXmlEnumValue("EndOfRangeRowNumber")]
  EndOfRangeRowNumber,
  /// <summary>Frame is selected</summary>
  [OpenXmlEnumValue("FrameIsSelected")]
  FrameIsSelected,
  /// <summary>Header footer type</summary>
  [OpenXmlEnumValue("HeaderFooterType")]
  HeaderFooterType,
  /// <summary>Horizontal position relative to page</summary>
  [OpenXmlEnumValue("HorizontalPositionRelativeToPage")]
  HorizontalPositionRelativeToPage,
  /// <summary>Horizontal position relative to text boundary</summary>
  [OpenXmlEnumValue("HorizontalPositionRelativeToTextBoundary")]
  HorizontalPositionRelativeToTextBoundary,
  /// <summary>In comment</summary>
  [OpenXmlEnumValue("InComment")]
  InComment,
  /// <summary>In cover page</summary>
  [OpenXmlEnumValue("InCoverPage")]
  InCoverPage,
  /// <summary>In endnote</summary>
  [OpenXmlEnumValue("InEndnote")]
  InEndnote,
  /// <summary>In footnote</summary>
  [OpenXmlEnumValue("InFootnote")]
  InFootnote,
  /// <summary>In footnote or endnote</summary>
  [OpenXmlEnumValue("InFootnoteEndnote")]
  InFootnoteEndnote,
  /// <summary>In header footer</summary>
  [OpenXmlEnumValue("InHeaderFooter")]
  InHeaderFooter,
  /// <summary>In master document</summary>
  [OpenXmlEnumValue("InMasterDocument")]
  InMasterDocument,
  /// <summary>In table</summary>
  [OpenXmlEnumValue("InTable")]
  InTable,
  /// <summary>In word mail</summary>
  [OpenXmlEnumValue("InWordMail")]
  InWordMail,
  /// <summary>Maximum number of columns</summary>
  [OpenXmlEnumValue("MaximumNumberOfColumns")]
  MaximumNumberOfColumns,
  /// <summary>Maximum number of rows</summary>
  [OpenXmlEnumValue("MaximumNumberOfRows")]
  MaximumNumberOfRows,
  /// <summary>Number of pages in document</summary>
  [OpenXmlEnumValue("NumberOfPagesInDocument")]
  NumberOfPagesInDocument,
  /// <summary>Number lock</summary>
  [OpenXmlEnumValue("NumLock")]
  NumLock,
  /// <summary>Overtype mode</summary>
  [OpenXmlEnumValue("OverType")]
  OverType,
  /// <summary>Reference of type</summary>
  [OpenXmlEnumValue("ReferenceOfType")]
  ReferenceOfType,
  /// <summary>Revision marking</summary>
  [OpenXmlEnumValue("RevisionMarking")]
  RevisionMarking,
  /// <summary>Selection mode</summary>
  [OpenXmlEnumValue("SelectionMode")]
  SelectionMode,
  /// <summary>Start of range column number</summary>
  [OpenXmlEnumValue("StartOfRangeColumnNumber")]
  StartOfRangeColumnNumber,
  /// <summary>Start of range row number</summary>
  [OpenXmlEnumValue("StartOfRangeRowNumber")]
  StartOfRangeRowNumber,
  /// <summary>Vertical position relative to page</summary>
  [OpenXmlEnumValue("VerticalPositionRelativeToPage")]
  VerticalPositionRelativeToPage,
  /// <summary>Vertical position relative to text boundary</summary>
  [OpenXmlEnumValue("VerticalPositionRelativeToTextBoundary")]
  VerticalPositionRelativeToTextBoundary,
  /// <summary>In bibliography</summary>
  [OpenXmlEnumValue("InBibliography")]
  InBibliography,
  /// <summary>In citation</summary>
  [OpenXmlEnumValue("InCitation")]
  InCitation,
  /// <summary>In field code</summary>
  [OpenXmlEnumValue("InFieldCode")]
  InFieldCode,
  /// <summary>In field result</summary>
  [OpenXmlEnumValue("InFieldResult")]
  InFieldResult,
  /// <summary>In content control</summary>
  [OpenXmlEnumValue("InContentControl")]
  InContentControl,
  /// <summary>Content control type</summary>
  [OpenXmlEnumValue("ContentControlType")]
  ContentControlType
}
