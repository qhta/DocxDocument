namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoPolygon Class.
/// </summary>
public static class GeoPolygonConverter
{
  /// <summary>
  /// polygonId, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetPolygonId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygon? openXmlElement)
  {
    return openXmlElement?.PolygonId?.Value;
  }
  
  public static void SetPolygonId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygon? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.PolygonId = new StringValue { Value = value };
      else
        openXmlElement.PolygonId = null;
  }
  
  /// <summary>
  /// numPoints, this property is only available in Office 2016 and later.
  /// </summary>
  public static Int64? GetNumPoints(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygon? openXmlElement)
  {
    return openXmlElement?.NumPoints?.Value;
  }
  
  public static void SetNumPoints(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygon? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.NumPoints = value;
  }
  
  /// <summary>
  /// pcaRings, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetPcaRings(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygon? openXmlElement)
  {
    return openXmlElement?.PcaRings?.Value;
  }
  
  public static void SetPcaRings(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygon? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.PcaRings = new StringValue { Value = value };
      else
        openXmlElement.PcaRings = null;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoPolygon? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygon? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoPolygon();
      value.PolygonId = GetPolygonId(openXmlElement);
      value.NumPoints = GetNumPoints(openXmlElement);
      value.PcaRings = GetPcaRings(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoPolygon? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygon, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPolygonId(openXmlElement, value?.PolygonId);
      SetNumPoints(openXmlElement, value?.NumPoints);
      SetPcaRings(openXmlElement, value?.PcaRings);
      return openXmlElement;
    }
    return default;
  }
}
