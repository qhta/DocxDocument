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
  
  public Collection<DocumentModel.Vml.ShapeDefaults>? ShapeDefaultses
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<DocumentModel.Vml.ShapeLayout>? ShapeLayouts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
