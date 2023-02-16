namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Line Default.
/// </summary>
public static class LineDefaultConverter
{
  private static DMDraws.ShapeProperties? GetShapeProperties(DXDraw.LineDefault openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ShapeProperties>();
    if (element != null)
      return DMXDraws.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXDraw.LineDefault openXmlElement, DMDraws.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.BodyProperties>();
    if (element != null)
      return DMXDraws.BodyPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBodyProperties(DXDraw.LineDefault openXmlElement, DMDraws.BodyProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BodyPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.BodyProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.ListStyle>();
    if (element != null)
      return DMXDraws.ListStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpListStyle(DXDraw.LineDefault openXmlElement, DMDraws.ListStyle? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ListStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ListStyle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.ShapeStyle>();
    if (element != null)
      return DMXDraws.ShapeStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeStyle(DXDraw.LineDefault openXmlElement, DMDraws.ShapeStyle? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ShapeStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ShapeStyle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (element != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDraw.LineDefault openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Drawings.LineDefault? CreateModelElement(DXDraw.LineDefault? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LineDefault();
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.BodyProperties = GetBodyProperties(openXmlElement);
      value.ListStyle = GetListStyle(openXmlElement);
      value.ShapeStyle = GetShapeStyle(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.LineDefault? openXmlElement, DMDraws.LineDefault? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      if (!CmpBodyProperties(openXmlElement, value.BodyProperties, diffs, objName))
        ok = false;
      if (!CmpListStyle(openXmlElement, value.ListStyle, diffs, objName))
        ok = false;
      if (!CmpShapeStyle(openXmlElement, value.ShapeStyle, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
