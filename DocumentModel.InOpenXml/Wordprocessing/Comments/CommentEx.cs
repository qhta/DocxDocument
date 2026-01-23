namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies additional information for a single comment in the current document.
/// This class extends <see cref="CollectionItem"/> and provides properties for the paragraph identifier of the last paragraph in the comment, the parent comment's last paragraph identifier, and the completion status, enabling advanced tracking and management of comment threads and resolution status.
/// </summary>
public class CommentEx: ModelElement<DXO13W.CommentEx>
{
  
  /// <summary>
  /// Paragraph identifier (paraId) of the last paragraph in the associated comment.
  /// </summary>
  public HexInt? ParaId { get; set; }
  
  /// <summary>
  /// Paragraph identifier (paraId) of the last paragraph in the parent comment to which the associated comment is a reply.
  /// </summary>
  public HexInt? ParaIdParent { get; set; }
  
  /// <summary>
  /// Indicates whether the associated comment is marked as done (resolved).
  /// </summary>
  public bool? Done { get; set; }
}