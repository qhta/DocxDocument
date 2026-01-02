namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WebSettingsPart
/// </summary>
public class WebSettingsPart: ModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public IWebSettings? WebSettings { get; set; }
}