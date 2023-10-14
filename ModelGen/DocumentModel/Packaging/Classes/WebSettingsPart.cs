namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains the definition for web-specific settings used by this document.
/// </summary>
public partial class WebSettingsPart
{
  public String? ContentType { get; set; }
  
  public String? RelationshipType { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DM.WebSettings? WebSettings { get; set; }
  
}
