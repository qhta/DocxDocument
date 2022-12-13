namespace DocumentModel.Vml;

/// <summary>
/// Defines the ShapeHandles Class.
/// </summary>
public class ShapeHandlesImpl: ModelElementImpl, ShapeHandles
{
  public DocumentFormat.OpenXml.Vml.ShapeHandles? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.ShapeHandles?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ShapeHandlesImpl(): base() {}
  
  public ShapeHandlesImpl(DocumentFormat.OpenXml.Vml.ShapeHandles openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Vml.ShapeHandle? ShapeHandle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
