namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the placeholder configuration for a structured document tag (SDT) in a Wordprocessing document.
/// This interface provides a property for referencing a document part to be used as placeholder text, enabling advanced customization of placeholder content for SDTs.
/// </summary>
public class SdtPlaceholder: ModelElement
{
  /// <summary>
  /// Document part reference used as placeholder text for the SDT.
  /// </summary>
  public string? DocPartReference { get; set; }
}