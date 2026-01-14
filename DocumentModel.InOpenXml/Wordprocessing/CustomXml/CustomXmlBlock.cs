namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a custom XML element that surrounds one or more block-level structures (such as paragraphs, tables, etc.) in a WordprocessingML document.
  /// This interface extends <see cref="CustomXmlElement"/>, <see cref="CustomXmlBlockContentCollection"/>, <see cref="StoryContent"/>, <see cref="TableCellContent"/>, <see cref="SdtBlockContent"/>, <see cref="CustomXmlBlockContent"/>, and <see cref="CommentContent"/>, enabling advanced integration, annotation, and schema-based processing of custom XML data within block-level document content.
  /// The attributes on this element specify the name and namespace URI of the custom XML element.
  /// </summary>
  public interface CustomXmlBlock : CustomXmlElement,
    CustomXmlBlockContentCollection,
    StoryContent, TableCellContent, SdtBlockContent, CustomXmlBlockContent, CommentContent
  {
  }