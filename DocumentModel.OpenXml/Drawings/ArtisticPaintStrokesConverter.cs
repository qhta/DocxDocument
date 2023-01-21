namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticPaintStrokes Class.
/// </summary>
public static class ArtisticPaintStrokesConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticPaintStrokes openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticPaintStrokes openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// intensity, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetIntensity(DXO2010Draw.ArtisticPaintStrokes openXmlElement)
  {
    return openXmlElement.Intensity?.Value;
  }
  
  private static void SetIntensity(DXO2010Draw.ArtisticPaintStrokes openXmlElement, Int32? value)
  {
    openXmlElement.Intensity = value;
  }
  
  public static DMDraws.ArtisticPaintStrokes? CreateModelElement(DXO2010Draw.ArtisticPaintStrokes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ArtisticPaintStrokes();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Intensity = GetIntensity(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticPaintStrokes? value)
    where OpenXmlElementType: DXO2010Draw.ArtisticPaintStrokes, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetIntensity(openXmlElement, value?.Intensity);
      return openXmlElement;
    }
    return default;
  }
}
