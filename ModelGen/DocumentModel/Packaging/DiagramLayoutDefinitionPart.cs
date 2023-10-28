namespace DocumentModel.Packaging;


/// <summary>
///   Defines the DiagramLayoutDefinitionPart
/// </summary>
public partial class DiagramLayoutDefinitionPart
{
  public String? ContentType { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DMDD.LayoutDefinition? LayoutDefinition { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
