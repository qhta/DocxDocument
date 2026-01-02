namespace DocumentModel.Wordprocessing;
/// <summary>
///   This element specifies all of the comments defined in the current document. 
/// </summary>
public class DocComments: ModelElement
{
  /// <summary>
  /// Comments collections.
  /// </summary>
  public Comments? Comments { get; set; }
  /// <summary>
  /// CommentsEx collections.
  /// </summary>
  public CommentsEx? CommentsEx { get; set; }
  /// <summary>
  /// CommentsIds collections.
  /// </summary>
  public CommentsIds? CommentsIds { get; set; }
  /// <summary>
  /// CommentsExtensible collections.
  /// </summary>
  public CommentsExtensible? CommentsExtensible { get; set; }
}