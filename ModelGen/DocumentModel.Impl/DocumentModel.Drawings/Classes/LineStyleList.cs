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
  
  public Collection<Outline>? Outlines
  {
    get;
    set;
  }
  
}
