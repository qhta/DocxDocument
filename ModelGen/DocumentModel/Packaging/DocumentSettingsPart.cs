namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains all the document's properties.
/// </summary>
public partial class DocumentSettingsPart
{
  public String? ContentType { get; set; }
  
  public String? RelationshipType { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DM.DocumentSettings? Settings { get; set; }
  
}
