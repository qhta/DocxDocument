namespace DocumentModel.Wordprocessing;

/// <summary>
/// DrawingML Object.
/// </summary>
public class DrawingImpl: ModelElementImpl, Drawing
{
  public DocumentFormat.OpenXml.Wordprocessing.Drawing? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Drawing?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DrawingImpl(): base() {}
  
  public DrawingImpl(DocumentFormat.OpenXml.Wordprocessing.Drawing openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Drawing Element Anchor.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.Anchor? Anchor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Inline Drawing Object.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.Inline? Inline
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
