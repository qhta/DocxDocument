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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderZOrderValues, DMW.PageBorderZOrderKind>(openXmlElement?.ZOrder?.Value);
  }
  
  private static void SetZOrder(DXW.PageBorders openXmlElement, DMW.PageBorderZOrderKind? value)
  {
    openXmlElement.ZOrder = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderZOrderValues, DMW.PageBorderZOrderKind>(value);
  }
  
  /// <summary>
  /// Pages to Display Page Borders
  /// </summary>
  private static DMW.PageBorderDisplayKind? GetDisplay(DXW.PageBorders openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderDisplayValues, DMW.PageBorderDisplayKind>(openXmlElement?.Display?.Value);
  }
  
  private static void SetDisplay(DXW.PageBorders openXmlElement, DMW.PageBorderDisplayKind? value)
  {
    openXmlElement.Display = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderDisplayValues, DMW.PageBorderDisplayKind>(value);
  }
  
  /// <summary>
  /// Page Border Positioning
  /// </summary>
  private static DMW.PageBorderOffsetKind? GetOffsetFrom(DXW.PageBorders openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderOffsetValues, DMW.PageBorderOffsetKind>(openXmlElement?.OffsetFrom?.Value);
  }
  
  private static void SetOffsetFrom(DXW.PageBorders openXmlElement, DMW.PageBorderOffsetKind? value)
  {
    openXmlElement.OffsetFrom = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.PageBorderOffsetValues, DMW.PageBorderOffsetKind>(value);
  }
  
  /// <summary>
  /// Top Border.
  /// </summary>
  private static DMW.BorderType? GetTopBorder(DXW.PageBorders openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TopBorder>();
    if (itemElement != null)
      return DMXW.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTopBorder(DXW.PageBorders openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TopBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.TopBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Left Border.
  /// </summary>
  private static DMW.BorderType? GetLeftBorder(DXW.PageBorders openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.LeftBorder>();
    if (itemElement != null)
      return DMXW.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLeftBorder(DXW.PageBorders openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LeftBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.LeftBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Bottom Border.
  /// </summary>
  private static DMW.BorderType? GetBottomBorder(DXW.PageBorders openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.BottomBorder>();
    if (itemElement != null)
      return DMXW.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBottomBorder(DXW.PageBorders openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BottomBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.BottomBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Right Border.
  /// </summary>
  private static DMW.BorderType? GetRightBorder(DXW.PageBorders openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.RightBorder>();
    if (itemElement != null)
      return DMXW.BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRightBorder(DXW.PageBorders openXmlElement, DMW.BorderType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RightBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.RightBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.PageBorders? value)
    where OpenXmlElementType: DXW.PageBorders, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetZOrder(openXmlElement, value?.ZOrder);
      SetDisplay(openXmlElement, value?.Display);
      SetOffsetFrom(openXmlElement, value?.OffsetFrom);
      SetTopBorder(openXmlElement, value?.TopBorder);
      SetLeftBorder(openXmlElement, value?.LeftBorder);
      SetBottomBorder(openXmlElement, value?.BottomBorder);
      SetRightBorder(openXmlElement, value?.RightBorder);
      return openXmlElement;
    }
    return default;
  }
}
