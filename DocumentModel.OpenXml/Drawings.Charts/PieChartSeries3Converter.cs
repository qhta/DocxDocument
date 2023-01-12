namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PieChartSeries Class.
/// </summary>
public static class PieChartSeries3Converter
{
  /// <summary>
  /// Index.
  /// </summary>
  public static UInt32? GetIndex(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Index>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetIndex(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Order.
  /// </summary>
  public static UInt32? GetOrder(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Order>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetOrder(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  public static DocumentModel.Drawings.Charts.SeriesText? GetSeriesText(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.SeriesTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSeriesText(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement, DocumentModel.Drawings.Charts.SeriesText? value)
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
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChartShapeProperties(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
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
  /// PictureOptions.
  /// </summary>
  public static DocumentModel.Drawings.Charts.PictureOptions? GetPictureOptions(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.PictureOptionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPictureOptions(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement, DocumentModel.Drawings.Charts.PictureOptions? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Explosion.
  /// </summary>
  public static UInt32? GetExplosion(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Explosion>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetExplosion(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Explosion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Explosion{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataPoint>? GetDataPoints(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement)
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
  
  public static void SetDataPoints(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataPoint>? value)
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
  
  public static DocumentModel.Drawings.Charts.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDataLabels(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement, DocumentModel.Drawings.Charts.DataLabels? value)
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
  
  public static DocumentModel.Drawings.Charts.CategoryAxisData? GetCategoryAxisData(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.CategoryAxisDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCategoryAxisData(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement, DocumentModel.Drawings.Charts.CategoryAxisData? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Charts.Values? GetValues(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Values>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ValuesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetValues(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement, DocumentModel.Drawings.Charts.Values? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Charts.PieSerExtensionList? GetPieSerExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.PieSerExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPieSerExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement, DocumentModel.Drawings.Charts.PieSerExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.PieSerExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.PieChartSeries3? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PieChartSeries3();
      value.Index = GetIndex(openXmlElement);
      value.Order = GetOrder(openXmlElement);
      value.SeriesText = GetSeriesText(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.PictureOptions = GetPictureOptions(openXmlElement);
      value.Explosion = GetExplosion(openXmlElement);
      value.DataPoints = GetDataPoints(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.CategoryAxisData = GetCategoryAxisData(openXmlElement);
      value.Values = GetValues(openXmlElement);
      value.PieSerExtensionList = GetPieSerExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.PieChartSeries3? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetOrder(openXmlElement, value?.Order);
      SetSeriesText(openXmlElement, value?.SeriesText);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetPictureOptions(openXmlElement, value?.PictureOptions);
      SetExplosion(openXmlElement, value?.Explosion);
      return openXmlElement;
    }
    return default;
  }
}
