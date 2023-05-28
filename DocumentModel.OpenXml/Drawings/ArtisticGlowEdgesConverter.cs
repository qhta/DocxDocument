namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticGlowEdges Class.
/// </summary>
public static class ArtisticGlowEdgesConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO10D.ArtisticGlowEdges openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO10D.ArtisticGlowEdges openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO10D.ArtisticGlowEdges openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// smoothness, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetSmoothness(DXO10D.ArtisticGlowEdges openXmlElement)
  {
    return openXmlElement?.Smoothness?.Value;
  }
  
  private static bool CmpSmoothness(DXO10D.ArtisticGlowEdges openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Smoothness?.Value == value) return true;
    diffs?.Add(objName, "Smoothness", openXmlElement?.Smoothness?.Value, value);
    return false;
  }
  
  private static void SetSmoothness(DXO10D.ArtisticGlowEdges openXmlElement, Int32? value)
  {
    openXmlElement.Smoothness = value;
  }
  
  public static DMD.ArtisticGlowEdges? CreateModelElement(DXO10D.ArtisticGlowEdges? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ArtisticGlowEdges();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Smoothness = GetSmoothness(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10D.ArtisticGlowEdges? openXmlElement, DMD.ArtisticGlowEdges? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTransparancy(openXmlElement, value.Transparancy, diffs, objName, propName))
        ok = false;
      if (!CmpSmoothness(openXmlElement, value.Smoothness, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ArtisticGlowEdges value)
    where OpenXmlElementType: DXO10D.ArtisticGlowEdges, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.ArtisticGlowEdges openXmlElement, DMD.ArtisticGlowEdges value)
  {
    SetTransparancy(openXmlElement, value?.Transparancy);
    SetSmoothness(openXmlElement, value?.Smoothness);
  }
}
