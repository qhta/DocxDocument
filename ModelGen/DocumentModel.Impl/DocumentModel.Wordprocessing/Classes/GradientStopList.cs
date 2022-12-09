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
  
  public Collection<GradientStop>? GradientStops
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
