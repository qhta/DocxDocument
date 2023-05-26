namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Glow Class.
/// </summary>
public static class GlowConverter
{
  /// <summary>
  /// rad, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetGlowRadius(DXO10W.Glow openXmlElement)
  {
    return openXmlElement?.GlowRadius?.Value;
  }
  
  private static bool CmpGlowRadius(DXO10W.Glow openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.GlowRadius?.Value == value) return true;
    diffs?.Add(objName, "GlowRadius", openXmlElement?.GlowRadius?.Value, value);
    return false;
  }
  
  private static void SetGlowRadius(DXO10W.Glow openXmlElement, Int64? value)
  {
    openXmlElement.GlowRadius = value;
  }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  private static DMW.RgbColorModelHex? GetRgbColorModelHex(DXO10W.Glow openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.RgbColorModelHex>();
    if (element != null)
      return DMXW.RgbColorModelHexConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRgbColorModelHex(DXO10W.Glow openXmlElement, DMW.RgbColorModelHex? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.RgbColorModelHexConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.RgbColorModelHex>(), value, diffs, objName, propName);
  }
  
  private static void SetRgbColorModelHex(DXO10W.Glow openXmlElement, DMW.RgbColorModelHex? value)
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
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  private static DMW.SchemeColor? GetSchemeColor(DXO10W.Glow openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.SchemeColor>();
    if (element != null)
      return DMXW.SchemeColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSchemeColor(DXO10W.Glow openXmlElement, DMW.SchemeColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.SchemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.SchemeColor>(), value, diffs, objName, propName);
  }
  
  private static void SetSchemeColor(DXO10W.Glow openXmlElement, DMW.SchemeColor? value)
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
  
  public static DMW.Glow? CreateModelElement(DXO10W.Glow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Glow();
      value.GlowRadius = GetGlowRadius(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10W.Glow? openXmlElement, DMW.Glow? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGlowRadius(openXmlElement, value.GlowRadius, diffs, objName, propName))
        ok = false;
      if (!CmpRgbColorModelHex(openXmlElement, value.RgbColorModelHex, diffs, objName, propName))
        ok = false;
      if (!CmpSchemeColor(openXmlElement, value.SchemeColor, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXO10W.Glow CreateOpenXmlElement(DMW.Glow value)
  {
    var openXmlElement = new DXO10W.Glow();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXO10W.Glow openXmlElement, DMW.Glow value)
  {
    SetGlowRadius(openXmlElement, value?.GlowRadius);
    SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
    SetSchemeColor(openXmlElement, value?.SchemeColor);
    return true;
  }
}
