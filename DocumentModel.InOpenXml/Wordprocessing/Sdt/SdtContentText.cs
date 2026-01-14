namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the configuration for text content controls in a structured document tag (SDT) in a Wordprocessing document.
/// This interface provides a property for allowing soft line breaks, enabling advanced customization of multiline or single-line text input in SDTs.
/// </summary>
public interface SdtContentText
{
  /// <summary>
  /// Indicates whether soft line breaks (multiline input) are allowed in the text content control.
  /// </summary>
  public bool? MultiLine { get; set; }
}