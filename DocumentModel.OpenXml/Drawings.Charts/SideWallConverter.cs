namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D side wall formatting.
/// </summary>
public static class SideWallConverter
{
  private static Byte? GetThickness(DXDrawCharts.SideWall openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.Thickness>()?.Val);
  }
  
  private static bool CmpThickness(DXDrawCharts.SideWall openXmlElement, Byte? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.Thickness>()?.Val, value, diffs, objName, "Thickness");
  }
  
  private static void SetThickness(DXDrawCharts.SideWall openXmlElement, Byte? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.Thickness,System.Byte>(openXmlElement, value);
  }
  
  private static DMDrawsCharts.ShapeProperties? GetShapeProperties(DXDrawCharts.SideWall openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ShapeProperties>();
    if (element != null)
      return DMXDrawsCharts.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXDrawCharts.SideWall openXmlElement, DMDrawsCharts.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeProperties(DXDrawCharts.SideWall openXmlElement, DMDrawsCharts.ShapeProperties? value)
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
  
  private static DMDrawsCharts.PictureOptions? GetPictureOptions(DXDrawCharts.SideWall openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.PictureOptions>();
    if (element != null)
      return DMXDrawsCharts.PictureOptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPictureOptions(DXDrawCharts.SideWall openXmlElement, DMDrawsCharts.PictureOptions? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.PictureOptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.PictureOptions>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPictureOptions(DXDrawCharts.SideWall openXmlElement, DMDrawsCharts.PictureOptions? value)
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
  
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.SideWall openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (element != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawCharts.SideWall openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawCharts.SideWall openXmlElement, DMDrawsCharts.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Charts.SideWall? CreateModelElement(DXDrawCharts.SideWall? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SideWall();
      value.Thickness = GetThickness(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.PictureOptions = GetPictureOptions(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.SideWall? openXmlElement, DMDrawsCharts.SideWall? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.SideWall value)
    where OpenXmlElementType: DXDrawCharts.SideWall, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.SideWall openXmlElement, DMDrawsCharts.SideWall value)
  {
    SetThickness(openXmlElement, value?.Thickness);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetPictureOptions(openXmlElement, value?.PictureOptions);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
