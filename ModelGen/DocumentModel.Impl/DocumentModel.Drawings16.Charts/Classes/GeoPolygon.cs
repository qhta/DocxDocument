namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the GeoPolygon Class.
/// </summary>
public class GeoPolygonImpl: ModelElementImpl, GeoPolygon
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygon? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygon?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoPolygonImpl(): base() {}
  
  public GeoPolygonImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygon openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// polygonId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? PolygonId
  {
    get => (System.String?)OpenXmlElement?.PolygonId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PolygonId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// numPoints, this property is only available in Office 2016 and later.
  /// </summary>
  public Int32? NumPoints
  {
    get => (System.Int32?)OpenXmlElement?.NumPoints?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NumPoints = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// pcaRings, this property is only available in Office 2016 and later.
  /// </summary>
  public String? PcaRings
  {
    get => (System.String?)OpenXmlElement?.PcaRings?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PcaRings = (System.String?)value;
    }
  }
  
}
