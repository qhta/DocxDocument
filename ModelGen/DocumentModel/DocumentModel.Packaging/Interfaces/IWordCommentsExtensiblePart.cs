namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordCommentsExtensiblePart
/// </summary>
public interface IWordCommentsExtensiblePart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.ICommentsExtensible? CommentsExtensible { get ; set; }
  
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
