namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomizationPart
/// </summary>
public partial interface CustomizationPart
{
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.TemplateCommandGroup? TemplateCommandGroup { get; set; }
  
  /// <summary>
  /// Gets the WordAttachedToolbarsPart of the CustomizationPart
  /// </summary>
  public DocumentModel.Packaging.WordAttachedToolbarsPart? WordAttachedToolbarsPart { get; }
  
}
