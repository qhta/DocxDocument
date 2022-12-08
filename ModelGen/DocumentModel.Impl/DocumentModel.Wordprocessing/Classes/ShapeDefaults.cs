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
