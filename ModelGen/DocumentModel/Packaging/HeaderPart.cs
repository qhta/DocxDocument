namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains the information about a header displayed for one or more sections.
/// </summary>
public partial class HeaderPart
{
  public String? ContentType { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.Header? Header { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
