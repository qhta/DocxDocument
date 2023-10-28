namespace DocumentModel.Packaging;


/// <summary>
///   Defines the RibbonAndBackstageCustomizationsPart
/// </summary>
public partial class RibbonAndBackstageCustomizationsPart
{
  public String? ContentType { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DMCUI10.CustomUI? CustomUI { get; set; }
  
  public String? RelationshipType { get; set; }
  
}
