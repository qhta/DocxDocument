namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlideCommentsPart
/// </summary>
public interface ISlideCommentsPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Presentation.ICommentList? CommentList { get ; set; }
  
  public System.String? ContentType { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
}
