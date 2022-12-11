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
  
  public UserShapesImpl(): base() {}
  
  public UserShapesImpl(DocumentFormat.OpenXml.Drawing.Charts.UserShapes openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public RelativeAnchorSize? RelativeAnchorSize
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public AbsoluteAnchorSize? AbsoluteAnchorSize
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
