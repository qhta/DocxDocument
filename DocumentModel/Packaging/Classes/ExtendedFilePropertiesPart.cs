namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ExtendedFilePropertiesPart
/// </summary>
public partial class ExtendedFilePropertiesPart
{
  public String? ContentType { get; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Properties.ExtendedProperties? Properties { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
