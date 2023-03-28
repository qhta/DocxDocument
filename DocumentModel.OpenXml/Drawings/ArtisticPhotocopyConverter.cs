namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticPhotocopy Class.
/// </summary>
public static class ArtisticPhotocopyConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticPhotocopy openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO2010Draw.ArtisticPhotocopy openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticPhotocopy openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// detail, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetDetail(DXO2010Draw.ArtisticPhotocopy openXmlElement)
  {
    return openXmlElement?.Detail?.Value;
  }
  
  private static bool CmpDetail(DXO2010Draw.ArtisticPhotocopy openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Detail?.Value == value) return true;
    diffs?.Add(objName, "Detail", openXmlElement?.Detail?.Value, value);
    return false;
  }
  
  private static void SetDetail(DXO2010Draw.ArtisticPhotocopy openXmlElement, Int32? value)
  {
    openXmlElement.Detail = value;
  }
  
  public static DocumentModel.Drawings.ArtisticPhotocopy? CreateModelElement(DXO2010Draw.ArtisticPhotocopy? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticPhotocopy();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Detail = GetDetail(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.ArtisticPhotocopy? openXmlElement, DMDraws.ArtisticPhotocopy? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTransparancy(openXmlElement, value.Transparancy, diffs, objName))
        ok = false;
      if (!CmpDetail(openXmlElement, value.Detail, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticPhotocopy value)
    where OpenXmlElementType: DXO2010Draw.ArtisticPhotocopy, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010Draw.ArtisticPhotocopy openXmlElement, DMDraws.ArtisticPhotocopy value)
  {
    SetTransparancy(openXmlElement, value?.Transparancy);
    SetDetail(openXmlElement, value?.Detail);
  }
}
