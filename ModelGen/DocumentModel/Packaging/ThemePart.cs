namespace DocumentModel.Packaging;


/// <summary>
///   Defines the ThemePart
/// </summary>
public partial class ThemePart
{
  public String? ContentType { get; set; }
  
  public String? RelationshipType { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DMD.Theme? Theme { get; set; }
  
}
