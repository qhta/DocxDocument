namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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
  public WebSettings? WebSettings { get; set; }
}