namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticFilmGrain Class.
/// </summary>
public static class ArtisticFilmGrainConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO10D.ArtisticFilmGrain openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO10D.ArtisticFilmGrain openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO10D.ArtisticFilmGrain openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// grainSize, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetGrainSize(DXO10D.ArtisticFilmGrain openXmlElement)
  {
    return openXmlElement?.GrainSize?.Value;
  }
  
  private static bool CmpGrainSize(DXO10D.ArtisticFilmGrain openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.GrainSize?.Value == value) return true;
    diffs?.Add(objName, "GrainSize", openXmlElement?.GrainSize?.Value, value);
    return false;
  }
  
  private static void SetGrainSize(DXO10D.ArtisticFilmGrain openXmlElement, Int32? value)
  {
    openXmlElement.GrainSize = value;
  }
  
  public static DMD.ArtisticFilmGrain? CreateModelElement(DXO10D.ArtisticFilmGrain? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ArtisticFilmGrain();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.GrainSize = GetGrainSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10D.ArtisticFilmGrain? openXmlElement, DMD.ArtisticFilmGrain? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTransparancy(openXmlElement, value.Transparancy, diffs, objName, propName))
        ok = false;
      if (!CmpGrainSize(openXmlElement, value.GrainSize, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ArtisticFilmGrain value)
    where OpenXmlElementType: DXO10D.ArtisticFilmGrain, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.ArtisticFilmGrain openXmlElement, DMD.ArtisticFilmGrain value)
  {
    SetTransparancy(openXmlElement, value?.Transparancy);
    SetGrainSize(openXmlElement, value?.GrainSize);
  }
}
