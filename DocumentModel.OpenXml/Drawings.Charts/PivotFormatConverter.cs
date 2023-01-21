namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Pivot Format.
/// </summary>
public static class PivotFormatConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXDrawCharts.PivotFormat openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Index>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetIndex(DXDrawCharts.PivotFormat openXmlElement, UInt32? value)
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
  /// ShapeProperties.
  /// </summary>
  private static DMDrawsCharts.ShapeProperties? GetShapeProperties(DXDrawCharts.PivotFormat openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ShapeProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DXDrawCharts.PivotFormat openXmlElement, DMDrawsCharts.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ShapePropertiesConverter.CreateOpenXmlElement<DXDrawCharts.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  private static DMDrawsCharts.Marker? GetMarker(DXDrawCharts.PivotFormat openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Marker>();
    if (itemElement != null)
      return DMXDrawsCharts.MarkerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMarker(DXDrawCharts.PivotFormat openXmlElement, DMDrawsCharts.Marker? value)
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
  /// Data Label.
  /// </summary>
  private static DMDrawsCharts.DataLabel? GetDataLabel(DXDrawCharts.PivotFormat openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DataLabel>();
    if (itemElement != null)
      return DMXDrawsCharts.DataLabelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabel(DXDrawCharts.PivotFormat openXmlElement, DMDrawsCharts.DataLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DataLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.DataLabelConverter.CreateOpenXmlElement<DXDrawCharts.DataLabel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.PivotFormat openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDrawCharts.PivotFormat openXmlElement, DMDrawsCharts.ExtensionList? value)
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
  
  public static DMDrawsCharts.PivotFormat? CreateModelElement(DXDrawCharts.PivotFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.PivotFormat();
      value.Index = GetIndex(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Marker = GetMarker(openXmlElement);
      value.DataLabel = GetDataLabel(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.PivotFormat? value)
    where OpenXmlElementType: DXDrawCharts.PivotFormat, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetMarker(openXmlElement, value?.Marker);
      SetDataLabel(openXmlElement, value?.DataLabel);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
