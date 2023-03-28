namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticGlass Class converter from/to OpenXml.
///</summary>
public static class ArtisticGlassConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticGlass openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO2010Draw.ArtisticGlass openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticGlass openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// scaling, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetScaling(DXO2010Draw.ArtisticGlass openXmlElement)
  {
    return openXmlElement?.Scaling?.Value;
  }
  
  private static bool CmpScaling(DXO2010Draw.ArtisticGlass openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Scaling?.Value == value) return true;
    diffs?.Add(objName, "Scaling", openXmlElement?.Scaling?.Value, value);
    return false;
  }
  
  private static void SetScaling(DXO2010Draw.ArtisticGlass openXmlElement, Int32? value)
  {
    openXmlElement.Scaling = value;
  }
  
  public static DocumentModel.Drawings.ArtisticGlass? CreateModelElement(DXO2010Draw.ArtisticGlass? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticGlass();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Scaling = GetScaling(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.ArtisticGlass? openXmlElement, DMDraws.ArtisticGlass? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTransparancy(openXmlElement, value.Transparancy, diffs, objName))
        ok = false;
      if (!CmpScaling(openXmlElement, value.Scaling, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticGlass value)
    where OpenXmlElementType: DXO2010Draw.ArtisticGlass, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010Draw.ArtisticGlass openXmlElement, DMDraws.ArtisticGlass value)
  {
    SetTransparancy(openXmlElement, value?.Transparancy);
    SetScaling(openXmlElement, value?.Scaling);
  }
}
