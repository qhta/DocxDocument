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
  
  public Collection<Point1>? Points
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
