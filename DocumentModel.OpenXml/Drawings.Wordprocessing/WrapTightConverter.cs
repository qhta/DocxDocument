namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Tight Wrapping.
/// </summary>
public static class WrapTightConverter
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  private static DMDrawsW.WrapTextKind? GetWrapText(DXDrawW.WrapTight openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues, DMDrawsW.WrapTextKind>(openXmlElement?.WrapText?.Value);
  }
  
  private static bool CmpWrapText(DXDrawW.WrapTight openXmlElement, DMDrawsW.WrapTextKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues, DMDrawsW.WrapTextKind>(openXmlElement?.WrapText?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetWrapText(DXDrawW.WrapTight openXmlElement, DMDrawsW.WrapTextKind? value)
  {
    openXmlElement.WrapText = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues, DMDrawsW.WrapTextKind>(value);
  }
  
  /// <summary>
  /// Distance From Test on Left Edge
  /// </summary>
  private static UInt32? GetDistanceFromLeft(DXDrawW.WrapTight openXmlElement)
  {
    return openXmlElement.DistanceFromLeft?.Value;
  }
  
  private static bool CmpDistanceFromLeft(DXDrawW.WrapTight openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.DistanceFromLeft?.Value == value;
  }
  
  private static void SetDistanceFromLeft(DXDrawW.WrapTight openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromLeft = value;
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  private static UInt32? GetDistanceFromRight(DXDrawW.WrapTight openXmlElement)
  {
    return openXmlElement.DistanceFromRight?.Value;
  }
  
  private static bool CmpDistanceFromRight(DXDrawW.WrapTight openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.DistanceFromRight?.Value == value;
  }
  
  private static void SetDistanceFromRight(DXDrawW.WrapTight openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromRight = value;
  }
  
  /// <summary>
  /// Tight Wrapping Extents Polygon.
  /// </summary>
  private static DMDrawsW.WrapPolygon? GetWrapPolygon(DXDrawW.WrapTight openXmlElement)
  {
    return DMXDrawsW.WrapPolygonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawW.WrapPolygon>());
  }
  
  private static bool CmpWrapPolygon(DXDrawW.WrapTight openXmlElement, DMDrawsW.WrapPolygon? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsW.WrapPolygonConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawW.WrapPolygon>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetWrapPolygon(DXDrawW.WrapTight openXmlElement, DMDrawsW.WrapPolygon? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.WrapPolygon>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.WrapPolygonConverter.CreateOpenXmlElement<DXDrawW.WrapPolygon>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsW.WrapTight? CreateModelElement(DXDrawW.WrapTight? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsW.WrapTight();
      value.WrapText = GetWrapText(openXmlElement);
      value.DistanceFromLeft = GetDistanceFromLeft(openXmlElement);
      value.DistanceFromRight = GetDistanceFromRight(openXmlElement);
      value.WrapPolygon = GetWrapPolygon(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawW.WrapTight? openXmlElement, DMDrawsW.WrapTight? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWrapText(openXmlElement, value.WrapText, diffs, objName))
        ok = false;
      if (!CmpDistanceFromLeft(openXmlElement, value.DistanceFromLeft, diffs, objName))
        ok = false;
      if (!CmpDistanceFromRight(openXmlElement, value.DistanceFromRight, diffs, objName))
        ok = false;
      if (!CmpWrapPolygon(openXmlElement, value.WrapPolygon, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsW.WrapTight? value)
    where OpenXmlElementType: DXDrawW.WrapTight, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWrapText(openXmlElement, value?.WrapText);
      SetDistanceFromLeft(openXmlElement, value?.DistanceFromLeft);
      SetDistanceFromRight(openXmlElement, value?.DistanceFromRight);
      SetWrapPolygon(openXmlElement, value?.WrapPolygon);
      return openXmlElement;
    }
    return default;
  }
}
