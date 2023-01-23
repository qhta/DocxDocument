namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticFilmGrain Class.
/// </summary>
public static class ArtisticFilmGrainConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticFilmGrain openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO2010Draw.ArtisticFilmGrain openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Transparancy?.Value == value;
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
    return openXmlElement.GrainSize?.Value;
  }
  
  private static bool CmpGrainSize(DXO2010Draw.ArtisticFilmGrain openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GrainSize?.Value == value;
  }
  
  private static void SetGrainSize(DXO2010Draw.ArtisticFilmGrain openXmlElement, Int32? value)
  {
    openXmlElement.GrainSize = value;
  }
  
  public static DMDraws.ArtisticFilmGrain? CreateModelElement(DXO2010Draw.ArtisticFilmGrain? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ArtisticFilmGrain();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticFilmGrain? value)
    where OpenXmlElementType: DXO2010Draw.ArtisticFilmGrain, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetGrainSize(openXmlElement, value?.GrainSize);
      return openXmlElement;
    }
    return default;
  }
}
