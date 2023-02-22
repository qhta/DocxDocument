namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Shape Default.
/// </summary>
public static class ShapeDefaultConverter
{
  private static DMDraws.ShapeProperties? GetShapeProperties(DXDraw.ShapeDefault openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ShapeProperties>();
    if (element != null)
      return DMXDraws.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXDraw.ShapeDefault openXmlElement, DMDraws.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.BodyProperties>();
    if (element != null)
      return DMXDraws.BodyPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBodyProperties(DXDraw.ShapeDefault openXmlElement, DMDraws.BodyProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BodyPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.BodyProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.ListStyle>();
    if (element != null)
      return DMXDraws.ListStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpListStyle(DXDraw.ShapeDefault openXmlElement, DMDraws.ListStyle? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ListStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ListStyle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.ShapeStyle>();
    if (element != null)
      return DMXDraws.ShapeStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeStyle(DXDraw.ShapeDefault openXmlElement, DMDraws.ShapeStyle? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ShapeStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ShapeStyle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (element != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDraw.ShapeDefault openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Drawings.ShapeDefault? CreateModelElement(DXDraw.ShapeDefault? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ShapeDefault();
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.BodyProperties = GetBodyProperties(openXmlElement);
      value.ListStyle = GetListStyle(openXmlElement);
      value.ShapeStyle = GetShapeStyle(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.ShapeDefault? openXmlElement, DMDraws.ShapeDefault? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ShapeDefault value)
    where OpenXmlElementType: DXDraw.ShapeDefault, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.ShapeDefault openXmlElement, DMDraws.ShapeDefault value)
  {
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetBodyProperties(openXmlElement, value?.BodyProperties);
    SetListStyle(openXmlElement, value?.ListStyle);
    SetShapeStyle(openXmlElement, value?.ShapeStyle);
    SetExtensionList(openXmlElement, value?.ExtensionList);
    }
  }
