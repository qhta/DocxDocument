namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticGlowEdges Class.
/// </summary>
public static class ArtisticGlowEdgesConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticGlowEdges openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO2010Draw.ArtisticGlowEdges openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticGlowEdges openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// smoothness, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetSmoothness(DXO2010Draw.ArtisticGlowEdges openXmlElement)
  {
    return openXmlElement?.Smoothness?.Value;
  }
  
  private static bool CmpSmoothness(DXO2010Draw.ArtisticGlowEdges openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Smoothness?.Value == value) return true;
    diffs?.Add(objName, "Smoothness", openXmlElement?.Smoothness?.Value, value);
    return false;
  }
  
  private static void SetSmoothness(DXO2010Draw.ArtisticGlowEdges openXmlElement, Int32? value)
  {
    openXmlElement.Smoothness = value;
  }
  
  public static DocumentModel.Drawings.ArtisticGlowEdges? CreateModelElement(DXO2010Draw.ArtisticGlowEdges? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticGlowEdges();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Smoothness = GetSmoothness(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.ArtisticGlowEdges? openXmlElement, DMDraws.ArtisticGlowEdges? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTransparancy(openXmlElement, value.Transparancy, diffs, objName))
        ok = false;
      if (!CmpSmoothness(openXmlElement, value.Smoothness, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticGlowEdges value)
    where OpenXmlElementType: DXO2010Draw.ArtisticGlowEdges, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010Draw.ArtisticGlowEdges openXmlElement, DMDraws.ArtisticGlowEdges value)
  {
    SetTransparancy(openXmlElement, value?.Transparancy);
    SetSmoothness(openXmlElement, value?.Smoothness);
    }
  }
