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
  
  public Collection<ShapeGuide>? ShapeGuides
  {
    get;
    set;
  }
  
}
