namespace DocumentModel.Drawings;

/// <summary>
/// Gradient Stop List.
/// </summary>
public class GradientStopListImpl: ModelElementImpl, GradientStopList
{
  public DocumentFormat.OpenXml.Drawing.GradientStopList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.GradientStopList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GradientStopListImpl(): base() {}
  
  public GradientStopListImpl(DocumentFormat.OpenXml.Drawing.GradientStopList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Drawings.GradientStop? GradientStop
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
