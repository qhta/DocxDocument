namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoCache Class.
/// </summary>
public class GeoCacheImpl: ModelElementImpl, GeoCache
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoCache? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoCache?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// provider, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Provider
  {
    get;
    set;
  }
  
  public Collection<String>? Xsdbase64Binaries
  {
    get;
    set;
  }
  
  public Collection<Clear>? Clears
  {
    get;
    set;
  }
  
}
