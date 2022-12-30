namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordprocessingPeoplePart
/// </summary>
public partial class WordprocessingPeoplePart
{
  public String? ContentType { get; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.People? People { get; set; }
  
  public String? RelationshipType { get; }
  
}
