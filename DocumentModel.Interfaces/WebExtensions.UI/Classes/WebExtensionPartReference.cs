namespace DocumentModel.WebExtensions.UI;

/// <summary>
///   Defines the WebExtensionPartReference Class.
/// </summary>
public interface WebExtensionPartReference: IModelElement
{
  /// <summary>
  ///   id
  /// </summary>
  public string? Id { get; set; }
}