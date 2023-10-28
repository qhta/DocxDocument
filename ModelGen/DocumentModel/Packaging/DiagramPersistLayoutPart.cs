namespace DocumentModel.Packaging;


/// <summary>
///   Defines the DiagramPersistLayoutPart
/// </summary>
public partial class DiagramPersistLayoutPart
{
  public String? ContentType { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DMDO.Drawing? Drawing { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
