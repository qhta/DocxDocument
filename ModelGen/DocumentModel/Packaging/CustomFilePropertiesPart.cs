namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part contains the names of custom file properties that apply to the package, their values, and the types of those values. A custom file property might be the name of the client for whom the document was prepared, a date/time on which some event happened, a document number, or some Boolean status flag.
/// </summary>
public partial class CustomFilePropertiesPart
{
  public String? ContentType { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Properties.CustomProperties? Properties { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
