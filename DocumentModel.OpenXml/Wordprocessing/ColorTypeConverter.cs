namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ColorType Class.
/// </summary>
public static class ColorTypeConverter
{
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  private static DMW.RgbColorModelHex? GetRgbColorModelHex(DXO2010W.ColorType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.RgbColorModelHex>();
    if (element != null)
      return DMXW.RgbColorModelHexConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRgbColorModelHex(DXO2010W.ColorType openXmlElement, DMW.RgbColorModelHex? value, DiffList? diffs, string? objName)
  {
    return DMXW.RgbColorModelHexConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.RgbColorModelHex>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRgbColorModelHex(DXO2010W.ColorType openXmlElement, DMW.RgbColorModelHex? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.RgbColorModelHex>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RgbColorModelHexConverter.CreateOpenXmlElement<DXO2010W.RgbColorModelHex>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  private static DMW.SchemeColor? GetSchemeColor(DXO2010W.ColorType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.SchemeColor>();
    if (element != null)
      return DMXW.SchemeColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSchemeColor(DXO2010W.ColorType openXmlElement, DMW.SchemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXW.SchemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.SchemeColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSchemeColor(DXO2010W.ColorType openXmlElement, DMW.SchemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.SchemeColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SchemeColorConverter.CreateOpenXmlElement<DXO2010W.SchemeColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.ColorType? CreateModelElement(DXO2010W.ColorType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ColorType();
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010W.ColorType? openXmlElement, DMW.ColorType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRgbColorModelHex(openXmlElement, value.RgbColorModelHex, diffs, objName))
        ok = false;
      if (!CmpSchemeColor(openXmlElement, value.SchemeColor, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ColorType value)
    where OpenXmlElementType: DXO2010W.ColorType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010W.ColorType openXmlElement, DMW.ColorType value)
  {
    SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
    SetSchemeColor(openXmlElement, value?.SchemeColor);
  }
}
