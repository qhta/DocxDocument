namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Surface Chart Series.
/// </summary>
public static class SurfaceChartSeriesConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Index>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetIndex(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries openXmlElement, UInt32? value)
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
  private static UInt32? GetOrder(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Order>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetOrder(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries openXmlElement, UInt32? value)
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
  private static DocumentModel.Drawings.Charts.SeriesText? GetSeriesText(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.SeriesTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSeriesText(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries openXmlElement, DocumentModel.Drawings.Charts.SeriesText? value)
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
  private static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
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
  /// PictureOptions.
  /// </summary>
  private static DocumentModel.Drawings.Charts.PictureOptions? GetPictureOptions(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.PictureOptionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPictureOptions(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries openXmlElement, DocumentModel.Drawings.Charts.PictureOptions? value)
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
  
  /// <summary>
  /// CategoryAxisData.
  /// </summary>
  private static DocumentModel.Drawings.Charts.CategoryAxisData? GetCategoryAxisData(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.CategoryAxisDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCategoryAxisData(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries openXmlElement, DocumentModel.Drawings.Charts.CategoryAxisData? value)
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
  
  /// <summary>
  /// Values.
  /// </summary>
  private static DocumentModel.Drawings.Charts.Values? GetValues(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Values>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ValuesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetValues(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries openXmlElement, DocumentModel.Drawings.Charts.Values? value)
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
  
  /// <summary>
  /// Bubble3D.
  /// </summary>
  private static Boolean? GetBubble3D(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Bubble3D>();
    return itemElement != null;
  }
  
  private static void SetBubble3D(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Bubble3D>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Bubble3D();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SurfaceSerExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.Charts.SurfaceSerExtensionList? GetSurfaceSerExtensionList(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.SurfaceSerExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSurfaceSerExtensionList(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries openXmlElement, DocumentModel.Drawings.Charts.SurfaceSerExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.SurfaceSerExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.SurfaceChartSeries? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SurfaceChartSeries();
      value.Index = GetIndex(openXmlElement);
      value.Order = GetOrder(openXmlElement);
      value.SeriesText = GetSeriesText(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.PictureOptions = GetPictureOptions(openXmlElement);
      value.CategoryAxisData = GetCategoryAxisData(openXmlElement);
      value.Values = GetValues(openXmlElement);
      value.Bubble3D = GetBubble3D(openXmlElement);
      value.SurfaceSerExtensionList = GetSurfaceSerExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.SurfaceChartSeries? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetOrder(openXmlElement, value?.Order);
      SetSeriesText(openXmlElement, value?.SeriesText);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetPictureOptions(openXmlElement, value?.PictureOptions);
      SetCategoryAxisData(openXmlElement, value?.CategoryAxisData);
      SetValues(openXmlElement, value?.Values);
      SetBubble3D(openXmlElement, value?.Bubble3D);
      SetSurfaceSerExtensionList(openXmlElement, value?.SurfaceSerExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
