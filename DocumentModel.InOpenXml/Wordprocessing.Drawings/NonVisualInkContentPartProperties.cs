using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents non-visual properties for an ink content part in a Wordprocessing document.
/// This interface provides configuration for comment status, content part locks, and extension data, enabling control over editing restrictions and extensibility for ink content parts.
/// </summary>
public class NonVisualInkContentPartProperties: ModelElement
{
  /// <summary>
  /// Indicates whether the ink content part is associated with a comment, distinguishing it from other ink elements.
  /// </summary>
  public bool? IsComment { get; set; }

  /// <summary>
  /// The set of locks applied to the content part, restricting modifications or interactions as defined by the document.
  /// </summary>
  public ContentPartLocks? ContentPartLocks { get; set; }

  /// <summary>
  /// List of OfficeArt extensions associated with the ink content part, allowing for additional metadata or custom features.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}