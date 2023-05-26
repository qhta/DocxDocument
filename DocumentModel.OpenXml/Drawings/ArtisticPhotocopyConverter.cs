namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticPhotocopy Class.
/// </summary>
public static class ArtisticPhotocopyConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO10D.ArtisticPhotocopy openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO10D.ArtisticPhotocopy openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO10D.ArtisticPhotocopy openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// detail, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetDetail(DXO10D.ArtisticPhotocopy openXmlElement)
  {
    return openXmlElement?.Detail?.Value;
  }
  
  private static bool CmpDetail(DXO10D.ArtisticPhotocopy openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Detail?.Value == value) return true;
    diffs?.Add(objName, "Detail", openXmlElement?.Detail?.Value, value);
    return false;
  }
  
  private static void SetDetail(DXO10D.ArtisticPhotocopy openXmlElement, Int32? value)
  {
    openXmlElement.Detail = value;
  }
  
  public static DocumentModel.Drawings.ArtisticPhotocopy? CreateModelElement(DXO10D.ArtisticPhotocopy? openXmlElement)
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
  
  public static bool CompareModelElement(DXO10D.ArtisticPhotocopy? openXmlElement, DMD.ArtisticPhotocopy? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTransparancy(openXmlElement, value.Transparancy, diffs, objName, propName))
        ok = false;
      if (!CmpDetail(openXmlElement, value.Detail, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ArtisticPhotocopy value)
    where OpenXmlElementType: DXO10D.ArtisticPhotocopy, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.ArtisticPhotocopy openXmlElement, DMD.ArtisticPhotocopy value)
  {
    SetTransparancy(openXmlElement, value?.Transparancy);
    SetDetail(openXmlElement, value?.Detail);
  }
}
