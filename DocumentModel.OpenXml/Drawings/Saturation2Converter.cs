namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Saturation Class.
/// </summary>
public static class Saturation2Converter
{
  /// <summary>
  /// sat, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetSaturationAmount(DXO2010Draw.Saturation openXmlElement)
  {
    return openXmlElement?.SaturationAmount?.Value;
  }
  
  private static bool CmpSaturationAmount(DXO2010Draw.Saturation openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SaturationAmount?.Value == value) return true;
    diffs?.Add(objName, "SaturationAmount", openXmlElement?.SaturationAmount?.Value, value);
    return false;
  }
  
  private static void SetSaturationAmount(DXO2010Draw.Saturation openXmlElement, Int32? value)
  {
    openXmlElement.SaturationAmount = value;
  }
  
  public static DocumentModel.Drawings.Saturation2? CreateModelElement(DXO2010Draw.Saturation? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Saturation2();
      value.SaturationAmount = GetSaturationAmount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.Saturation? openXmlElement, DMDraws.Saturation2? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSaturationAmount(openXmlElement, value.SaturationAmount, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Saturation2 value)
    where OpenXmlElementType: DXO2010Draw.Saturation, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010Draw.Saturation openXmlElement, DMDraws.Saturation2 value)
  {
    SetSaturationAmount(openXmlElement, value?.SaturationAmount);
    }
  }
