namespace DocumentModel.Packaging;


/// <summary>
///   Defines the WordprocessingCommentsIdsPart
/// </summary>
public partial class WordprocessingCommentsIdsPart
{
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DMW.CommentsIds? CommentsIds { get; set; }
  
  public String? ContentType { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
