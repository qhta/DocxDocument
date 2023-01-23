namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticLightScreen Class.
/// </summary>
public static class ArtisticLightScreenConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticLightScreen openXmlElement)
  {
    return openXmlElement.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO2010Draw.ArtisticLightScreen openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Transparancy?.Value == value;
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
    return openXmlElement.GridSize?.Value;
  }
  
  private static bool CmpGridSize(DXO2010Draw.ArtisticLightScreen openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GridSize?.Value == value;
  }
  
  private static void SetGridSize(DXO2010Draw.ArtisticLightScreen openXmlElement, Int32? value)
  {
    openXmlElement.GridSize = value;
  }
  
  public static DMDraws.ArtisticLightScreen? CreateModelElement(DXO2010Draw.ArtisticLightScreen? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ArtisticLightScreen();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticLightScreen? value)
    where OpenXmlElementType: DXO2010Draw.ArtisticLightScreen, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetGridSize(openXmlElement, value?.GridSize);
      return openXmlElement;
    }
    return default;
  }
}
