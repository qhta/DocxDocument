namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies all of the comments defined Iin the current document. 
/// </summary>
public class DocComments: ModelElement
{
  /// <summary>
  /// IComments collections.
  /// </summary>
  public IComments? IComments { get; set; }

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
