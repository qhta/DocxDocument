namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the contents of the body of the document - the main document editing surface.
///   The document body contains what is referred to as block-level markup - 
///   markup which can exist as a sibling element to paragraphs in a document.
/// </summary>
public class Body : BodyType, IModelElement<DXW.Body>
{
  /// <summary>
  /// Wrapped OpenXml element.
  /// </summary>
  public DXW.Body Element { get; private set; }

  /// <summary>
  /// Wrapping constructor.
  /// </summary>
  /// <param name="element">Wrapped body element</param>
  public Body(DXW.Body element)
  {
    Element = element;
  }
}