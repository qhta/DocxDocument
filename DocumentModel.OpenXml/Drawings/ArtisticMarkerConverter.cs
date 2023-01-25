namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticMarker Class.
/// </summary>
public static class ArtisticMarkerConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticMarker openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO2010Draw.ArtisticMarker openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticMarker openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// size, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetSize(DXO2010Draw.ArtisticMarker openXmlElement)
  {
    return openXmlElement?.Size?.Value;
  }
  
  private static bool CmpSize(DXO2010Draw.ArtisticMarker openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Size?.Value == value) return true;
    diffs?.Add(objName, "Size", openXmlElement?.Size?.Value, value);
    return false;
  }
  
  private static void SetSize(DXO2010Draw.ArtisticMarker openXmlElement, Int32? value)
  {
    openXmlElement.Size = value;
  }
  
  public static DMDraws.ArtisticMarker? CreateModelElement(DXO2010Draw.ArtisticMarker? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ArtisticMarker();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Size = GetSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.ArtisticMarker? openXmlElement, DMDraws.ArtisticMarker? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTransparancy(openXmlElement, value.Transparancy, diffs, objName))
        ok = false;
      if (!CmpSize(openXmlElement, value.Size, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticMarker? value)
    where OpenXmlElementType: DXO2010Draw.ArtisticMarker, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetSize(openXmlElement, value?.Size);
      return openXmlElement;
    }
    return default;
  }
}
