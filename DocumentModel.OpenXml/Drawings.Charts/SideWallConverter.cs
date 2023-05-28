namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D side wall formatting.
/// </summary>
public static class SideWallConverter
{
  private static Byte? GetThickness(DXDC.SideWall openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Thickness>()?.Val);
  }
  
  private static bool CmpThickness(DXDC.SideWall openXmlElement, Byte? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Thickness>()?.Val, value, diffs, objName, "Thickness");
  }
  
  private static void SetThickness(DXDC.SideWall openXmlElement, Byte? value)
  {
    SimpleValueConverter.SetValue<DXDC.Thickness,System.Byte>(openXmlElement, value);
  }
  
  private static DMDC.ShapeProperties? GetShapeProperties(DXDC.SideWall openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ShapeProperties>();
    if (element != null)
      return DMXDC.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXDC.SideWall openXmlElement, DMDC.ShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeProperties(DXDC.SideWall openXmlElement, DMDC.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ShapePropertiesConverter.CreateOpenXmlElement<DXDC.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.PictureOptions? GetPictureOptions(DXDC.SideWall openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.PictureOptions>();
    if (element != null)
      return DMXDC.PictureOptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPictureOptions(DXDC.SideWall openXmlElement, DMDC.PictureOptions? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.PictureOptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.PictureOptions>(), value, diffs, objName, propName);
  }
  
  private static void SetPictureOptions(DXDC.SideWall openXmlElement, DMDC.PictureOptions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.PictureOptions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.PictureOptionsConverter.CreateOpenXmlElement<DXDC.PictureOptions>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.ExtensionList? GetExtensionList(DXDC.SideWall openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.SideWall openXmlElement, DMDC.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDC.SideWall openXmlElement, DMDC.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.SideWall? CreateModelElement(DXDC.SideWall? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.SideWall();
      value.Thickness = GetThickness(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.PictureOptions = GetPictureOptions(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.SideWall? openXmlElement, DMDC.SideWall? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpThickness(openXmlElement, value.Thickness, diffs, objName, propName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpPictureOptions(openXmlElement, value.PictureOptions, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.SideWall value)
    where OpenXmlElementType: DXDC.SideWall, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.SideWall openXmlElement, DMDC.SideWall value)
  {
    SetThickness(openXmlElement, value?.Thickness);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetPictureOptions(openXmlElement, value?.PictureOptions);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
