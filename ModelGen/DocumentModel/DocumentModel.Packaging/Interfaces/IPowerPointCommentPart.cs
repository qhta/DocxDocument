namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PowerPointCommentPart
/// </summary>
public interface IPowerPointCommentPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Presentation.ICommentList? CommentList { get ; set; }
  
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
