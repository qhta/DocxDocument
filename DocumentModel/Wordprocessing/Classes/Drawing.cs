using DocumentModel.Drawings.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   DrawingML Object.
/// </summary>
public class Drawing: ModelElement, IRunElement, IEmbeddedObjectElement
{
  /// <summary>
  ///   Drawing Element Anchor.
  /// </summary>
  [XmlContentElement] public Anchor? Anchor { get; set; }

  /// <summary>
  ///   Inline Drawing Object.
  /// </summary>
  [XmlContentElement] public Inline? Inline { get; set; }
}