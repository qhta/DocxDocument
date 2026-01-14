namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines an abstract bidirectional element for WordprocessingML documents.
/// This class extends <see cref="ElementCollection{BidirectionalContent}"/>, <see cref="IParagraphContent"/>, <see cref="ISdtRunContent"/>, and <see cref="BidirectionalContent"/>, enabling advanced management of content that supports both left-to-right and right-to-left text flows within paragraphs and structured document tags.
/// </summary>
public interface IBidirectionalElement : IElementCollection<IBidirectionalContent>,
  IParagraphContent,
  ISdtRunContent
{
    
  /// <summary>
  /// Specifies the text direction (left-to-right or right-to-left) for the bidirectional element.
  /// </summary>
  public DirectionKind? Type { get; set; }
}