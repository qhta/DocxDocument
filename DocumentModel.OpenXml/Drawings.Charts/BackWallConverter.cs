namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D back wall formatting.
/// </summary>
public static class BackWallConverter
{
  private static Byte? GetThickness(DXDrawCharts.BackWall openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Thickness>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetThickness(DXDrawCharts.BackWall openXmlElement, Byte? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Thickness>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Thickness{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.ShapeProperties? GetShapeProperties(DXDrawCharts.BackWall openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ShapeProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DXDrawCharts.BackWall openXmlElement, DMDrawsCharts.ShapeProperties? value)
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
  
  private static DMDrawsCharts.PictureOptions? GetPictureOptions(DXDrawCharts.BackWall openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.PictureOptions>();
    if (itemElement != null)
      return DMXDrawsCharts.PictureOptionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPictureOptions(DXDrawCharts.BackWall openXmlElement, DMDrawsCharts.PictureOptions? value)
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
  
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.BackWall openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDrawCharts.BackWall openXmlElement, DMDrawsCharts.ExtensionList? value)
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
  
  public static DMDrawsCharts.BackWall? CreateModelElement(DXDrawCharts.BackWall? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.BackWall();
      value.Thickness = GetThickness(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.PictureOptions = GetPictureOptions(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BackWall? value)
    where OpenXmlElementType: DXDrawCharts.BackWall, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetThickness(openXmlElement, value?.Thickness);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetPictureOptions(openXmlElement, value?.PictureOptions);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
