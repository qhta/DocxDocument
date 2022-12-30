namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordCommentsExtensiblePart
/// </summary>
public partial class WordCommentsExtensiblePart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.CommentsExtensible? CommentsExtensible { get; set; }
  
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
}
