namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PageBorders Class.
/// </summary>
public static class PageBordersConverter
{
  /// <summary>
  /// Z-Ordering of Page Border
  /// </summary>
  private static DMW.PageBorderZOrderKind? GetZOrder(DXW.PageBorders openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.PageBorderZOrderValues, DMW.PageBorderZOrderKind>(openXmlElement?.ZOrder?.Value);
  }
  
  private static bool CmpZOrder(DXW.PageBorders openXmlElement, DMW.PageBorderZOrderKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.PageBorderZOrderValues, DMW.PageBorderZOrderKind>(openXmlElement?.ZOrder?.Value, value, diffs, objName, propName);
  }
  
  private static void SetZOrder(DXW.PageBorders openXmlElement, DMW.PageBorderZOrderKind? value)
  {
    openXmlElement.ZOrder = EnumValueConverter.CreateEnumValue<DXW.PageBorderZOrderValues, DMW.PageBorderZOrderKind>(value);
  }
  
  /// <summary>
  /// Pages to Display Page Borders
  /// </summary>
  private static DMW.PageBorderDisplayKind? GetDisplay(DXW.PageBorders openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.PageBorderDisplayValues, DMW.PageBorderDisplayKind>(openXmlElement?.Display?.Value);
  }
  
  private static bool CmpDisplay(DXW.PageBorders openXmlElement, DMW.PageBorderDisplayKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.PageBorderDisplayValues, DMW.PageBorderDisplayKind>(openXmlElement?.Display?.Value, value, diffs, objName, propName);
  }
  
  private static void SetDisplay(DXW.PageBorders openXmlElement, DMW.PageBorderDisplayKind? value)
  {
    openXmlElement.Display = EnumValueConverter.CreateEnumValue<DXW.PageBorderDisplayValues, DMW.PageBorderDisplayKind>(value);
  }
  
  /// <summary>
  /// Page Border Positioning
  /// </summary>
  private static DMW.PageBorderOffsetKind? GetOffsetFrom(DXW.PageBorders openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.PageBorderOffsetValues, DMW.PageBorderOffsetKind>(openXmlElement?.OffsetFrom?.Value);
  }
  
  private static bool CmpOffsetFrom(DXW.PageBorders openXmlElement, DMW.PageBorderOffsetKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.PageBorderOffsetValues, DMW.PageBorderOffsetKind>(openXmlElement?.OffsetFrom?.Value, value, diffs, objName, propName);
  }
  
  private static void SetOffsetFrom(DXW.PageBorders openXmlElement, DMW.PageBorderOffsetKind? value)
  {
    openXmlElement.OffsetFrom = EnumValueConverter.CreateEnumValue<DXW.PageBorderOffsetValues, DMW.PageBorderOffsetKind>(value);
  }
  
  /// <summary>
  /// Top Border.
  /// </summary>
  private static DMW.Border? GetTopBorder(DXW.PageBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TopBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTopBorder(DXW.PageBorders openXmlElement, DMW.Border? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TopBorder>(), value, diffs, objName, propName);
  }
  
  private static void SetTopBorder(DXW.PageBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TopBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.TopBorder>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Left Border.
  /// </summary>
  private static DMW.Border? GetLeftBorder(DXW.PageBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.LeftBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLeftBorder(DXW.PageBorders openXmlElement, DMW.Border? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.LeftBorder>(), value, diffs, objName, propName);
  }
  
  private static void SetLeftBorder(DXW.PageBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LeftBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.LeftBorder>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Bottom Border.
  /// </summary>
  private static DMW.Border? GetBottomBorder(DXW.PageBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BottomBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBottomBorder(DXW.PageBorders openXmlElement, DMW.Border? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BottomBorder>(), value, diffs, objName, propName);
  }
  
  private static void SetBottomBorder(DXW.PageBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BottomBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.BottomBorder>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Right Border.
  /// </summary>
  private static DMW.Border? GetRightBorder(DXW.PageBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RightBorder>();
    if (element != null)
      return DMXW.BorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRightBorder(DXW.PageBorders openXmlElement, DMW.Border? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.BorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RightBorder>(), value, diffs, objName, propName);
  }
  
  private static void SetRightBorder(DXW.PageBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RightBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderConverter.CreateOpenXmlElement<DXW.RightBorder>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMW.PageBorders? CreateModelElement(DXW.PageBorders? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PageBorders();
      value.ZOrder = GetZOrder(openXmlElement);
      value.Display = GetDisplay(openXmlElement);
      value.OffsetFrom = GetOffsetFrom(openXmlElement);
      value.TopBorder = GetTopBorder(openXmlElement);
      value.LeftBorder = GetLeftBorder(openXmlElement);
      value.BottomBorder = GetBottomBorder(openXmlElement);
      value.RightBorder = GetRightBorder(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PageBorders? openXmlElement, DMW.PageBorders? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpZOrder(openXmlElement, value.ZOrder, diffs, objName, propName))
        ok = false;
      if (!CmpDisplay(openXmlElement, value.Display, diffs, objName, propName))
        ok = false;
      if (!CmpOffsetFrom(openXmlElement, value.OffsetFrom, diffs, objName, propName))
        ok = false;
      if (!CmpTopBorder(openXmlElement, value.TopBorder, diffs, objName, propName))
        ok = false;
      if (!CmpLeftBorder(openXmlElement, value.LeftBorder, diffs, objName, propName))
        ok = false;
      if (!CmpBottomBorder(openXmlElement, value.BottomBorder, diffs, objName, propName))
        ok = false;
      if (!CmpRightBorder(openXmlElement, value.RightBorder, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PageBorders value)
    where OpenXmlElementType: DXW.PageBorders, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PageBorders openXmlElement, DMW.PageBorders value)
  {
    SetZOrder(openXmlElement, value?.ZOrder);
    SetDisplay(openXmlElement, value?.Display);
    SetOffsetFrom(openXmlElement, value?.OffsetFrom);
    SetTopBorder(openXmlElement, value?.TopBorder);
    SetLeftBorder(openXmlElement, value?.LeftBorder);
    SetBottomBorder(openXmlElement, value?.BottomBorder);
    SetRightBorder(openXmlElement, value?.RightBorder);
  }
}
