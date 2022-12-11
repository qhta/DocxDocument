namespace DocumentModel.Drawings;

/// <summary>
/// List of Shape Paths.
/// </summary>
public class PathListImpl: ModelElementImpl, PathList
{
  public DocumentFormat.OpenXml.Drawing.PathList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.PathList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PathListImpl(): base() {}
  
  public PathListImpl(DocumentFormat.OpenXml.Drawing.PathList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<Path>? Paths
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
