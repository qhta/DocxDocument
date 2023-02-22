namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticTexturizer Class.
/// </summary>
public static class ArtisticTexturizerConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticTexturizer openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO2010Draw.ArtisticTexturizer openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticTexturizer openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// scaling, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetScaling(DXO2010Draw.ArtisticTexturizer openXmlElement)
  {
    return openXmlElement?.Scaling?.Value;
  }
  
  private static bool CmpScaling(DXO2010Draw.ArtisticTexturizer openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Scaling?.Value == value) return true;
    diffs?.Add(objName, "Scaling", openXmlElement?.Scaling?.Value, value);
    return false;
  }
  
  private static void SetScaling(DXO2010Draw.ArtisticTexturizer openXmlElement, Int32? value)
  {
    openXmlElement.Scaling = value;
  }
  
  public static DocumentModel.Drawings.ArtisticTexturizer? CreateModelElement(DXO2010Draw.ArtisticTexturizer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticTexturizer();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Scaling = GetScaling(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.ArtisticTexturizer? openXmlElement, DMDraws.ArtisticTexturizer? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTransparancy(openXmlElement, value.Transparancy, diffs, objName))
        ok = false;
      if (!CmpScaling(openXmlElement, value.Scaling, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticTexturizer value)
    where OpenXmlElementType: DXO2010Draw.ArtisticTexturizer, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010Draw.ArtisticTexturizer openXmlElement, DMDraws.ArtisticTexturizer value)
  {
    SetTransparancy(openXmlElement, value?.Transparancy);
    SetScaling(openXmlElement, value?.Scaling);
    }
  }
