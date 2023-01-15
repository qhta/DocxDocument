using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using ChartShapeProperties = DocumentModel.Drawings.Charts.ChartShapeProperties;
using ChartText = DocumentModel.Drawings.Charts.ChartText;
using DataLabel = DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel;
using DLblExtensionList = DocumentModel.Drawings.Charts.DLblExtensionList;
using Index = DocumentFormat.OpenXml.Drawing.Charts.Index;
using Layout = DocumentModel.Drawings.Charts.Layout;
using NumberingFormat = DocumentModel.Drawings.Charts.NumberingFormat;
using TextProperties = DocumentModel.Drawings.Charts.TextProperties;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the DataLabel Class.
/// </summary>
public static class DataLabel3Converter
{
  /// <summary>
  ///   Index.
  /// </summary>
  public static UInt32? GetIndex(DataLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Index>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetIndex(DataLabel? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Index>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Index { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetDelete(DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Delete>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDelete(DataLabel? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Delete>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Delete();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Layout? GetLayout(DataLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Layout>();
    if (itemElement != null)
      return LayoutConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLayout(DataLabel? openXmlElement, Layout? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Layout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LayoutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Layout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ChartText? GetChartText(DataLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartText>();
    if (itemElement != null)
      return ChartTextConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartText(DataLabel? openXmlElement, ChartText? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartTextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartText>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static NumberingFormat? GetNumberingFormat(DataLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>();
    if (itemElement != null)
      return NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberingFormat(DataLabel? openXmlElement, NumberingFormat? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingFormatConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ChartShapeProperties? GetChartShapeProperties(DataLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartShapeProperties(DataLabel? openXmlElement, ChartShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextProperties? GetTextProperties(DataLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
    if (itemElement != null)
      return TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextProperties(DataLabel? openXmlElement, TextProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DataLabelPositionKind? GetDataLabelPosition(DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DataLabelPosition>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<DataLabelPositionValues, DataLabelPositionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetDataLabelPosition(DataLabel? openXmlElement, DataLabelPositionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DataLabelPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DataLabelPosition, DataLabelPositionValues, DataLabelPositionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShowLegendKey(DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowLegendKey>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowLegendKey(DataLabel? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowLegendKey>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowLegendKey();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShowValue(DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowValue>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowValue(DataLabel? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowValue>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowValue();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShowCategoryName(DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowCategoryName>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowCategoryName(DataLabel? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowCategoryName>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowCategoryName();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShowSeriesName(DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowSeriesName>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowSeriesName(DataLabel? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowSeriesName>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowSeriesName();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShowPercent(DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowPercent>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowPercent(DataLabel? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowPercent>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowPercent();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShowBubbleSize(DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowBubbleSize>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowBubbleSize(DataLabel? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowBubbleSize>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowBubbleSize();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetSeparator(DataLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Separator>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetSeparator(DataLabel? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Separator>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Separator { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DLblExtensionList? GetDLblExtensionList(DataLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList>();
    if (itemElement != null)
      return DLblExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDLblExtensionList(DataLabel? openXmlElement, DLblExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DLblExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DataLabel3? CreateModelElement(DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DataLabel3();
      value.Index = GetIndex(openXmlElement);
      value.Delete = GetDelete(openXmlElement);
      value.Layout = GetLayout(openXmlElement);
      value.ChartText = GetChartText(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.DataLabelPosition = GetDataLabelPosition(openXmlElement);
      value.ShowLegendKey = GetShowLegendKey(openXmlElement);
      value.ShowValue = GetShowValue(openXmlElement);
      value.ShowCategoryName = GetShowCategoryName(openXmlElement);
      value.ShowSeriesName = GetShowSeriesName(openXmlElement);
      value.ShowPercent = GetShowPercent(openXmlElement);
      value.ShowBubbleSize = GetShowBubbleSize(openXmlElement);
      value.Separator = GetSeparator(openXmlElement);
      value.DLblExtensionList = GetDLblExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DataLabel3? value)
    where OpenXmlElementType : DataLabel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetDelete(openXmlElement, value?.Delete);
      SetLayout(openXmlElement, value?.Layout);
      SetChartText(openXmlElement, value?.ChartText);
      SetNumberingFormat(openXmlElement, value?.NumberingFormat);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetTextProperties(openXmlElement, value?.TextProperties);
      SetDataLabelPosition(openXmlElement, value?.DataLabelPosition);
      SetShowLegendKey(openXmlElement, value?.ShowLegendKey);
      SetShowValue(openXmlElement, value?.ShowValue);
      SetShowCategoryName(openXmlElement, value?.ShowCategoryName);
      SetShowSeriesName(openXmlElement, value?.ShowSeriesName);
      SetShowPercent(openXmlElement, value?.ShowPercent);
      SetShowBubbleSize(openXmlElement, value?.ShowBubbleSize);
      SetSeparator(openXmlElement, value?.Separator);
      SetDLblExtensionList(openXmlElement, value?.DLblExtensionList);
      return openXmlElement;
    }
    return default;
  }
}