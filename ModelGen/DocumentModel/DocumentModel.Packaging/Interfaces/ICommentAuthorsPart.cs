namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CommentAuthorsPart
/// </summary>
public interface ICommentAuthorsPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? CommentAuthorList { get ; set; }
  
  public System.String? ContentType { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
}
