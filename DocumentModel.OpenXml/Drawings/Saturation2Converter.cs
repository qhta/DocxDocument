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
    return openXmlElement.SaturationAmount?.Value;
  }
  
  private static bool CmpSaturationAmount(DXO2010Draw.Saturation openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.SaturationAmount?.Value == value;
  }
  
  private static void SetSaturationAmount(DXO2010Draw.Saturation openXmlElement, Int32? value)
  {
    openXmlElement.SaturationAmount = value;
  }
  
  public static DMDraws.Saturation2? CreateModelElement(DXO2010Draw.Saturation? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Saturation2();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Saturation2? value)
    where OpenXmlElementType: DXO2010Draw.Saturation, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSaturationAmount(openXmlElement, value?.SaturationAmount);
      return openXmlElement;
    }
    return default;
  }
}
