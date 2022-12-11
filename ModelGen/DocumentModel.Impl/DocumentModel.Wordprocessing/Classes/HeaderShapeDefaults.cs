namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Header and Footer.
/// </summary>
public class HeaderShapeDefaultsImpl: ModelElementImpl, HeaderShapeDefaults
{
  public DocumentFormat.OpenXml.Wordprocessing.HeaderShapeDefaults? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.HeaderShapeDefaults?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public HeaderShapeDefaultsImpl(): base() {}
  
  public HeaderShapeDefaultsImpl(DocumentFormat.OpenXml.Wordprocessing.HeaderShapeDefaults openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Vml.ShapeDefaults? ShapeDefaults
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
