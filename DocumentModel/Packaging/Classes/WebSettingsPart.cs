namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WebSettingsPart
/// </summary>
public partial class WebSettingsPart
{
  public String? ContentType { get; set; }
  
  public String? RelationshipType { get; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.WebSettings? WebSettings { get; set; }
  
}
