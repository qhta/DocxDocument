using DocumentFormat.OpenXml.Drawing.Charts;
using DataLabels = DocumentModel.Drawings.Charts.DataLabels;
using DropLines = DocumentModel.Drawings.Charts.DropLines;
using HighLowLines = DocumentModel.Drawings.Charts.HighLowLines;
using LineChartSeries = DocumentModel.Drawings.Charts.LineChartSeries;
using StockChart = DocumentFormat.OpenXml.Drawing.Charts.StockChart;
using StockChartExtensionList = DocumentModel.Drawings.Charts.StockChartExtensionList;
using UpDownBars = DocumentModel.Drawings.Charts.UpDownBars;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Stock Charts.
/// </summary>
public static class StockChartConverter
{
  public static Collection<LineChartSeries>? GetLineChartSerieses(StockChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<LineChartSeries>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.LineChartSeries>())
      {
        var newItem = LineChartSeriesConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetLineChartSerieses(StockChart? openXmlElement, Collection<LineChartSeries>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.LineChartSeries>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = LineChartSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LineChartSeries>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DataLabels? GetDataLabels(StockChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataLabels(StockChart? openXmlElement, DataLabels? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DropLines? GetDropLines(StockChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DropLines>();
    if (itemElement != null)
      return DropLinesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDropLines(StockChart? openXmlElement, DropLines? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DropLines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DropLinesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DropLines>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static HighLowLines? GetHighLowLines(StockChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.HighLowLines>();
    if (itemElement != null)
      return HighLowLinesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHighLowLines(StockChart? openXmlElement, HighLowLines? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.HighLowLines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HighLowLinesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.HighLowLines>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static UpDownBars? GetUpDownBars(StockChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.UpDownBars>();
    if (itemElement != null)
      return UpDownBarsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUpDownBars(StockChart? openXmlElement, UpDownBars? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.UpDownBars>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UpDownBarsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.UpDownBars>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<UInt32>? GetAxisIds(StockChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<UInt32>();
      foreach (var item in openXmlElement.Elements<AxisId>())
      {
        var newItem = UInt32ValueConverter.GetValue(item);
        if (newItem != null)
          collection.Add((UInt32)newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetAxisIds(StockChart? openXmlElement, Collection<UInt32>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<AxisId>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = UInt32ValueConverter.CreateOpenXmlElement<AxisId>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static StockChartExtensionList? GetStockChartExtensionList(StockChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StockChartExtensionList>();
    if (itemElement != null)
      return StockChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStockChartExtensionList(StockChart? openXmlElement, StockChartExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StockChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StockChartExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StockChartExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.StockChart? CreateModelElement(StockChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StockChart();
      value.LineChartSerieses = GetLineChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.DropLines = GetDropLines(openXmlElement);
      value.HighLowLines = GetHighLowLines(openXmlElement);
      value.UpDownBars = GetUpDownBars(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.StockChartExtensionList = GetStockChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.StockChart? value)
    where OpenXmlElementType : StockChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLineChartSerieses(openXmlElement, value?.LineChartSerieses);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetDropLines(openXmlElement, value?.DropLines);
      SetHighLowLines(openXmlElement, value?.HighLowLines);
      SetUpDownBars(openXmlElement, value?.UpDownBars);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetStockChartExtensionList(openXmlElement, value?.StockChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}