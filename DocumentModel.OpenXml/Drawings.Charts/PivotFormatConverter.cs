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
    return openXmlElement?.GetFirstChild<DXDrawCharts.Index>()?.Val?.Value;
  }
  
  private static bool CmpIndex(DXDrawCharts.PivotFormat openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.Index>()?.Val?.Value == value;
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
    return DMXDrawsCharts.ShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ShapeProperties>());
  }
  
  private static bool CmpShapeProperties(DXDrawCharts.PivotFormat openXmlElement, DMDrawsCharts.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ShapePropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.MarkerConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Marker>());
  }
  
  private static bool CmpMarker(DXDrawCharts.PivotFormat openXmlElement, DMDrawsCharts.Marker? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.MarkerConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Marker>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.DataLabelConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.DataLabel>());
  }
  
  private static bool CmpDataLabel(DXDrawCharts.PivotFormat openXmlElement, DMDrawsCharts.DataLabel? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabelConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.DataLabel>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDrawCharts.PivotFormat openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXDrawCharts.PivotFormat? openXmlElement, DMDrawsCharts.PivotFormat? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIndex(openXmlElement, value.Index, diffs, objName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      if (!CmpMarker(openXmlElement, value.Marker, diffs, objName))
        ok = false;
      if (!CmpDataLabel(openXmlElement, value.DataLabel, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
