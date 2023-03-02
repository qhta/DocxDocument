namespace DocumentModel.WebExtensions.UI;

/// <summary>
///   Defines the WebExtensionPartReference Class.
/// </summary>
public record WebExtensionPartReference
{
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Id { get; set; }
}