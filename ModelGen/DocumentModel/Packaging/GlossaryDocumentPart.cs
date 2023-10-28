namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type is a supplementary document storage location which stores the definition and content for content that shall be carried with the document for future insertion and/or use, but which shall not be visible within the contents of the main document story.
/// </summary>
public partial class GlossaryDocumentPart
{
  public String? ContentType { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DMW.GlossaryDocument? GlossaryDocument { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
