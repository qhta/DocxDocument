namespace DocumentModel.Drawings;

/// <summary>
/// Point List.
/// </summary>
public class PointListImpl: ModelElementImpl, PointList
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.PointList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.PointList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PointListImpl(): base() {}
  
  public PointListImpl(DocumentFormat.OpenXml.Drawing.Diagrams.PointList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<Point>? Points
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
