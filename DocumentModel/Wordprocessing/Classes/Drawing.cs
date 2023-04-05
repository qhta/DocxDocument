using DocumentModel.Drawings.Wordprocessing;

namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   DrawingML Object.
/// </summary>
public class Drawing: ModelElement, IRunContent, IEmbeddedObjectContent
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