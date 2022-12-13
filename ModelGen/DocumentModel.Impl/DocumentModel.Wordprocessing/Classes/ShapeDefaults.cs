namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Main Document.
/// </summary>
public class ShapeDefaultsImpl: ModelElementImpl, ShapeDefaults
{
  public DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ShapeDefaultsImpl(): base() {}
  
  public ShapeDefaultsImpl(DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Vml.ShapeDefaults? ChildShapeDefaults
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Vml.ShapeLayout? ShapeLayout
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
