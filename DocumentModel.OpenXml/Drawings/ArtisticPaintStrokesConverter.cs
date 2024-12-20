namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticPaintStrokes Class.
/// </summary>
public static class ArtisticPaintStrokesConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO10D.ArtisticPaintStrokes openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO10D.ArtisticPaintStrokes openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO10D.ArtisticPaintStrokes openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// intensity, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetIntensity(DXO10D.ArtisticPaintStrokes openXmlElement)
  {
    return openXmlElement?.Intensity?.Value;
  }
  
  private static bool CmpIntensity(DXO10D.ArtisticPaintStrokes openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Intensity?.Value == value) return true;
    diffs?.Add(objName, "Intensity", openXmlElement?.Intensity?.Value, value);
    return false;
  }
  
  private static void SetIntensity(DXO10D.ArtisticPaintStrokes openXmlElement, Int32? value)
  {
    openXmlElement.Intensity = value;
  }
  
  public static DMD.ArtisticPaintStrokes? CreateModelElement(DXO10D.ArtisticPaintStrokes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ArtisticPaintStrokes();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Intensity = GetIntensity(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10D.ArtisticPaintStrokes? openXmlElement, DMD.ArtisticPaintStrokes? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTransparancy(openXmlElement, value.Transparancy, diffs, objName, propName))
        ok = false;
      if (!CmpIntensity(openXmlElement, value.Intensity, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ArtisticPaintStrokes value)
    where OpenXmlElementType: DXO10D.ArtisticPaintStrokes, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.ArtisticPaintStrokes openXmlElement, DMD.ArtisticPaintStrokes value)
  {
    SetTransparancy(openXmlElement, value?.Transparancy);
    SetIntensity(openXmlElement, value?.Intensity);
  }
}
