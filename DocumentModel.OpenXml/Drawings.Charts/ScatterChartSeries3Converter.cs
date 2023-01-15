using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using ChartShapeProperties = DocumentModel.Drawings.Charts.ChartShapeProperties;
using DataLabels = DocumentModel.Drawings.Charts.DataLabels;
using DataPoint = DocumentModel.Drawings.Charts.DataPoint;
using ErrorBars = DocumentModel.Drawings.Charts.ErrorBars;
using Index = DocumentFormat.OpenXml.Drawing.Charts.Index;
using Marker = DocumentModel.Drawings.Charts.Marker;
using ScatterChartSeries = DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries;
using ScatterSerExtensionList = DocumentModel.Drawings.Charts.ScatterSerExtensionList;
using SeriesText = DocumentModel.Drawings.Charts.SeriesText;
using Trendline = DocumentModel.Drawings.Charts.Trendline;
using XValues = DocumentModel.Drawings.Charts.XValues;
using YValues = DocumentModel.Drawings.Charts.YValues;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the ScatterChartSeries Class.
/// </summary>
public static class ScatterChartSeries3Converter
{
  /// <summary>
  ///   Index.
  /// </summary>
  public static UInt32? GetIndex(ScatterChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Index>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetIndex(ScatterChartSeries? openXmlElement, UInt32? value)
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
  public static UInt32? GetOrder(ScatterChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Order>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetOrder(ScatterChartSeries? openXmlElement, UInt32? value)
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
  public static SeriesText? GetSeriesText(ScatterChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
    if (itemElement != null)
      return SeriesTextConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSeriesText(ScatterChartSeries? openXmlElement, SeriesText? value)
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
  public static ChartShapeProperties? GetChartShapeProperties(ScatterChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartShapeProperties(ScatterChartSeries? openXmlElement, ChartShapeProperties? value)
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
  ///   Marker.
  /// </summary>
  public static Marker? GetMarker(ScatterChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
    if (itemElement != null)
      return MarkerConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMarker(ScatterChartSeries? openXmlElement, Marker? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkerConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Marker>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<DataPoint>? GetDataPoints(ScatterChartSeries? openXmlElement)
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

  public static void SetDataPoints(ScatterChartSeries? openXmlElement, Collection<DataPoint>? value)
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

  public static DataLabels? GetDataLabels(ScatterChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataLabels(ScatterChartSeries? openXmlElement, DataLabels? value)
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

  public static Collection<Trendline>? GetTrendlines(ScatterChartSeries? openXmlElement)
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

  public static void SetTrendlines(ScatterChartSeries? openXmlElement, Collection<Trendline>? value)
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

  public static Collection<ErrorBars>? GetErrorBarses(ScatterChartSeries? openXmlElement)
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

  public static void SetErrorBarses(ScatterChartSeries? openXmlElement, Collection<ErrorBars>? value)
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

  public static XValues? GetXValues(ScatterChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.XValues>();
    if (itemElement != null)
      return XValuesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetXValues(ScatterChartSeries? openXmlElement, XValues? value)
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

  public static YValues? GetYValues(ScatterChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.YValues>();
    if (itemElement != null)
      return YValuesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetYValues(ScatterChartSeries? openXmlElement, YValues? value)
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

  public static Boolean? GetSmooth(ScatterChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Smooth>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSmooth(ScatterChartSeries? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Smooth>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Smooth();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ScatterSerExtensionList? GetScatterSerExtensionList(ScatterChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList>();
    if (itemElement != null)
      return ScatterSerExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetScatterSerExtensionList(ScatterChartSeries? openXmlElement, ScatterSerExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ScatterSerExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ScatterChartSeries3? CreateModelElement(ScatterChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new ScatterChartSeries3();
      value.Index = GetIndex(openXmlElement);
      value.Order = GetOrder(openXmlElement);
      value.SeriesText = GetSeriesText(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.Marker = GetMarker(openXmlElement);
      value.DataPoints = GetDataPoints(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.Trendlines = GetTrendlines(openXmlElement);
      value.ErrorBarses = GetErrorBarses(openXmlElement);
      value.XValues = GetXValues(openXmlElement);
      value.YValues = GetYValues(openXmlElement);
      value.Smooth = GetSmooth(openXmlElement);
      value.ScatterSerExtensionList = GetScatterSerExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(ScatterChartSeries3? value)
    where OpenXmlElementType : ScatterChartSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetOrder(openXmlElement, value?.Order);
      SetSeriesText(openXmlElement, value?.SeriesText);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetMarker(openXmlElement, value?.Marker);
      SetDataPoints(openXmlElement, value?.DataPoints);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetTrendlines(openXmlElement, value?.Trendlines);
      SetErrorBarses(openXmlElement, value?.ErrorBarses);
      SetXValues(openXmlElement, value?.XValues);
      SetYValues(openXmlElement, value?.YValues);
      SetSmooth(openXmlElement, value?.Smooth);
      SetScatterSerExtensionList(openXmlElement, value?.ScatterSerExtensionList);
      return openXmlElement;
    }
    return default;
  }
}