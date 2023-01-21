namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Shape Default.
/// </summary>
public static class ShapeDefaultConverter
{
  private static DMDraws.ShapeProperties? GetShapeProperties(DXDraw.ShapeDefault openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ShapeProperties>();
    if (itemElement != null)
      return DMXDraws.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DXDraw.ShapeDefault openXmlElement, DMDraws.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ShapePropertiesConverter.CreateOpenXmlElement<DXDraw.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.BodyProperties? GetBodyProperties(DXDraw.ShapeDefault openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BodyProperties>();
    if (itemElement != null)
      return DMXDraws.BodyPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBodyProperties(DXDraw.ShapeDefault openXmlElement, DMDraws.BodyProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BodyProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BodyPropertiesConverter.CreateOpenXmlElement<DXDraw.BodyProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.ListStyle? GetListStyle(DXDraw.ShapeDefault openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ListStyle>();
    if (itemElement != null)
      return DMXDraws.ListStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetListStyle(DXDraw.ShapeDefault openXmlElement, DMDraws.ListStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ListStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ListStyleConverter.CreateOpenXmlElement<DXDraw.ListStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.ShapeStyle? GetShapeStyle(DXDraw.ShapeDefault openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ShapeStyle>();
    if (itemElement != null)
      return DMXDraws.ShapeStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeStyle(DXDraw.ShapeDefault openXmlElement, DMDraws.ShapeStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ShapeStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ShapeStyleConverter.CreateOpenXmlElement<DXDraw.ShapeStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.ShapeDefault openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDraw.ShapeDefault openXmlElement, DMDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtensionListConverter.CreateOpenXmlElement<DXDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.ShapeDefault? CreateModelElement(DXDraw.ShapeDefault? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ShapeDefault();
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.BodyProperties = GetBodyProperties(openXmlElement);
      value.ListStyle = GetListStyle(openXmlElement);
      value.ShapeStyle = GetShapeStyle(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ShapeDefault? value)
    where OpenXmlElementType: DXDraw.ShapeDefault, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetBodyProperties(openXmlElement, value?.BodyProperties);
      SetListStyle(openXmlElement, value?.ListStyle);
      SetShapeStyle(openXmlElement, value?.ShapeStyle);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
