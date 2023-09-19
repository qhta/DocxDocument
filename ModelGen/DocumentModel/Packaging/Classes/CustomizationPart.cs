namespace DocumentModel.Packaging;


/// <summary>
///   Defines the CustomizationPart
/// </summary>
public partial class CustomizationPart
{
  public String? ContentType { get; set; }
  
  public String? RelationshipType { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.TemplateCommandGroup? TemplateCommandGroup { get; set; }
  
}
