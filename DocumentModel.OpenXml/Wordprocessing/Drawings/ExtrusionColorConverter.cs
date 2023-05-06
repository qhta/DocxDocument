namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ExtrusionColor Class.
/// </summary>
public static class ExtrusionColorConverter
{
  private static DMW.RgbColorModelHex? GetRgbColorModelHex(DXO10W.ExtrusionColor openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.RgbColorModelHex>();
    if (element != null)
      return DMXW.RgbColorModelHexConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRgbColorModelHex(DXO10W.ExtrusionColor openXmlElement, DMW.RgbColorModelHex? value, DiffList? diffs, string? objName)
  {
    return DMXW.RgbColorModelHexConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.RgbColorModelHex>(), value, diffs, objName);
  }
  
  private static void SetRgbColorModelHex(DXO10W.ExtrusionColor openXmlElement, DMW.RgbColorModelHex? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.RgbColorModelHex>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RgbColorModelHexConverter.CreateOpenXmlElement<DXO10W.RgbColorModelHex>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMW.SchemeColor? GetSchemeColor(DXO10W.ExtrusionColor openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.SchemeColor>();
    if (element != null)
      return DMXW.SchemeColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSchemeColor(DXO10W.ExtrusionColor openXmlElement, DMW.SchemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXW.SchemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.SchemeColor>(), value, diffs, objName);
  }
  
  private static void SetSchemeColor(DXO10W.ExtrusionColor openXmlElement, DMW.SchemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.SchemeColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SchemeColorConverter.CreateOpenXmlElement<DXO10W.SchemeColor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMW.ExtrusionColor? CreateModelElement(DXO10W.ExtrusionColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ExtrusionColor();
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10W.ExtrusionColor? openXmlElement, DMW.ExtrusionColor? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ExtrusionColor value)
    where OpenXmlElementType: DXO10W.ExtrusionColor, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10W.ExtrusionColor openXmlElement, DMW.ExtrusionColor value)
  {
    SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
    SetSchemeColor(openXmlElement, value?.SchemeColor);
  }
}
