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
    return openXmlElement.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO2010Draw.ArtisticPhotocopy openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Transparancy?.Value == value;
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
    return openXmlElement.Detail?.Value;
  }
  
  private static bool CmpDetail(DXO2010Draw.ArtisticPhotocopy openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Detail?.Value == value;
  }
  
  private static void SetDetail(DXO2010Draw.ArtisticPhotocopy openXmlElement, Int32? value)
  {
    openXmlElement.Detail = value;
  }
  
  public static DMDraws.ArtisticPhotocopy? CreateModelElement(DXO2010Draw.ArtisticPhotocopy? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ArtisticPhotocopy();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticPhotocopy? value)
    where OpenXmlElementType: DXO2010Draw.ArtisticPhotocopy, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTransparancy(openXmlElement, value?.Transparancy);
      SetDetail(openXmlElement, value?.Detail);
      return openXmlElement;
    }
    return default;
  }
}
