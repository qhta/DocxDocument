namespace DocumentModel.Packaging;


/// <summary>
///   Defines the DiagramDataPart
/// </summary>
public partial class DiagramDataPart
{
  public String? ContentType { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DMDD.DataModelRoot? DataModelRoot { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
