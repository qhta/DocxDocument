namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticCrisscrossEtching Class.
/// </summary>
public static class ArtisticCrisscrossEtchingConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticCrisscrossEtching openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO2010Draw.ArtisticCrisscrossEtching openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticCrisscrossEtching openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// pressure, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetPressure(DXO2010Draw.ArtisticCrisscrossEtching openXmlElement)
  {
    return openXmlElement?.Pressure?.Value;
  }
  
  private static bool CmpPressure(DXO2010Draw.ArtisticCrisscrossEtching openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Pressure?.Value == value) return true;
    diffs?.Add(objName, "Pressure", openXmlElement?.Pressure?.Value, value);
    return false;
  }
  
  private static void SetPressure(DXO2010Draw.ArtisticCrisscrossEtching openXmlElement, Int32? value)
  {
    openXmlElement.Pressure = value;
  }
  
  public static DocumentModel.Drawings.ArtisticCrisscrossEtching? CreateModelElement(DXO2010Draw.ArtisticCrisscrossEtching? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticCrisscrossEtching();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.Pressure = GetPressure(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.ArtisticCrisscrossEtching? openXmlElement, DMDraws.ArtisticCrisscrossEtching? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTransparancy(openXmlElement, value.Transparancy, diffs, objName))
        ok = false;
      if (!CmpPressure(openXmlElement, value.Pressure, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticCrisscrossEtching value)
    where OpenXmlElementType: DXO2010Draw.ArtisticCrisscrossEtching, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010Draw.ArtisticCrisscrossEtching openXmlElement, DMDraws.ArtisticCrisscrossEtching value)
  {
    SetTransparancy(openXmlElement, value?.Transparancy);
    SetPressure(openXmlElement, value?.Pressure);
  }
}
