namespace DocumentModel.Drawings;

/// <summary>
/// Line Style List.
/// </summary>
public class LineStyleListImpl: ModelElementImpl, LineStyleList
{
  public DocumentFormat.OpenXml.Drawing.LineStyleList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LineStyleList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LineStyleListImpl(): base() {}
  
  public LineStyleListImpl(DocumentFormat.OpenXml.Drawing.LineStyleList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Drawings.Outline? Outline
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
