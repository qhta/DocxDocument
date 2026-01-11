namespace DocumentModel.WebExtensions.UI;

/// <summary>
/// Represents a reference to a web extension part in a WordprocessingML document.
/// This interface provides a property for the part identifier, enabling advanced linking and integration of web extension components within the document user interface.
/// </summary>
public interface WebExtensionPartReference
{
  /// <summary>
  /// Identifier for the web extension part reference.
  /// </summary>
  public string? Id { get; set; }
}