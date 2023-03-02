using DocumentModel.Drawings.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   DrawingML Object.
/// </summary>
public record Drawing: RunElement, EmbeddedObjectElement
{
  /// <summary>
  ///   Drawing Element Anchor.
  /// </summary>
  public Anchor? Anchor { get; set; }

  /// <summary>
  ///   Inline Drawing Object.
  /// </summary>
  public Inline? Inline { get; set; }
}