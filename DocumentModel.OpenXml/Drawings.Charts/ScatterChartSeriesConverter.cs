namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ScatterChartSeries Class.
/// </summary>
public static class ScatterChartSeriesConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Index>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetIndex(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Index>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Index{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Order.
  /// </summary>
  private static UInt32? GetOrder(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Order>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetOrder(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Order>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Order{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  private static DocumentModel.Drawings.Charts.SeriesText? GetSeriesText(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.SeriesTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSeriesText(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement, DocumentModel.Drawings.Charts.SeriesText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.SeriesTextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  private static DocumentModel.Drawings.Charts.Marker? GetMarker(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.MarkerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMarker(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement, DocumentModel.Drawings.Charts.Marker? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.MarkerConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Marker>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataPoint> GetDataPoints(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataPoint>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.DataPoint>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Charts.DataPointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetDataPoints(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataPoint>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.DataPoint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.DataPointConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataPoint>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DocumentModel.Drawings.Charts.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement, DocumentModel.Drawings.Charts.DataLabels? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.DataLabelsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Trendline> GetTrendlines(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Trendline>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Trendline>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Charts.TrendlineConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetTrendlines(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Trendline>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Trendline>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.TrendlineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Trendline>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.ErrorBars> GetErrorBarses(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.ErrorBars>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ErrorBars>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Charts.ErrorBarsConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetErrorBarses(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.ErrorBars>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ErrorBars>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.ErrorBarsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ErrorBars>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DocumentModel.Drawings.Charts.XValues? GetXValues(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.XValues>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.XValuesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetXValues(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement, DocumentModel.Drawings.Charts.XValues? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.XValues>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.XValuesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.XValues>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.YValues? GetYValues(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.YValues>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.YValuesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetYValues(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement, DocumentModel.Drawings.Charts.YValues? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.YValues>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.YValuesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.YValues>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSmooth(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Smooth>();
    return itemElement != null;
  }
  
  private static void SetSmooth(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Smooth>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Smooth();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.ScatterSerExtensionList? GetScatterSerExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ScatterSerExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetScatterSerExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries openXmlElement, DocumentModel.Drawings.Charts.ScatterSerExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.ScatterSerExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.ScatterChartSeries? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ScatterChartSeries();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ScatterChartSeries? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries, new()
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
