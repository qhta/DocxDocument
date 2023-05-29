namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the SharpenSoften Class.
/// </summary>
public static class SharpenSoftenConverter
{
  /// <summary>
  /// amount, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetAmount(DXO2010Draw.SharpenSoften openXmlElement)
  {
    return openXmlElement?.Amount?.Value;
  }
  
  private static bool CmpAmount(DXO2010Draw.SharpenSoften openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Amount?.Value == value) return true;
    diffs?.Add(objName, "Amount", openXmlElement?.Amount?.Value, value);
    return false;
  }
  
  private static void SetAmount(DXO2010Draw.SharpenSoften openXmlElement, Int32? value)
  {
    openXmlElement.Amount = value;
  }
  
  public static DocumentModel.Drawings.SharpenSoften? CreateModelElement(DXO2010Draw.SharpenSoften? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.SharpenSoften();
      value.Amount = GetAmount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.SharpenSoften? openXmlElement, DMDraws.SharpenSoften? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAmount(openXmlElement, value.Amount, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.SharpenSoften value)
    where OpenXmlElementType: DXO2010Draw.SharpenSoften, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010Draw.SharpenSoften openXmlElement, DMDraws.SharpenSoften value)
  {
    SetAmount(openXmlElement, value?.Amount);
  }
}
