namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticBlur Class.
/// </summary>
public static class ArtisticBlurConverter
{
  /// <summary>
  /// radius, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetRadius(DXO2010Draw.ArtisticBlur openXmlElement)
  {
    return openXmlElement?.Radius?.Value;
  }
  
  private static bool CmpRadius(DXO2010Draw.ArtisticBlur openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Radius?.Value == value) return true;
    diffs?.Add(objName, "Radius", openXmlElement?.Radius?.Value, value);
    return false;
  }
  
  private static void SetRadius(DXO2010Draw.ArtisticBlur openXmlElement, Int32? value)
  {
    openXmlElement.Radius = value;
  }
  
  public static DocumentModel.Drawings.ArtisticBlur? CreateModelElement(DXO2010Draw.ArtisticBlur? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticBlur();
      value.Radius = GetRadius(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.ArtisticBlur? openXmlElement, DMDraws.ArtisticBlur? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRadius(openXmlElement, value.Radius, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticBlur value)
    where OpenXmlElementType: DXO2010Draw.ArtisticBlur, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010Draw.ArtisticBlur openXmlElement, DMDraws.ArtisticBlur value)
  {
    SetRadius(openXmlElement, value?.Radius);
  }
}
