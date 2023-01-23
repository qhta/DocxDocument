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
    return openXmlElement.Radius?.Value;
  }
  
  private static bool CmpRadius(DXO2010Draw.ArtisticBlur openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Radius?.Value == value;
  }
  
  private static void SetRadius(DXO2010Draw.ArtisticBlur openXmlElement, Int32? value)
  {
    openXmlElement.Radius = value;
  }
  
  public static DMDraws.ArtisticBlur? CreateModelElement(DXO2010Draw.ArtisticBlur? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ArtisticBlur();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticBlur? value)
    where OpenXmlElementType: DXO2010Draw.ArtisticBlur, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRadius(openXmlElement, value?.Radius);
      return openXmlElement;
    }
    return default;
  }
}
