using DocumentFormat.OpenXml.Drawing.Charts;
using CategoryAxisData = DocumentModel.Drawings.Charts.CategoryAxisData;
using ChartShapeProperties = DocumentModel.Drawings.Charts.ChartShapeProperties;
using DataLabels = DocumentModel.Drawings.Charts.DataLabels;
using DataPoint = DocumentModel.Drawings.Charts.DataPoint;
using ErrorBars = DocumentModel.Drawings.Charts.ErrorBars;
using Index = DocumentFormat.OpenXml.Drawing.Charts.Index;
using LineSerExtensionList = DocumentModel.Drawings.Charts.LineSerExtensionList;
using Marker = DocumentModel.Drawings.Charts.Marker;
using PictureOptions = DocumentModel.Drawings.Charts.PictureOptions;
using SeriesText = DocumentModel.Drawings.Charts.SeriesText;
using Trendline = DocumentModel.Drawings.Charts.Trendline;
using Values = DocumentModel.Drawings.Charts.Values;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the LineChartSeries Class.
/// </summary>
public static class LineChartSeriesConverter
{
  /// <summary>
  ///   Index.
  /// </summary>
  public static UInt32? GetIndex(LineChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Index>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetIndex(LineChartSeries? openXmlElement, UInt32? value)
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
  public static UInt32? GetOrder(LineChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Order>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetOrder(LineChartSeries? openXmlElement, UInt32? value)
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
  public static SeriesText? GetSeriesText(LineChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
    if (itemElement != null)
      return SeriesTextConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSeriesText(LineChartSeries? openXmlElement, SeriesText? value)
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
  public static ChartShapeProperties? GetChartShapeProperties(LineChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartShapeProperties(LineChartSeries? openXmlElement, ChartShapeProperties? value)
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
  public static Marker? GetMarker(LineChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
    if (itemElement != null)
      return MarkerConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMarker(LineChartSeries? openXmlElement, Marker? value)
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

  /// <summary>
  ///   PictureOptions.
  /// </summary>
  public static PictureOptions? GetPictureOptions(LineChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
    if (itemElement != null)
      return PictureOptionsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPictureOptions(LineChartSeries? openXmlElement, PictureOptions? value)
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

  public static Collection<DataPoint>? GetDataPoints(LineChartSeries? openXmlElement)
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

  public static void SetDataPoints(LineChartSeries? openXmlElement, Collection<DataPoint>? value)
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

  public static DataLabels? GetDataLabels(LineChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataLabels(LineChartSeries? openXmlElement, DataLabels? value)
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

  public static Collection<Trendline>? GetTrendlines(LineChartSeries? openXmlElement)
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

  public static void SetTrendlines(LineChartSeries? openXmlElement, Collection<Trendline>? value)
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

  public static ErrorBars? GetErrorBars(LineChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorBars>();
    if (itemElement != null)
      return ErrorBarsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetErrorBars(LineChartSeries? openXmlElement, ErrorBars? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorBars>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ErrorBarsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ErrorBars>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static CategoryAxisData? GetCategoryAxisData(LineChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData>();
    if (itemElement != null)
      return CategoryAxisDataConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCategoryAxisData(LineChartSeries? openXmlElement, CategoryAxisData? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CategoryAxisDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Values? GetValues(LineChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Values>();
    if (itemElement != null)
      return ValuesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetValues(LineChartSeries? openXmlElement, Values? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Values>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ValuesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Values>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetSmooth(LineChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Smooth>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSmooth(LineChartSeries? openXmlElement, Boolean? value)
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

  public static LineSerExtensionList? GetLineSerExtensionList(LineChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList>();
    if (itemElement != null)
      return LineSerExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLineSerExtensionList(LineChartSeries? openXmlElement, LineSerExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineSerExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.LineChartSeries? CreateModelElement(LineChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.LineChartSeries();
      value.Index = GetIndex(openXmlElement);
      value.Order = GetOrder(openXmlElement);
      value.SeriesText = GetSeriesText(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.Marker = GetMarker(openXmlElement);
      value.PictureOptions = GetPictureOptions(openXmlElement);
      value.DataPoints = GetDataPoints(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.Trendlines = GetTrendlines(openXmlElement);
      value.ErrorBars = GetErrorBars(openXmlElement);
      value.CategoryAxisData = GetCategoryAxisData(openXmlElement);
      value.Values = GetValues(openXmlElement);
      value.Smooth = GetSmooth(openXmlElement);
      value.LineSerExtensionList = GetLineSerExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.LineChartSeries? value)
    where OpenXmlElementType : LineChartSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetOrder(openXmlElement, value?.Order);
      SetSeriesText(openXmlElement, value?.SeriesText);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetMarker(openXmlElement, value?.Marker);
      SetPictureOptions(openXmlElement, value?.PictureOptions);
      SetDataPoints(openXmlElement, value?.DataPoints);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetTrendlines(openXmlElement, value?.Trendlines);
      SetErrorBars(openXmlElement, value?.ErrorBars);
      SetCategoryAxisData(openXmlElement, value?.CategoryAxisData);
      SetValues(openXmlElement, value?.Values);
      SetSmooth(openXmlElement, value?.Smooth);
      SetLineSerExtensionList(openXmlElement, value?.LineSerExtensionList);
      return openXmlElement;
    }
    return default;
  }
}