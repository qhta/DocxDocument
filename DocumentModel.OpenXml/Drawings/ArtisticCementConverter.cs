namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticCement Class.
/// </summary>
public static class ArtisticCementConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticCement openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO2010Draw.ArtisticCement openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticCement openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// crackSpacing, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetCrackSpacing(DXO2010Draw.ArtisticCement openXmlElement)
  {
    return openXmlElement?.CrackSpacing?.Value;
  }
  
  private static bool CmpCrackSpacing(DXO2010Draw.ArtisticCement openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.CrackSpacing?.Value == value) return true;
    diffs?.Add(objName, "CrackSpacing", openXmlElement?.CrackSpacing?.Value, value);
    return false;
  }
  
  private static void SetCrackSpacing(DXO2010Draw.ArtisticCement openXmlElement, Int32? value)
  {
    openXmlElement.CrackSpacing = value;
  }
  
  public static DocumentModel.Drawings.ArtisticCement? CreateModelElement(DXO2010Draw.ArtisticCement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticCement();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.CrackSpacing = GetCrackSpacing(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.ArtisticCement? openXmlElement, DMDraws.ArtisticCement? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTransparancy(openXmlElement, value.Transparancy, diffs, objName))
        ok = false;
      if (!CmpCrackSpacing(openXmlElement, value.CrackSpacing, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticCement? value)
    where OpenXmlElementType: DXO2010Draw.ArtisticCement, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetCrackSpacing(openXmlElement, value?.CrackSpacing);
      return openXmlElement;
    }
    return default;
  }
}
