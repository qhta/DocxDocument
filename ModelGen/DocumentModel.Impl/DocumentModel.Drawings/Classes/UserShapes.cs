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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<AbsoluteAnchorSize>? AbsoluteAnchorSizes
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
