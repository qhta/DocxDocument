namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Line Default.
/// </summary>
public static class LineDefaultConverter
{
  private static DMDraws.ShapeProperties? GetShapeProperties(DXDraw.LineDefault openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ShapeProperties>();
    if (itemElement != null)
      return DMXDraws.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DXDraw.LineDefault openXmlElement, DMDraws.ShapeProperties? value)
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
  
  private static DMDraws.BodyProperties? GetBodyProperties(DXDraw.LineDefault openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BodyProperties>();
    if (itemElement != null)
      return DMXDraws.BodyPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBodyProperties(DXDraw.LineDefault openXmlElement, DMDraws.BodyProperties? value)
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
  
  private static DMDraws.ListStyle? GetListStyle(DXDraw.LineDefault openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ListStyle>();
    if (itemElement != null)
      return DMXDraws.ListStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetListStyle(DXDraw.LineDefault openXmlElement, DMDraws.ListStyle? value)
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
  
  private static DMDraws.ShapeStyle? GetShapeStyle(DXDraw.LineDefault openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ShapeStyle>();
    if (itemElement != null)
      return DMXDraws.ShapeStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeStyle(DXDraw.LineDefault openXmlElement, DMDraws.ShapeStyle? value)
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
  
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.LineDefault openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDraw.LineDefault openXmlElement, DMDraws.ExtensionList? value)
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
  
  public static DMDraws.LineDefault? CreateModelElement(DXDraw.LineDefault? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.LineDefault();
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.BodyProperties = GetBodyProperties(openXmlElement);
      value.ListStyle = GetListStyle(openXmlElement);
      value.ShapeStyle = GetShapeStyle(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LineDefault? value)
    where OpenXmlElementType: DXDraw.LineDefault, new()
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
