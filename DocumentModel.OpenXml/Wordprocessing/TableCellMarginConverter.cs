using DocumentFormat.OpenXml.Wordprocessing;
using TableCellMargin = DocumentFormat.OpenXml.Wordprocessing.TableCellMargin;
using TableWidthType = DocumentModel.Wordprocessing.TableWidthType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the TableCellMargin Class.
/// </summary>
public static class TableCellMarginConverter
{
  /// <summary>
  ///   Table Cell Top Margin Exception.
  /// </summary>
  public static TableWidthType? GetTopMargin(TableCellMargin? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TopMargin>();
    if (itemElement != null)
      return TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTopMargin(TableCellMargin? openXmlElement, TableWidthType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TopMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableWidthTypeConverter.CreateOpenXmlElement<TopMargin>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Table Cell Left Margin Exception.
  /// </summary>
  public static TableWidthType? GetLeftMargin(TableCellMargin? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LeftMargin>();
    if (itemElement != null)
      return TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLeftMargin(TableCellMargin? openXmlElement, TableWidthType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LeftMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableWidthTypeConverter.CreateOpenXmlElement<LeftMargin>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public static TableWidthType? GetStartMargin(TableCellMargin? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<StartMargin>();
    if (itemElement != null)
      return TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStartMargin(TableCellMargin? openXmlElement, TableWidthType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StartMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableWidthTypeConverter.CreateOpenXmlElement<StartMargin>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Table Cell Bottom Margin Exception.
  /// </summary>
  public static TableWidthType? GetBottomMargin(TableCellMargin? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BottomMargin>();
    if (itemElement != null)
      return TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBottomMargin(TableCellMargin? openXmlElement, TableWidthType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BottomMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableWidthTypeConverter.CreateOpenXmlElement<BottomMargin>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Table Cell Right Margin Exception.
  /// </summary>
  public static TableWidthType? GetRightMargin(TableCellMargin? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RightMargin>();
    if (itemElement != null)
      return TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRightMargin(TableCellMargin? openXmlElement, TableWidthType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RightMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableWidthTypeConverter.CreateOpenXmlElement<RightMargin>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public static TableWidthType? GetEndMargin(TableCellMargin? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EndMargin>();
    if (itemElement != null)
      return TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEndMargin(TableCellMargin? openXmlElement, TableWidthType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EndMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableWidthTypeConverter.CreateOpenXmlElement<EndMargin>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.TableCellMargin? CreateModelElement(TableCellMargin? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableCellMargin();
      value.TopMargin = GetTopMargin(openXmlElement);
      value.LeftMargin = GetLeftMargin(openXmlElement);
      value.StartMargin = GetStartMargin(openXmlElement);
      value.BottomMargin = GetBottomMargin(openXmlElement);
      value.RightMargin = GetRightMargin(openXmlElement);
      value.EndMargin = GetEndMargin(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableCellMargin? value)
    where OpenXmlElementType : TableCellMargin, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTopMargin(openXmlElement, value?.TopMargin);
      SetLeftMargin(openXmlElement, value?.LeftMargin);
      SetStartMargin(openXmlElement, value?.StartMargin);
      SetBottomMargin(openXmlElement, value?.BottomMargin);
      SetRightMargin(openXmlElement, value?.RightMargin);
      SetEndMargin(openXmlElement, value?.EndMargin);
      return openXmlElement;
    }
    return default;
  }
}