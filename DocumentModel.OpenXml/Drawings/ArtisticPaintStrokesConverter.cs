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
  
  private static bool CmpTransparancy(DXO2010Draw.ArtisticPaintStrokes openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Transparancy?.Value == value;
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
  
  private static bool CmpIntensity(DXO2010Draw.ArtisticPaintStrokes openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Intensity?.Value == value;
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
  
  public static bool CompareModelElement(DXO2010Draw.ArtisticPaintStrokes? openXmlElement, DMDraws.ArtisticPaintStrokes? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTransparancy(openXmlElement, value.Transparancy, diffs, objName))
        ok = false;
      if (!CmpIntensity(openXmlElement, value.Intensity, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
