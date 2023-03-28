namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticLightScreen Class converter from/to OpenXml.
///</summary>
public static class ArtisticLightScreenConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticLightScreen openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO2010Draw.ArtisticLightScreen openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticLightScreen openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// gridSize, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetGridSize(DXO2010Draw.ArtisticLightScreen openXmlElement)
  {
    return openXmlElement?.GridSize?.Value;
  }
  
  private static bool CmpGridSize(DXO2010Draw.ArtisticLightScreen openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GridSize?.Value == value) return true;
    diffs?.Add(objName, "GridSize", openXmlElement?.GridSize?.Value, value);
    return false;
  }
  
  private static void SetGridSize(DXO2010Draw.ArtisticLightScreen openXmlElement, Int32? value)
  {
    openXmlElement.GridSize = value;
  }
  
  public static DocumentModel.Drawings.ArtisticLightScreen? CreateModelElement(DXO2010Draw.ArtisticLightScreen? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticLightScreen();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.GridSize = GetGridSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.ArtisticLightScreen? openXmlElement, DMDraws.ArtisticLightScreen? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTransparancy(openXmlElement, value.Transparancy, diffs, objName))
        ok = false;
      if (!CmpGridSize(openXmlElement, value.GridSize, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticLightScreen value)
    where OpenXmlElementType: DXO2010Draw.ArtisticLightScreen, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010Draw.ArtisticLightScreen openXmlElement, DMDraws.ArtisticLightScreen value)
  {
    SetTransparancy(openXmlElement, value?.Transparancy);
    SetGridSize(openXmlElement, value?.GridSize);
  }
}
