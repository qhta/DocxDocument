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
  
  public Collection<GradientStop>? GradientStops
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
