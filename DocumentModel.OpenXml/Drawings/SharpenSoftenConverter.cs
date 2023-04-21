namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the SharpenSoften Class.
/// </summary>
public static class SharpenSoftenConverter
{
  /// <summary>
  /// amount, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetAmount(DXO10D.SharpenSoften openXmlElement)
  {
    return openXmlElement?.Amount?.Value;
  }
  
  private static bool CmpAmount(DXO10D.SharpenSoften openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Amount?.Value == value) return true;
    diffs?.Add(objName, "Amount", openXmlElement?.Amount?.Value, value);
    return false;
  }
  
  private static void SetAmount(DXO10D.SharpenSoften openXmlElement, Int32? value)
  {
    openXmlElement.Amount = value;
  }
  
  public static DocumentModel.Drawings.SharpenSoften? CreateModelElement(DXO10D.SharpenSoften? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.SharpenSoften();
      value.Amount = GetAmount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10D.SharpenSoften? openXmlElement, DMD.SharpenSoften? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.SharpenSoften value)
    where OpenXmlElementType: DXO10D.SharpenSoften, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.SharpenSoften openXmlElement, DMD.SharpenSoften value)
  {
    SetAmount(openXmlElement, value?.Amount);
  }
}
