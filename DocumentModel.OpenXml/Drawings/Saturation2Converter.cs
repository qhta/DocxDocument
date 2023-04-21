namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Saturation Class.
/// </summary>
public static class Saturation2Converter
{
  /// <summary>
  /// sat, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetSaturationAmount(DXO10D.Saturation openXmlElement)
  {
    return openXmlElement?.SaturationAmount?.Value;
  }
  
  private static bool CmpSaturationAmount(DXO10D.Saturation openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SaturationAmount?.Value == value) return true;
    diffs?.Add(objName, "SaturationAmount", openXmlElement?.SaturationAmount?.Value, value);
    return false;
  }
  
  private static void SetSaturationAmount(DXO10D.Saturation openXmlElement, Int32? value)
  {
    openXmlElement.SaturationAmount = value;
  }
  
  public static DocumentModel.Drawings.Saturation2? CreateModelElement(DXO10D.Saturation? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Saturation2();
      value.SaturationAmount = GetSaturationAmount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10D.Saturation? openXmlElement, DMD.Saturation2? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Saturation2 value)
    where OpenXmlElementType: DXO10D.Saturation, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.Saturation openXmlElement, DMD.Saturation2 value)
  {
    SetSaturationAmount(openXmlElement, value?.SaturationAmount);
  }
}
