using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using BubbleChartSeries = DocumentFormat.OpenXml.Office2013.Drawing.Chart.BubbleChartSeries;
using BubbleSerExtensionList = DocumentModel.Drawings.Charts.BubbleSerExtensionList;
using BubbleSize = DocumentModel.Drawings.Charts.BubbleSize;
using ChartShapeProperties = DocumentModel.Drawings.Charts.ChartShapeProperties;
using DataLabels = DocumentModel.Drawings.Charts.DataLabels;
using DataPoint = DocumentModel.Drawings.Charts.DataPoint;
using ErrorBars = DocumentModel.Drawings.Charts.ErrorBars;
using Index = DocumentFormat.OpenXml.Drawing.Charts.Index;
using PictureOptions = DocumentModel.Drawings.Charts.PictureOptions;
using SeriesText = DocumentModel.Drawings.Charts.SeriesText;
using Trendline = DocumentModel.Drawings.Charts.Trendline;
using XValues = DocumentModel.Drawings.Charts.XValues;
using YValues = DocumentModel.Drawings.Charts.YValues;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the BubbleChartSeries Class.
/// </summary>
public static class BubbleChartSeries3Converter
{
  /// <summary>
  ///   Index.
  /// </summary>
  public static UInt32? GetIndex(BubbleChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Index>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetIndex(BubbleChartSeries? openXmlElement, UInt32? value)
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

  /// <summary>
  ///   Order.
  /// </summary>
  public static UInt32? GetOrder(BubbleChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Order>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetOrder(BubbleChartSeries? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Order>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Order { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Series Text.
  /// </summary>
  public static SeriesText? GetSeriesText(BubbleChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
    if (itemElement != null)
      return SeriesTextConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSeriesText(BubbleChartSeries? openXmlElement, SeriesText? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SeriesTextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public static ChartShapeProperties? GetChartShapeProperties(BubbleChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartShapeProperties(BubbleChartSeries? openXmlElement, ChartShapeProperties? value)
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

  /// <summary>
  ///   PictureOptions.
  /// </summary>
  public static PictureOptions? GetPictureOptions(BubbleChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
    if (itemElement != null)
      return PictureOptionsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPictureOptions(BubbleChartSeries? openXmlElement, PictureOptions? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PictureOptionsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   InvertIfNegative.
  /// </summary>
  public static Boolean? GetInvertIfNegative(BubbleChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<InvertIfNegative>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetInvertIfNegative(BubbleChartSeries? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<InvertIfNegative>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new InvertIfNegative();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<DataPoint>? GetDataPoints(BubbleChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DataPoint>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.DataPoint>())
      {
        var newItem = DataPointConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetDataPoints(BubbleChartSeries? openXmlElement, Collection<DataPoint>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.DataPoint>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = DataPointConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataPoint>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DataLabels? GetDataLabels(BubbleChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataLabels(BubbleChartSeries? openXmlElement, DataLabels? value)
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

  public static Collection<Trendline>? GetTrendlines(BubbleChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Trendline>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Trendline>())
      {
        var newItem = TrendlineConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetTrendlines(BubbleChartSeries? openXmlElement, Collection<Trendline>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Trendline>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = TrendlineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Trendline>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static Collection<ErrorBars>? GetErrorBarses(BubbleChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ErrorBars>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ErrorBars>())
      {
        var newItem = ErrorBarsConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetErrorBarses(BubbleChartSeries? openXmlElement, Collection<ErrorBars>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ErrorBars>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ErrorBarsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ErrorBars>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static XValues? GetXValues(BubbleChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.XValues>();
    if (itemElement != null)
      return XValuesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetXValues(BubbleChartSeries? openXmlElement, XValues? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.XValues>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = XValuesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.XValues>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static YValues? GetYValues(BubbleChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.YValues>();
    if (itemElement != null)
      return YValuesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetYValues(BubbleChartSeries? openXmlElement, YValues? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.YValues>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = YValuesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.YValues>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BubbleSize? GetBubbleSize(BubbleChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BubbleSize>();
    if (itemElement != null)
      return BubbleSizeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBubbleSize(BubbleChartSeries? openXmlElement, BubbleSize? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BubbleSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BubbleSizeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BubbleSize>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetBubble3D(BubbleChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Bubble3D>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBubble3D(BubbleChartSeries? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Bubble3D>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Bubble3D();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BubbleSerExtensionList? GetBubbleSerExtensionList(BubbleChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList>();
    if (itemElement != null)
      return BubbleSerExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBubbleSerExtensionList(BubbleChartSeries? openXmlElement, BubbleSerExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BubbleSerExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BubbleChartSeries3? CreateModelElement(BubbleChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new BubbleChartSeries3();
      value.Index = GetIndex(openXmlElement);
      value.Order = GetOrder(openXmlElement);
      value.SeriesText = GetSeriesText(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.PictureOptions = GetPictureOptions(openXmlElement);
      value.InvertIfNegative = GetInvertIfNegative(openXmlElement);
      value.DataPoints = GetDataPoints(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.Trendlines = GetTrendlines(openXmlElement);
      value.ErrorBarses = GetErrorBarses(openXmlElement);
      value.XValues = GetXValues(openXmlElement);
      value.YValues = GetYValues(openXmlElement);
      value.BubbleSize = GetBubbleSize(openXmlElement);
      value.Bubble3D = GetBubble3D(openXmlElement);
      value.BubbleSerExtensionList = GetBubbleSerExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(BubbleChartSeries3? value)
    where OpenXmlElementType : BubbleChartSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetOrder(openXmlElement, value?.Order);
      SetSeriesText(openXmlElement, value?.SeriesText);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetPictureOptions(openXmlElement, value?.PictureOptions);
      SetInvertIfNegative(openXmlElement, value?.InvertIfNegative);
      SetDataPoints(openXmlElement, value?.DataPoints);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetTrendlines(openXmlElement, value?.Trendlines);
      SetErrorBarses(openXmlElement, value?.ErrorBarses);
      SetXValues(openXmlElement, value?.XValues);
      SetYValues(openXmlElement, value?.YValues);
      SetBubbleSize(openXmlElement, value?.BubbleSize);
      SetBubble3D(openXmlElement, value?.Bubble3D);
      SetBubbleSerExtensionList(openXmlElement, value?.BubbleSerExtensionList);
      return openXmlElement;
    }
    return default;
  }
}