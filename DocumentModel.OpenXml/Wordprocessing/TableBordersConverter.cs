using DocumentFormat.OpenXml.Wordprocessing;
using BorderType = DocumentModel.Wordprocessing.BorderType;
using TableBorders = DocumentFormat.OpenXml.Wordprocessing.TableBorders;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the TableBorders Class.
/// </summary>
public static class TableBordersConverter
{
  /// <summary>
  ///   Table Top Border.
  /// </summary>
  public static BorderType? GetTopBorder(TableBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TopBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTopBorder(TableBorders? openXmlElement, BorderType? value)
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
  ///   Table Left Border.
  /// </summary>
  public static BorderType? GetLeftBorder(TableBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LeftBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLeftBorder(TableBorders? openXmlElement, BorderType? value)
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
  public static BorderType? GetStartBorder(TableBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<StartBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStartBorder(TableBorders? openXmlElement, BorderType? value)
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
  ///   Table Bottom Border.
  /// </summary>
  public static BorderType? GetBottomBorder(TableBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BottomBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBottomBorder(TableBorders? openXmlElement, BorderType? value)
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
  ///   Table Right Border.
  /// </summary>
  public static BorderType? GetRightBorder(TableBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RightBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRightBorder(TableBorders? openXmlElement, BorderType? value)
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
  public static BorderType? GetEndBorder(TableBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EndBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEndBorder(TableBorders? openXmlElement, BorderType? value)
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
  ///   Table Inside Horizontal Edges Border.
  /// </summary>
  public static BorderType? GetInsideHorizontalBorder(TableBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<InsideHorizontalBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetInsideHorizontalBorder(TableBorders? openXmlElement, BorderType? value)
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
  ///   Table Inside Vertical Edges Border.
  /// </summary>
  public static BorderType? GetInsideVerticalBorder(TableBorders? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<InsideVerticalBorder>();
    if (itemElement != null)
      return BorderTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetInsideVerticalBorder(TableBorders? openXmlElement, BorderType? value)
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

  public static DocumentModel.Wordprocessing.TableBorders? CreateModelElement(TableBorders? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableBorders();
      value.TopBorder = GetTopBorder(openXmlElement);
      value.LeftBorder = GetLeftBorder(openXmlElement);
      value.StartBorder = GetStartBorder(openXmlElement);
      value.BottomBorder = GetBottomBorder(openXmlElement);
      value.RightBorder = GetRightBorder(openXmlElement);
      value.EndBorder = GetEndBorder(openXmlElement);
      value.InsideHorizontalBorder = GetInsideHorizontalBorder(openXmlElement);
      value.InsideVerticalBorder = GetInsideVerticalBorder(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableBorders? value)
    where OpenXmlElementType : TableBorders, new()
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
      return openXmlElement;
    }
    return default;
  }
}