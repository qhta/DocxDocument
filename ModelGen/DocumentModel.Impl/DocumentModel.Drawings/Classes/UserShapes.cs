namespace DocumentModel.Drawings;

/// <summary>
/// User Shapes.
/// </summary>
public class UserShapesImpl: ModelElementImpl, UserShapes
{
  public DocumentFormat.OpenXml.Drawing.Charts.UserShapes? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.UserShapes?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<RelativeAnchorSize>? RelativeAnchorSizes
  {
    get;
    set;
  }
  
  public Collection<AbsoluteAnchorSize>? AbsoluteAnchorSizes
  {
    get;
    set;
  }
  
}
