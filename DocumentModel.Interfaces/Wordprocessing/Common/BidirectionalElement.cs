namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines an abstract bidirectional element for WordprocessingML documents.
/// This interface extends <see cref="ElementCollection{BidirectionalContent}"/>, <see cref="ParagraphContent"/>, <see cref="SdtRunContent"/>, and <see cref="BidirectionalContent"/>, enabling advanced management of content that supports both left-to-right and right-to-left text flows within paragraphs and structured document tags.
/// </summary>
public interface BidirectionalElement : ElementCollection<BidirectionalContent>,
  ParagraphContent,
  SdtRunContent,
  BidirectionalContent
{
    
  /// <summary>
  /// Specifies the text direction (left-to-right or right-to-left) for the bidirectional element.
  /// </summary>
  public DirectionKind? Type { get; set; }
}