namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DocumentTasksPart
/// </summary>
public partial interface DocumentTasksPart
{
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Tasks? Tasks { get; set; }
  
}
