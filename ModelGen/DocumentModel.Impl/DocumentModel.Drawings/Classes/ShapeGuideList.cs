namespace DocumentModel.Drawings;

/// <summary>
/// List of Shape Guides.
/// </summary>
public class ShapeGuideListImpl: ModelElementImpl, ShapeGuideList
{
  public DocumentFormat.OpenXml.Drawing.ShapeGuideList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ShapeGuideList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ShapeGuideListImpl(): base() {}
  
  public ShapeGuideListImpl(DocumentFormat.OpenXml.Drawing.ShapeGuideList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<ShapeGuide>? ShapeGuides
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
