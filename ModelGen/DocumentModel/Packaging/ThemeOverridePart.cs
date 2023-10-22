namespace DocumentModel.Packaging;


/// <summary>
///   Defines the ThemeOverridePart
/// </summary>
public partial class ThemeOverridePart
{
  public String? ContentType { get; set; }
  
  public String? RelationshipType { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Drawings.ThemeOverride? ThemeOverride { get; set; }
  
}
