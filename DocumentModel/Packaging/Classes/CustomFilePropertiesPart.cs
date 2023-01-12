namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomFilePropertiesPart
/// </summary>
public partial class CustomFilePropertiesPart
{
  public String? ContentType { get; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Properties.CustomProperties? Properties { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
