using DocumentFormat.OpenXml.Wordprocessing;
using TableCellMarginDefault = DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault;
using TableWidthDxaNilType = DocumentModel.Wordprocessing.TableWidthDxaNilType;
using TableWidthType = DocumentModel.Wordprocessing.TableWidthType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the TableCellMarginDefault Class.
/// </summary>
public static class TableCellMarginDefaultConverter
{
  /// <summary>
  ///   Table Cell Top Margin Default.
  /// </summary>
  public static TableWidthType? GetTopMargin(TableCellMarginDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TopMargin>();
    if (itemElement != null)
      return TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTopMargin(TableCellMarginDefault? openXmlElement, TableWidthType? value)
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
  ///   Table Cell Left Margin Default.
  /// </summary>
  public static TableWidthDxaNilType? GetTableCellLeftMargin(TableCellMarginDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TableCellLeftMargin>();
    if (itemElement != null)
      return TableWidthDxaNilTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableCellLeftMargin(TableCellMarginDefault? openXmlElement, TableWidthDxaNilType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableCellLeftMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableWidthDxaNilTypeConverter.CreateOpenXmlElement<TableCellLeftMargin>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public static TableWidthType? GetStartMargin(TableCellMarginDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<StartMargin>();
    if (itemElement != null)
      return TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStartMargin(TableCellMarginDefault? openXmlElement, TableWidthType? value)
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
  ///   Table Cell Bottom Margin Default.
  /// </summary>
  public static TableWidthType? GetBottomMargin(TableCellMarginDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BottomMargin>();
    if (itemElement != null)
      return TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBottomMargin(TableCellMarginDefault? openXmlElement, TableWidthType? value)
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
  ///   Table Cell Right Margin Default.
  /// </summary>
  public static TableWidthDxaNilType? GetTableCellRightMargin(TableCellMarginDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TableCellRightMargin>();
    if (itemElement != null)
      return TableWidthDxaNilTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableCellRightMargin(TableCellMarginDefault? openXmlElement, TableWidthDxaNilType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TableCellRightMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableWidthDxaNilTypeConverter.CreateOpenXmlElement<TableCellRightMargin>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public static TableWidthType? GetEndMargin(TableCellMarginDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EndMargin>();
    if (itemElement != null)
      return TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEndMargin(TableCellMarginDefault? openXmlElement, TableWidthType? value)
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

  public static DocumentModel.Wordprocessing.TableCellMarginDefault? CreateModelElement(TableCellMarginDefault? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableCellMarginDefault();
      value.TopMargin = GetTopMargin(openXmlElement);
      value.TableCellLeftMargin = GetTableCellLeftMargin(openXmlElement);
      value.StartMargin = GetStartMargin(openXmlElement);
      value.BottomMargin = GetBottomMargin(openXmlElement);
      value.TableCellRightMargin = GetTableCellRightMargin(openXmlElement);
      value.EndMargin = GetEndMargin(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableCellMarginDefault? value)
    where OpenXmlElementType : TableCellMarginDefault, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTopMargin(openXmlElement, value?.TopMargin);
      SetTableCellLeftMargin(openXmlElement, value?.TableCellLeftMargin);
      SetStartMargin(openXmlElement, value?.StartMargin);
      SetBottomMargin(openXmlElement, value?.BottomMargin);
      SetTableCellRightMargin(openXmlElement, value?.TableCellRightMargin);
      SetEndMargin(openXmlElement, value?.EndMargin);
      return openXmlElement;
    }
    return default;
  }
}