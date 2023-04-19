namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies additional information for a single comment in the current document.
/// </summary>
public class CommentEx: ModelElement
{
  /// <summary>
  ///   Specifies the paraId of the last paragraph in the associated comment.
  /// </summary>
  public HexInt? ParaId { get; set; }

  /// <summary>
  ///   Specifies the paraId of the last paragraph in the comment to which the associated comment is a reply.
  /// </summary>
  public HexInt? ParaIdParent { get; set; }

  /// <summary>
  ///   Specifies whether the associated comment is marked as done. 
  /// </summary>
  public bool? Done { get; set; }
}