namespace DocumentModel.WebExtensions.UI;

/// <summary>
///   Defines the WebExtensionPartReference Class.
/// </summary>
public class WebExtensionPartReference: ModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Id { get; set; }
}