namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains a definition for the structure of each unique numbering definition in this document.
/// </summary>
public partial class NumberingDefinitionsPart
{
  public String? ContentType { get; set; }
  
  
  /// <summary>
  ///   Gets the ImageParts of the NumberingDefinitionsPart
  /// </summary>
  public Collection? ImageParts { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Numbering? Numbering { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
