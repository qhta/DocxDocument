namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WebSettingsPart
/// </summary>
public interface WebSettingsPart: IModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DMW.IWebSettings? WebSettings { get; set; }
}