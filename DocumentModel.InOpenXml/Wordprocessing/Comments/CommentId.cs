namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents identifiers for a comment in a WordprocessingML document, providing both paragraph-level and durable identification.
///   This interface extends <see cref="CollectionItem"/> and enables stable references to comments for tracking, synchronization, and platform transitions. It supports paragraph-level tracking and global identification for collaborative editing and document operations.
/// </summary>
public interface CommentId: ICollectionItem
{
  
  /// <summary>
  ///   Hexadecimal identifier of the paragraph associated with this comment, used for precise paragraph-level tracking and navigation.
  /// </summary>
  public HexInt? ParaId { get; set; }
  
  /// <summary>
  ///   Durable identifier that persists across document versions, platforms, and synchronization operations, providing a globally unique reference to the comment.
  /// </summary>
  public HexInt? DurableId { get; set; }
}