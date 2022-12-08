namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoChildTypes Class.
/// </summary>
public class GeoChildTypesImpl: ModelElementImpl, GeoChildTypes
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildTypes? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildTypes?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<String>? EntityTypes
  {
    get;
    set;
  }
  
}
