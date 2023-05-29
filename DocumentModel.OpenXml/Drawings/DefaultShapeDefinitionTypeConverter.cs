namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the DefaultShapeDefinitionType Class.
/// </summary>
public static class DefaultShapeDefinitionTypeConverter
{
  /// <summary>
  /// Visual Properties.
  /// </summary>
  private static DMD.ShapeProperties? GetShapeProperties(DXD.DefaultShapeDefinitionType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ShapeProperties>();
    if (element != null)
      return DMXD.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXD.DefaultShapeDefinitionType openXmlElement, DMD.ShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeProperties(DXD.DefaultShapeDefinitionType openXmlElement, DMD.ShapeProperties? value)
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
  
  /// <summary>
  /// BodyProperties.
  /// </summary>
  private static DMD.BodyProperties? GetBodyProperties(DXD.DefaultShapeDefinitionType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.BodyProperties>();
    if (element != null)
      return DMXD.BodyPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBodyProperties(DXD.DefaultShapeDefinitionType openXmlElement, DMD.BodyProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.BodyPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.BodyProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetBodyProperties(DXD.DefaultShapeDefinitionType openXmlElement, DMD.BodyProperties? value)
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
  
  /// <summary>
  /// ListStyle.
  /// </summary>
  private static DMD.ListStyle? GetListStyle(DXD.DefaultShapeDefinitionType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ListStyle>();
    if (element != null)
      return DMXD.ListStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpListStyle(DXD.DefaultShapeDefinitionType openXmlElement, DMD.ListStyle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ListStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ListStyle>(), value, diffs, objName, propName);
  }
  
  private static void SetListStyle(DXD.DefaultShapeDefinitionType openXmlElement, DMD.ListStyle? value)
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
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  private static DMD.ShapeStyle? GetShapeStyle(DXD.DefaultShapeDefinitionType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ShapeStyle>();
    if (element != null)
      return DMXD.ShapeStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeStyle(DXD.DefaultShapeDefinitionType openXmlElement, DMD.ShapeStyle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ShapeStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ShapeStyle>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeStyle(DXD.DefaultShapeDefinitionType openXmlElement, DMD.ShapeStyle? value)
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
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMD.ExtensionList? GetExtensionList(DXD.DefaultShapeDefinitionType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXD.DefaultShapeDefinitionType openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXD.DefaultShapeDefinitionType openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.DefaultShapeDefinitionType? CreateModelElement(DXD.DefaultShapeDefinitionType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.DefaultShapeDefinitionType();
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.BodyProperties = GetBodyProperties(openXmlElement);
      value.ListStyle = GetListStyle(openXmlElement);
      value.ShapeStyle = GetShapeStyle(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.DefaultShapeDefinitionType? openXmlElement, DMD.DefaultShapeDefinitionType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpBodyProperties(openXmlElement, value.BodyProperties, diffs, objName, propName))
        ok = false;
      if (!CmpListStyle(openXmlElement, value.ListStyle, diffs, objName, propName))
        ok = false;
      if (!CmpShapeStyle(openXmlElement, value.ShapeStyle, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.DefaultShapeDefinitionType value)
    where OpenXmlElementType: DXD.DefaultShapeDefinitionType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.DefaultShapeDefinitionType openXmlElement, DMD.DefaultShapeDefinitionType value)
  {
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetBodyProperties(openXmlElement, value?.BodyProperties);
    SetListStyle(openXmlElement, value?.ListStyle);
    SetShapeStyle(openXmlElement, value?.ShapeStyle);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
