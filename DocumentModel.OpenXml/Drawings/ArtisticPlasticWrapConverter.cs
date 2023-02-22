namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticPlasticWrap Class.
/// </summary>
public static class ArtisticPlasticWrapConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticPlasticWrap openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO2010Draw.ArtisticPlasticWrap openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticPlasticWrap openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// smoothness, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetSmoothness(DXO2010Draw.ArtisticPlasticWrap openXmlElement)
  {
    return openXmlElement?.Smoothness?.Value;
  }
  
  private static bool CmpSmoothness(DXO2010Draw.ArtisticPlasticWrap openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Smoothness?.Value == value) return true;
    diffs?.Add(objName, "Smoothness", openXmlElement?.Smoothness?.Value, value);
    return false;
  }
  
  private static void SetSmoothness(DXO2010Draw.ArtisticPlasticWrap openXmlElement, Int32? value)
  {
    openXmlElement.Smoothness = value;
  }
  
  public static DocumentModel.Drawings.ArtisticPlasticWrap? CreateModelElement(DXO2010Draw.ArtisticPlasticWrap? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticPlasticWrap();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Smoothness = GetSmoothness(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.ArtisticPlasticWrap? openXmlElement, DMDraws.ArtisticPlasticWrap? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticPlasticWrap value)
    where OpenXmlElementType: DXO2010Draw.ArtisticPlasticWrap, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010Draw.ArtisticPlasticWrap openXmlElement, DMDraws.ArtisticPlasticWrap value)
  {
    SetTransparancy(openXmlElement, value?.Transparancy);
    SetSmoothness(openXmlElement, value?.Smoothness);
    }
  }
