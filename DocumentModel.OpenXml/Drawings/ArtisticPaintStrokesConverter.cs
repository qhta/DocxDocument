namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticPaintStrokes Class.
/// </summary>
public static class ArtisticPaintStrokesConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes? openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  public static void SetTransparancy(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// intensity, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetIntensity(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes? openXmlElement)
  {
    return openXmlElement?.Intensity?.Value;
  }
  
  public static void SetIntensity(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Intensity = value;
  }
  
  public static DocumentModel.Drawings.ArtisticPaintStrokes? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticPaintStrokes();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Intensity = GetIntensity(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArtisticPaintStrokes? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
