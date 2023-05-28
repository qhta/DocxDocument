namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Through Wrapping.
/// </summary>
public static class WrapThroughConverter
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  private static DMDW.WrapTextKind? GetWrapText(DXDW.WrapThrough openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues, DMDW.WrapTextKind>(openXmlElement?.WrapText?.Value);
  }
  
  private static bool CmpWrapText(DXDW.WrapThrough openXmlElement, DMDW.WrapTextKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues, DMDW.WrapTextKind>(openXmlElement?.WrapText?.Value, value, diffs, objName, propName);
  }
  
  private static void SetWrapText(DXDW.WrapThrough openXmlElement, DMDW.WrapTextKind? value)
  {
    openXmlElement.WrapText = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues, DMDW.WrapTextKind>(value);
  }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  private static UInt32? GetDistanceFromLeft(DXDW.WrapThrough openXmlElement)
  {
    return openXmlElement?.DistanceFromLeft?.Value;
  }
  
  private static bool CmpDistanceFromLeft(DXDW.WrapThrough openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DistanceFromLeft?.Value == value) return true;
    diffs?.Add(objName, "DistanceFromLeft", openXmlElement?.DistanceFromLeft?.Value, value);
    return false;
  }
  
  private static void SetDistanceFromLeft(DXDW.WrapThrough openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromLeft = value;
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  private static UInt32? GetDistanceFromRight(DXDW.WrapThrough openXmlElement)
  {
    return openXmlElement?.DistanceFromRight?.Value;
  }
  
  private static bool CmpDistanceFromRight(DXDW.WrapThrough openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DistanceFromRight?.Value == value) return true;
    diffs?.Add(objName, "DistanceFromRight", openXmlElement?.DistanceFromRight?.Value, value);
    return false;
  }
  
  private static void SetDistanceFromRight(DXDW.WrapThrough openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromRight = value;
  }
  
  /// <summary>
  /// Wrapping Polygon.
  /// </summary>
  private static DMDW.WrapPolygon? GetWrapPolygon(DXDW.WrapThrough openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.WrapPolygon>();
    if (element != null)
      return DMXDW.WrapPolygonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWrapPolygon(DXDW.WrapThrough openXmlElement, DMDW.WrapPolygon? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDW.WrapPolygonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.WrapPolygon>(), value, diffs, objName, propName);
  }
  
  private static void SetWrapPolygon(DXDW.WrapThrough openXmlElement, DMDW.WrapPolygon? value)
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
  
  public static DMD.Wordprocessing.WrapThrough? CreateModelElement(DXDW.WrapThrough? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Wordprocessing.WrapThrough();
      value.WrapText = GetWrapText(openXmlElement);
      value.DistanceFromLeft = GetDistanceFromLeft(openXmlElement);
      value.DistanceFromRight = GetDistanceFromRight(openXmlElement);
      value.WrapPolygon = GetWrapPolygon(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDW.WrapThrough? openXmlElement, DMDW.WrapThrough? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDW.WrapThrough value)
    where OpenXmlElementType: DXDW.WrapThrough, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDW.WrapThrough openXmlElement, DMDW.WrapThrough value)
  {
    SetWrapText(openXmlElement, value?.WrapText);
    SetDistanceFromLeft(openXmlElement, value?.DistanceFromLeft);
    SetDistanceFromRight(openXmlElement, value?.DistanceFromRight);
    SetWrapPolygon(openXmlElement, value?.WrapPolygon);
  }
}
