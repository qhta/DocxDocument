namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataPoint Class.
/// </summary>
public static class DataPointConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXDrawCharts.DataPoint openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Index>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetIndex(DXDrawCharts.DataPoint openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Index>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Index{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Invert if Negative.
  /// </summary>
  private static Boolean? GetInvertIfNegative(DXDrawCharts.DataPoint openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.InvertIfNegative>();
    return itemElement != null;
  }
  
  private static void SetInvertIfNegative(DXDrawCharts.DataPoint openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.InvertIfNegative>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.InvertIfNegative();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  private static DMDrawsCharts.Marker? GetMarker(DXDrawCharts.DataPoint openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Marker>();
    if (itemElement != null)
      return DMXDrawsCharts.MarkerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMarker(DXDrawCharts.DataPoint openXmlElement, DMDrawsCharts.Marker? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Marker>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.MarkerConverter.CreateOpenXmlElement<DXDrawCharts.Marker>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// 3D Bubble.
  /// </summary>
  private static Boolean? GetBubble3D(DXDrawCharts.DataPoint openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Bubble3D>();
    return itemElement != null;
  }
  
  private static void SetBubble3D(DXDrawCharts.DataPoint openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Bubble3D>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.Bubble3D();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Explosion.
  /// </summary>
  private static UInt32? GetExplosion(DXDrawCharts.DataPoint openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Explosion>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetExplosion(DXDrawCharts.DataPoint openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Explosion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Explosion{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXDrawCharts.DataPoint openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartShapeProperties(DXDrawCharts.DataPoint openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ChartShapePropertiesConverter.CreateOpenXmlElement<DXDrawCharts.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  private static DMDrawsCharts.PictureOptions? GetPictureOptions(DXDrawCharts.DataPoint openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.PictureOptions>();
    if (itemElement != null)
      return DMXDrawsCharts.PictureOptionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPictureOptions(DXDrawCharts.DataPoint openXmlElement, DMDrawsCharts.PictureOptions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PictureOptions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.PictureOptionsConverter.CreateOpenXmlElement<DXDrawCharts.PictureOptions>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.DataPoint openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDrawCharts.DataPoint openXmlElement, DMDrawsCharts.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.DataPoint? CreateModelElement(DXDrawCharts.DataPoint? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.DataPoint();
      value.Index = GetIndex(openXmlElement);
      value.InvertIfNegative = GetInvertIfNegative(openXmlElement);
      value.Marker = GetMarker(openXmlElement);
      value.Bubble3D = GetBubble3D(openXmlElement);
      value.Explosion = GetExplosion(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.PictureOptions = GetPictureOptions(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DataPoint? value)
    where OpenXmlElementType: DXDrawCharts.DataPoint, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetInvertIfNegative(openXmlElement, value?.InvertIfNegative);
      SetMarker(openXmlElement, value?.Marker);
      SetBubble3D(openXmlElement, value?.Bubble3D);
      SetExplosion(openXmlElement, value?.Explosion);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetPictureOptions(openXmlElement, value?.PictureOptions);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
