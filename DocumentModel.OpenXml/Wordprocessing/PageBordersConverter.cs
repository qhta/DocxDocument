using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using BorderType = DocumentModel.Wordprocessing.BorderType;
using PageBorders = DocumentFormat.OpenXml.Wordprocessing.PageBorders;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the PageBorders Class.
/// </summary>
public static class PageBordersConverter
{
  /// <summary>
  ///   Z-Ordering of Page Border
  /// </summary>
  public static PageBorderZOrderKind? GetZOrder(PageBorders? openXmlElement)
  {
    return EnumValueConverter.GetValue<PageBorderZOrderValues, PageBorderZOrderKind>(openXmlElement?.ZOrder?.Value);
  }

  public static void SetZOrder(PageBorders? openXmlElement, PageBorderZOrderKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ZOrder = EnumValueConverter.CreateEnumValue<PageBorderZOrderValues, PageBorderZOrderKind>(value);
  }

  /// <summary>
  ///   Pages to Display Page Borders
  /// </summary>
  public static PageBorderDisplayKind? GetDisplay(PageBorders? openXmlElement)
  {
    return EnumValueConverter.GetValue<PageBorderDisplayValues, PageBorderDisplayKind>(openXmlElement?.Display?.Value);
  }

  public static void SetDisplay(PageBorders? openXmlElement, PageBorderDisplayKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Display = EnumValueConverter.CreateEnumValue<PageBorderDisplayValues, PageBorderDisplayKind>(value);
  }

  /// <summary>
  ///   Page Border Positioning
  /// </summary>
  public static PageBorderOffsetKind? GetOffsetFrom(PageBorders? openXmlElement)
  {
    return EnumValueConverter.GetValue<PageBorderOffsetValues, PageBorderOffsetKind>(openXmlElement?.OffsetFrom?.Value);
  }

  public static void SetOffsetFrom(PageBorders? openXmlElement, PageBorderOffsetKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.OffsetFrom = EnumValueConverter.CreateEnumValue<PageBorderOffsetValues, PageBorderOffsetKind>(value);
  }

  /// <summary>
  ///   Top Border.
  /// </summary>
  public static BorderType? GetTopBorder(PageBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TopBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTopBorder(PageBorders? openXmlElement, BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TopBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderTypeConverter.CreateOpenXmlElement<TopBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Left Border.
  /// </summary>
  public static BorderType? GetLeftBorder(PageBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LeftBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLeftBorder(PageBorders? openXmlElement, BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LeftBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderTypeConverter.CreateOpenXmlElement<LeftBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Bottom Border.
  /// </summary>
  public static BorderType? GetBottomBorder(PageBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BottomBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBottomBorder(PageBorders? openXmlElement, BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BottomBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderTypeConverter.CreateOpenXmlElement<BottomBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Right Border.
  /// </summary>
  public static BorderType? GetRightBorder(PageBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RightBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRightBorder(PageBorders? openXmlElement, BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RightBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderTypeConverter.CreateOpenXmlElement<RightBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.PageBorders? CreateModelElement(PageBorders? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PageBorders();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PageBorders? value)
    where OpenXmlElementType : PageBorders, new()
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