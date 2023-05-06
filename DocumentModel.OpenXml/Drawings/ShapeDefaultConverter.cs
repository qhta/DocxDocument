namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Shape Default.
/// </summary>
public static class ShapeDefaultConverter
{
  private static DMD.ShapeProperties? GetShapeProperties(DXD.ShapeDefault openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ShapeProperties>();
    if (element != null)
      return DMXD.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXD.ShapeDefault openXmlElement, DMD.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetShapeProperties(DXD.ShapeDefault openXmlElement, DMD.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ShapePropertiesConverter.CreateOpenXmlElement<DXD.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.BodyProperties? GetBodyProperties(DXD.ShapeDefault openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.BodyProperties>();
    if (element != null)
      return DMXD.BodyPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBodyProperties(DXD.ShapeDefault openXmlElement, DMD.BodyProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.BodyPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.BodyProperties>(), value, diffs, objName);
  }
  
  private static void SetBodyProperties(DXD.ShapeDefault openXmlElement, DMD.BodyProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BodyProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BodyPropertiesConverter.CreateOpenXmlElement<DXD.BodyProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.ListStyle? GetListStyle(DXD.ShapeDefault openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ListStyle>();
    if (element != null)
      return DMXD.ListStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpListStyle(DXD.ShapeDefault openXmlElement, DMD.ListStyle? value, DiffList? diffs, string? objName)
  {
    return DMXD.ListStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ListStyle>(), value, diffs, objName);
  }
  
  private static void SetListStyle(DXD.ShapeDefault openXmlElement, DMD.ListStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ListStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ListStyleConverter.CreateOpenXmlElement<DXD.ListStyle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.ShapeStyle? GetShapeStyle(DXD.ShapeDefault openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ShapeStyle>();
    if (element != null)
      return DMXD.ShapeStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeStyle(DXD.ShapeDefault openXmlElement, DMD.ShapeStyle? value, DiffList? diffs, string? objName)
  {
    return DMXD.ShapeStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ShapeStyle>(), value, diffs, objName);
  }
  
  private static void SetShapeStyle(DXD.ShapeDefault openXmlElement, DMD.ShapeStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ShapeStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ShapeStyleConverter.CreateOpenXmlElement<DXD.ShapeStyle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.ExtensionList? GetExtensionList(DXD.ShapeDefault openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXD.ShapeDefault openXmlElement, DMD.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXD.ShapeDefault openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ShapeDefault? CreateModelElement(DXD.ShapeDefault? openXmlElement)
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
  
  public static bool CompareModelElement(DXD.ShapeDefault? openXmlElement, DMD.ShapeDefault? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ShapeDefault value)
    where OpenXmlElementType: DXD.ShapeDefault, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.ShapeDefault openXmlElement, DMD.ShapeDefault value)
  {
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetBodyProperties(openXmlElement, value?.BodyProperties);
    SetListStyle(openXmlElement, value?.ListStyle);
    SetShapeStyle(openXmlElement, value?.ShapeStyle);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
