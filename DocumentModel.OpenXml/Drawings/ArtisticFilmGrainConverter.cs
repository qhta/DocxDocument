namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticFilmGrain Class converter from/to OpenXml.
///</summary>
public static class ArtisticFilmGrainConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticFilmGrain openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO2010Draw.ArtisticFilmGrain openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticFilmGrain openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// grainSize, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetGrainSize(DXO2010Draw.ArtisticFilmGrain openXmlElement)
  {
    return openXmlElement?.GrainSize?.Value;
  }
  
  private static bool CmpGrainSize(DXO2010Draw.ArtisticFilmGrain openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GrainSize?.Value == value) return true;
    diffs?.Add(objName, "GrainSize", openXmlElement?.GrainSize?.Value, value);
    return false;
  }
  
  private static void SetGrainSize(DXO2010Draw.ArtisticFilmGrain openXmlElement, Int32? value)
  {
    openXmlElement.GrainSize = value;
  }
  
  public static DocumentModel.Drawings.ArtisticFilmGrain? CreateModelElement(DXO2010Draw.ArtisticFilmGrain? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticFilmGrain();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.GrainSize = GetGrainSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.ArtisticFilmGrain? openXmlElement, DMDraws.ArtisticFilmGrain? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTransparancy(openXmlElement, value.Transparancy, diffs, objName))
        ok = false;
      if (!CmpGrainSize(openXmlElement, value.GrainSize, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticFilmGrain value)
    where OpenXmlElementType: DXO2010Draw.ArtisticFilmGrain, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010Draw.ArtisticFilmGrain openXmlElement, DMDraws.ArtisticFilmGrain value)
  {
    SetTransparancy(openXmlElement, value?.Transparancy);
    SetGrainSize(openXmlElement, value?.GrainSize);
  }
}
