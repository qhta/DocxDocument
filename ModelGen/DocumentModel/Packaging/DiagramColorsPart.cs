namespace DocumentModel.Packaging;


/// <summary>
///   Defines the DiagramColorsPart
/// </summary>
public partial class DiagramColorsPart
{
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DMDD.ColorsDefinition? ColorsDefinition { get; set; }
  
  public String? ContentType { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
