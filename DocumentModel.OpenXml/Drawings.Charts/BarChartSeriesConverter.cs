namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Bar Chart Series.
/// </summary>
public static class BarChartSeriesConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Index>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetIndex(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement, UInt32? value)
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
  private static UInt32? GetOrder(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Order>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetOrder(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement, UInt32? value)
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
  private static DocumentModel.Drawings.Charts.SeriesText? GetSeriesText(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.SeriesTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSeriesText(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement, DocumentModel.Drawings.Charts.SeriesText? value)
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
  private static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
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
  /// InvertIfNegative.
  /// </summary>
  private static Boolean? GetInvertIfNegative(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative>();
    return itemElement != null;
  }
  
  private static void SetInvertIfNegative(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  private static DocumentModel.Drawings.Charts.PictureOptions? GetPictureOptions(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.PictureOptionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPictureOptions(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement, DocumentModel.Drawings.Charts.PictureOptions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.PictureOptionsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataPoint> GetDataPoints(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement)
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
  
  private static void SetDataPoints(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataPoint>? value)
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
  
  private static DocumentModel.Drawings.Charts.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement, DocumentModel.Drawings.Charts.DataLabels? value)
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
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Trendline> GetTrendlines(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement)
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
  
  private static void SetTrendlines(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Trendline>? value)
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
  
  private static DocumentModel.Drawings.Charts.ErrorBars? GetErrorBars(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorBars>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ErrorBarsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetErrorBars(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement, DocumentModel.Drawings.Charts.ErrorBars? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorBars>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.ErrorBarsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ErrorBars>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.CategoryAxisData? GetCategoryAxisData(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.CategoryAxisDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCategoryAxisData(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement, DocumentModel.Drawings.Charts.CategoryAxisData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.CategoryAxisDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.Values? GetValues(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Values>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ValuesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetValues(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement, DocumentModel.Drawings.Charts.Values? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Values>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.ValuesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Values>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.ShapeKind? GetShape(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Shape>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DocumentModel.Drawings.Charts.ShapeKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetShape(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement, DocumentModel.Drawings.Charts.ShapeKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Shape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Shape, DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DocumentModel.Drawings.Charts.ShapeKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.BarSerExtensionList? GetBarSerExtensionList(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.BarSerExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBarSerExtensionList(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries openXmlElement, DocumentModel.Drawings.Charts.BarSerExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.BarSerExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.BarChartSeries? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BarChartSeries();
      value.Index = GetIndex(openXmlElement);
      value.Order = GetOrder(openXmlElement);
      value.SeriesText = GetSeriesText(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.InvertIfNegative = GetInvertIfNegative(openXmlElement);
      value.PictureOptions = GetPictureOptions(openXmlElement);
      value.DataPoints = GetDataPoints(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.Trendlines = GetTrendlines(openXmlElement);
      value.ErrorBars = GetErrorBars(openXmlElement);
      value.CategoryAxisData = GetCategoryAxisData(openXmlElement);
      value.Values = GetValues(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.BarSerExtensionList = GetBarSerExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.BarChartSeries? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetOrder(openXmlElement, value?.Order);
      SetSeriesText(openXmlElement, value?.SeriesText);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetInvertIfNegative(openXmlElement, value?.InvertIfNegative);
      SetPictureOptions(openXmlElement, value?.PictureOptions);
      SetDataPoints(openXmlElement, value?.DataPoints);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetTrendlines(openXmlElement, value?.Trendlines);
      SetErrorBars(openXmlElement, value?.ErrorBars);
      SetCategoryAxisData(openXmlElement, value?.CategoryAxisData);
      SetValues(openXmlElement, value?.Values);
      SetShape(openXmlElement, value?.Shape);
      SetBarSerExtensionList(openXmlElement, value?.BarSerExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
