namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Tight Wrapping.
/// </summary>
public static class WrapTightConverter
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  private static DMDW.WrapTextKind? GetWrapText(DXDW.WrapTight openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues, DMDW.WrapTextKind>(openXmlElement?.WrapText?.Value);
  }
  
  private static bool CmpWrapText(DXDW.WrapTight openXmlElement, DMDW.WrapTextKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues, DMDW.WrapTextKind>(openXmlElement?.WrapText?.Value, value, diffs, objName, propName);
  }
  
  private static void SetWrapText(DXDW.WrapTight openXmlElement, DMDW.WrapTextKind? value)
  {
    openXmlElement.WrapText = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues, DMDW.WrapTextKind>(value);
  }
  
  /// <summary>
  /// Distance From Test on Left Edge
  /// </summary>
  private static UInt32? GetDistanceFromLeft(DXDW.WrapTight openXmlElement)
  {
    return openXmlElement?.DistanceFromLeft?.Value;
  }
  
  private static bool CmpDistanceFromLeft(DXDW.WrapTight openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DistanceFromLeft?.Value == value) return true;
    diffs?.Add(objName, "DistanceFromLeft", openXmlElement?.DistanceFromLeft?.Value, value);
    return false;
  }
  
  private static void SetDistanceFromLeft(DXDW.WrapTight openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromLeft = value;
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  private static UInt32? GetDistanceFromRight(DXDW.WrapTight openXmlElement)
  {
    return openXmlElement?.DistanceFromRight?.Value;
  }
  
  private static bool CmpDistanceFromRight(DXDW.WrapTight openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DistanceFromRight?.Value == value) return true;
    diffs?.Add(objName, "DistanceFromRight", openXmlElement?.DistanceFromRight?.Value, value);
    return false;
  }
  
  private static void SetDistanceFromRight(DXDW.WrapTight openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromRight = value;
  }
  
  /// <summary>
  /// Tight Wrapping Extents Polygon.
  /// </summary>
  private static DMDW.WrapPolygon? GetWrapPolygon(DXDW.WrapTight openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.WrapPolygon>();
    if (element != null)
      return DMXDW.WrapPolygonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWrapPolygon(DXDW.WrapTight openXmlElement, DMDW.WrapPolygon? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDW.WrapPolygonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.WrapPolygon>(), value, diffs, objName, propName);
  }
  
  private static void SetWrapPolygon(DXDW.WrapTight openXmlElement, DMDW.WrapPolygon? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.WrapPolygon>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.WrapPolygonConverter.CreateOpenXmlElement<DXDW.WrapPolygon>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Wordprocessing.WrapTight? CreateModelElement(DXDW.WrapTight? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Wordprocessing.WrapTight();
      value.WrapText = GetWrapText(openXmlElement);
      value.DistanceFromLeft = GetDistanceFromLeft(openXmlElement);
      value.DistanceFromRight = GetDistanceFromRight(openXmlElement);
      value.WrapPolygon = GetWrapPolygon(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDW.WrapTight? openXmlElement, DMDW.WrapTight? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWrapText(openXmlElement, value.WrapText, diffs, objName, propName))
        ok = false;
      if (!CmpDistanceFromLeft(openXmlElement, value.DistanceFromLeft, diffs, objName, propName))
        ok = false;
      if (!CmpDistanceFromRight(openXmlElement, value.DistanceFromRight, diffs, objName, propName))
        ok = false;
      if (!CmpWrapPolygon(openXmlElement, value.WrapPolygon, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDW.WrapTight value)
    where OpenXmlElementType: DXDW.WrapTight, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDW.WrapTight openXmlElement, DMDW.WrapTight value)
  {
    SetWrapText(openXmlElement, value?.WrapText);
    SetDistanceFromLeft(openXmlElement, value?.DistanceFromLeft);
    SetDistanceFromRight(openXmlElement, value?.DistanceFromRight);
    SetWrapPolygon(openXmlElement, value?.WrapPolygon);
  }
}
