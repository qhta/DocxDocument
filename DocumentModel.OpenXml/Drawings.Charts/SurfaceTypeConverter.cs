namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SurfaceType Class converter from/to OpenXml.
///</summary>
public static class SurfaceTypeConverter
{
  /// <summary>
  /// Thickness.
  /// </summary>
  private static Byte? GetThickness(DXDrawCharts.SurfaceType openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.Thickness>()?.Val);
  }
  
  private static bool CmpThickness(DXDrawCharts.SurfaceType openXmlElement, Byte? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.Thickness>()?.Val, value, diffs, objName, "Thickness");
  }
  
  private static void SetThickness(DXDrawCharts.SurfaceType openXmlElement, Byte? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.Thickness,System.Byte>(openXmlElement, value);
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDrawsCharts.ShapeProperties? GetShapeProperties(DXDrawCharts.SurfaceType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ShapeProperties>();
    if (element != null)
      return DMXDrawsCharts.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXDrawCharts.SurfaceType openXmlElement, DMDrawsCharts.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetShapeProperties(DXDrawCharts.SurfaceType openXmlElement, DMDrawsCharts.ShapeProperties? value)
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
  /// Picture Options.
  /// </summary>
  private static DMDrawsCharts.PictureOptions? GetPictureOptions(DXDrawCharts.SurfaceType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.PictureOptions>();
    if (element != null)
      return DMXDrawsCharts.PictureOptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPictureOptions(DXDrawCharts.SurfaceType openXmlElement, DMDrawsCharts.PictureOptions? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.PictureOptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.PictureOptions>(), value, diffs, objName);
  }
  
  private static void SetPictureOptions(DXDrawCharts.SurfaceType openXmlElement, DMDrawsCharts.PictureOptions? value)
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
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.SurfaceType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (element != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawCharts.SurfaceType openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDrawCharts.SurfaceType openXmlElement, DMDrawsCharts.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Charts.SurfaceType? CreateModelElement(DXDrawCharts.SurfaceType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SurfaceType();
      value.Thickness = GetThickness(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.PictureOptions = GetPictureOptions(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.SurfaceType? openXmlElement, DMDrawsCharts.SurfaceType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpThickness(openXmlElement, value.Thickness, diffs, objName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      if (!CmpPictureOptions(openXmlElement, value.PictureOptions, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.SurfaceType value)
    where OpenXmlElementType: DXDrawCharts.SurfaceType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.SurfaceType openXmlElement, DMDrawsCharts.SurfaceType value)
  {
    SetThickness(openXmlElement, value?.Thickness);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetPictureOptions(openXmlElement, value?.PictureOptions);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
