namespace DocumentModel.Packaging;


/// <summary>
///   Defines the WordprocessingCommentsExPart
/// </summary>
public partial class WordprocessingCommentsExPart
{
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DMW13.CommentsEx? CommentsEx { get; set; }
  
  public String? ContentType { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
