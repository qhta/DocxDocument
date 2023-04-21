namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticCement Class.
/// </summary>
public static class ArtisticCementConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO10D.ArtisticCement openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO10D.ArtisticCement openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO10D.ArtisticCement openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// crackSpacing, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetCrackSpacing(DXO10D.ArtisticCement openXmlElement)
  {
    return openXmlElement?.CrackSpacing?.Value;
  }
  
  private static bool CmpCrackSpacing(DXO10D.ArtisticCement openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.CrackSpacing?.Value == value) return true;
    diffs?.Add(objName, "CrackSpacing", openXmlElement?.CrackSpacing?.Value, value);
    return false;
  }
  
  private static void SetCrackSpacing(DXO10D.ArtisticCement openXmlElement, Int32? value)
  {
    openXmlElement.CrackSpacing = value;
  }
  
  public static DocumentModel.Drawings.ArtisticCement? CreateModelElement(DXO10D.ArtisticCement? openXmlElement)
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
  
  public static bool CompareModelElement(DXO10D.ArtisticCement? openXmlElement, DMD.ArtisticCement? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ArtisticCement value)
    where OpenXmlElementType: DXO10D.ArtisticCement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.ArtisticCement openXmlElement, DMD.ArtisticCement value)
  {
    SetTransparancy(openXmlElement, value?.Transparancy);
    SetCrackSpacing(openXmlElement, value?.CrackSpacing);
  }
}
