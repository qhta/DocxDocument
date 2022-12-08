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
    get;
    set;
  }
  
  public Collection<DocumentModel.Vml.ShapeLayout>? ShapeLayouts
  {
    get;
    set;
  }
  
}
