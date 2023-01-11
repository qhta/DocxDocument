namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ScatterChartSeries Class.
/// </summary>
public static class ScatterChartSeries3Converter
{
  /// <summary>
  /// Index.
  /// </summary>
  public static UInt32? GetIndex(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Index");
  }
  
  public static void SetIndex(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Index");
  }
  
  /// <summary>
  /// Order.
  /// </summary>
  public static UInt32? GetOrder(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Order");
  }
  
  public static void SetOrder(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Order");
  }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  public static DocumentModel.Drawings.Charts.SeriesText? GetSeriesText(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.SeriesTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSeriesText(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement, DocumentModel.Drawings.Charts.SeriesText? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChartShapeProperties(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public static DocumentModel.Drawings.Charts.Marker? GetMarker(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.MarkerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMarker(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement, DocumentModel.Drawings.Charts.Marker? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataPoint>? GetDataPoints(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
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
    return null;
  }
  
  public static void SetDataPoints(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataPoint>? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Charts.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDataLabels(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement, DocumentModel.Drawings.Charts.DataLabels? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Trendline>? GetTrendlines(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
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
    return null;
  }
  
  public static void SetTrendlines(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Trendline>? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.ErrorBars>? GetErrorBarses(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
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
    return null;
  }
  
  public static void SetErrorBarses(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.ErrorBars>? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Charts.XValues? GetXValues(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.XValues>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.XValuesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetXValues(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement, DocumentModel.Drawings.Charts.XValues? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Charts.YValues? GetYValues(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.YValues>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.YValuesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetYValues(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement, DocumentModel.Drawings.Charts.YValues? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetSmooth(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Smooth>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetSmooth(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Charts.ScatterSerExtensionList? GetScatterSerExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ScatterSerExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetScatterSerExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement, DocumentModel.Drawings.Charts.ScatterSerExtensionList? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Charts.ScatterChartSeries3? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ScatterChartSeries3();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ScatterChartSeries3? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
