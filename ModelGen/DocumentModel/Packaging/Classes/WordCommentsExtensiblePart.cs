namespace DocumentModel.Packaging;


/// <summary>
///   Defines the WordCommentsExtensiblePart
/// </summary>
public partial class WordCommentsExtensiblePart
{
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public CommentsExtensible? CommentsExtensible { get; set; }
  
  public String? ContentType { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
