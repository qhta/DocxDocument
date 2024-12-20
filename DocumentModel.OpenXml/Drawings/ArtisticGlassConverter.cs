namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticGlass Class.
/// </summary>
public static class ArtisticGlassConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO10D.ArtisticGlass openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO10D.ArtisticGlass openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO10D.ArtisticGlass openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// scaling, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetScaling(DXO10D.ArtisticGlass openXmlElement)
  {
    return openXmlElement?.Scaling?.Value;
  }
  
  private static bool CmpScaling(DXO10D.ArtisticGlass openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Scaling?.Value == value) return true;
    diffs?.Add(objName, "Scaling", openXmlElement?.Scaling?.Value, value);
    return false;
  }
  
  private static void SetScaling(DXO10D.ArtisticGlass openXmlElement, Int32? value)
  {
    openXmlElement.Scaling = value;
  }
  
  public static DMD.ArtisticGlass? CreateModelElement(DXO10D.ArtisticGlass? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ArtisticGlass();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Scaling = GetScaling(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10D.ArtisticGlass? openXmlElement, DMD.ArtisticGlass? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTransparancy(openXmlElement, value.Transparancy, diffs, objName, propName))
        ok = false;
      if (!CmpScaling(openXmlElement, value.Scaling, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ArtisticGlass value)
    where OpenXmlElementType: DXO10D.ArtisticGlass, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.ArtisticGlass openXmlElement, DMD.ArtisticGlass value)
  {
    SetTransparancy(openXmlElement, value?.Transparancy);
    SetScaling(openXmlElement, value?.Scaling);
  }
}
