namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the GradientStopList Class.
/// </summary>
public class GradientStopListImpl: ModelElementImpl, GradientStopList
{
  public DocumentFormat.OpenXml.Office2010.Word.GradientStopList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.GradientStopList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GradientStopListImpl(): base() {}
  
  public GradientStopListImpl(DocumentFormat.OpenXml.Office2010.Word.GradientStopList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public GradientStop? GradientStop
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
