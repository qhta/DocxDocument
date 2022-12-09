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
    get => (String?)OpenXmlElement?.Provider?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Provider = (System.String?)value;
    }
  }
  
  public Collection<String>? Xsdbase64Binaries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Clear>? Clears
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
