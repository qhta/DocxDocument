namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticCutout Class.
/// </summary>
public static class ArtisticCutoutConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO10D.ArtisticCutout openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO10D.ArtisticCutout openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO10D.ArtisticCutout openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// numberOfShades, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetNumberOfShades(DXO10D.ArtisticCutout openXmlElement)
  {
    return openXmlElement?.NumberOfShades?.Value;
  }
  
  private static bool CmpNumberOfShades(DXO10D.ArtisticCutout openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NumberOfShades?.Value == value) return true;
    diffs?.Add(objName, "NumberOfShades", openXmlElement?.NumberOfShades?.Value, value);
    return false;
  }
  
  private static void SetNumberOfShades(DXO10D.ArtisticCutout openXmlElement, Int32? value)
  {
    openXmlElement.NumberOfShades = value;
  }
  
  public static DocumentModel.Drawings.ArtisticCutout? CreateModelElement(DXO10D.ArtisticCutout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticCutout();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.NumberOfShades = GetNumberOfShades(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10D.ArtisticCutout? openXmlElement, DMD.ArtisticCutout? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTransparancy(openXmlElement, value.Transparancy, diffs, objName))
        ok = false;
      if (!CmpNumberOfShades(openXmlElement, value.NumberOfShades, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ArtisticCutout value)
    where OpenXmlElementType: DXO10D.ArtisticCutout, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.ArtisticCutout openXmlElement, DMD.ArtisticCutout value)
  {
    SetTransparancy(openXmlElement, value?.Transparancy);
    SetNumberOfShades(openXmlElement, value?.NumberOfShades);
  }
}
