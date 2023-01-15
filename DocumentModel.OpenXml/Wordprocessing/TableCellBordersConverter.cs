using DocumentFormat.OpenXml.Wordprocessing;
using BorderType = DocumentModel.Wordprocessing.BorderType;
using TableCellBorders = DocumentFormat.OpenXml.Wordprocessing.TableCellBorders;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the TableCellBorders Class.
/// </summary>
public static class TableCellBordersConverter
{
  /// <summary>
  ///   Table Cell Top Border.
  /// </summary>
  public static BorderType? GetTopBorder(TableCellBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TopBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTopBorder(TableCellBorders? openXmlElement, BorderType? value)
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
  ///   Table Cell Left Border.
  /// </summary>
  public static BorderType? GetLeftBorder(TableCellBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LeftBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLeftBorder(TableCellBorders? openXmlElement, BorderType? value)
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
  ///   StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public static BorderType? GetStartBorder(TableCellBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<StartBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStartBorder(TableCellBorders? openXmlElement, BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StartBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderTypeConverter.CreateOpenXmlElement<StartBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Table Cell Bottom Border.
  /// </summary>
  public static BorderType? GetBottomBorder(TableCellBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BottomBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBottomBorder(TableCellBorders? openXmlElement, BorderType? value)
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
  ///   Table Cell Right Border.
  /// </summary>
  public static BorderType? GetRightBorder(TableCellBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RightBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRightBorder(TableCellBorders? openXmlElement, BorderType? value)
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

  /// <summary>
  ///   EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public static BorderType? GetEndBorder(TableCellBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EndBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEndBorder(TableCellBorders? openXmlElement, BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EndBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderTypeConverter.CreateOpenXmlElement<EndBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Table Cell Inside Horizontal Edges Border.
  /// </summary>
  public static BorderType? GetInsideHorizontalBorder(TableCellBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<InsideHorizontalBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetInsideHorizontalBorder(TableCellBorders? openXmlElement, BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<InsideHorizontalBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderTypeConverter.CreateOpenXmlElement<InsideHorizontalBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Table Cell Inside Vertical Edges Border.
  /// </summary>
  public static BorderType? GetInsideVerticalBorder(TableCellBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<InsideVerticalBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetInsideVerticalBorder(TableCellBorders? openXmlElement, BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<InsideVerticalBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderTypeConverter.CreateOpenXmlElement<InsideVerticalBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Table Cell Top Left to Bottom Right Diagonal Border.
  /// </summary>
  public static BorderType? GetTopLeftToBottomRightCellBorder(TableCellBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TopLeftToBottomRightCellBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTopLeftToBottomRightCellBorder(TableCellBorders? openXmlElement, BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TopLeftToBottomRightCellBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderTypeConverter.CreateOpenXmlElement<TopLeftToBottomRightCellBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Table Cell Top Right to Bottom Left Diagonal Border.
  /// </summary>
  public static BorderType? GetTopRightToBottomLeftCellBorder(TableCellBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TopRightToBottomLeftCellBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTopRightToBottomLeftCellBorder(TableCellBorders? openXmlElement, BorderType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TopRightToBottomLeftCellBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderTypeConverter.CreateOpenXmlElement<TopRightToBottomLeftCellBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.TableCellBorders? CreateModelElement(TableCellBorders? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableCellBorders();
      value.TopBorder = GetTopBorder(openXmlElement);
      value.LeftBorder = GetLeftBorder(openXmlElement);
      value.StartBorder = GetStartBorder(openXmlElement);
      value.BottomBorder = GetBottomBorder(openXmlElement);
      value.RightBorder = GetRightBorder(openXmlElement);
      value.EndBorder = GetEndBorder(openXmlElement);
      value.InsideHorizontalBorder = GetInsideHorizontalBorder(openXmlElement);
      value.InsideVerticalBorder = GetInsideVerticalBorder(openXmlElement);
      value.TopLeftToBottomRightCellBorder = GetTopLeftToBottomRightCellBorder(openXmlElement);
      value.TopRightToBottomLeftCellBorder = GetTopRightToBottomLeftCellBorder(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableCellBorders? value)
    where OpenXmlElementType : TableCellBorders, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTopBorder(openXmlElement, value?.TopBorder);
      SetLeftBorder(openXmlElement, value?.LeftBorder);
      SetStartBorder(openXmlElement, value?.StartBorder);
      SetBottomBorder(openXmlElement, value?.BottomBorder);
      SetRightBorder(openXmlElement, value?.RightBorder);
      SetEndBorder(openXmlElement, value?.EndBorder);
      SetInsideHorizontalBorder(openXmlElement, value?.InsideHorizontalBorder);
      SetInsideVerticalBorder(openXmlElement, value?.InsideVerticalBorder);
      SetTopLeftToBottomRightCellBorder(openXmlElement, value?.TopLeftToBottomRightCellBorder);
      SetTopRightToBottomLeftCellBorder(openXmlElement, value?.TopRightToBottomLeftCellBorder);
      return openXmlElement;
    }
    return default;
  }
}