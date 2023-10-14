namespace DocumentModel.Packaging;


/// <summary>
///   Defines the DocumentTasksPart
/// </summary>
public partial class DocumentTasksPart
{
  public String? ContentType { get; set; }
  
  public String? RelationshipType { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DM.Tasks? Tasks { get; set; }
  
}
