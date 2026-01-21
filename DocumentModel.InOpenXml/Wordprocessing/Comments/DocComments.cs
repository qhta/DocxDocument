namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies all of the comments defined in the current WordprocessingML document.
/// This interface provides properties for collections of comments, extended comments, comment identifiers, and extensible comments, enabling advanced tracking, organization, and management of comment metadata and content throughout the document.
/// </summary>
public partial class DocComments : ModelElement
{
  /// <summary>
  /// Collection of comments, providing access to standard comment annotations in the document.
  /// </summary>
  public Comments? Comments { get; set; }
  /// <summary>
  /// Collection of extended comments, providing access to additional metadata and behaviors for comments.
  /// </summary>
  public CommentsEx? CommentsEx { get; set; }
  /// <summary>
  /// Collection of comment identifiers, enabling persistent and stable references to comments for tracking and synchronization.
  /// </summary>
  public CommentsIds? CommentsIds { get; set; }
  /// <summary>
  /// Collection of extensible comments, supporting advanced extensibility and custom metadata for comments.
  /// </summary>
  public CommentsExtensible? CommentsExtensible { get; set; }
}