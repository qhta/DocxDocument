namespace DocumentModel.Packaging;


/// <summary>
///   Defines the WordprocessingCommentsPart
/// </summary>
public partial class WordprocessingCommentsPart
{
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Comments? Comments { get; set; }
  
  public String? ContentType { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
