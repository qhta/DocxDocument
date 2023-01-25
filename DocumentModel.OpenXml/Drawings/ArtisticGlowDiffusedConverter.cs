namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticGlowDiffused Class.
/// </summary>
public static class ArtisticGlowDiffusedConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticGlowDiffused openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO2010Draw.ArtisticGlowDiffused openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticGlowDiffused openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// intensity, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetIntensity(DXO2010Draw.ArtisticGlowDiffused openXmlElement)
  {
    return openXmlElement?.Intensity?.Value;
  }
  
  private static bool CmpIntensity(DXO2010Draw.ArtisticGlowDiffused openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Intensity?.Value == value) return true;
    diffs?.Add(objName, "Intensity", openXmlElement?.Intensity?.Value, value);
    return false;
  }
  
  private static void SetIntensity(DXO2010Draw.ArtisticGlowDiffused openXmlElement, Int32? value)
  {
    openXmlElement.Intensity = value;
  }
  
  public static DMDraws.ArtisticGlowDiffused? CreateModelElement(DXO2010Draw.ArtisticGlowDiffused? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ArtisticGlowDiffused();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Intensity = GetIntensity(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.ArtisticGlowDiffused? openXmlElement, DMDraws.ArtisticGlowDiffused? value, DiffList? diffs, string? objName)
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticGlowDiffused? value)
    where OpenXmlElementType: DXO2010Draw.ArtisticGlowDiffused, new()
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
