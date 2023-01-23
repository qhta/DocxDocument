namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the DefaultShapeDefinitionType Class.
/// </summary>
public static class DefaultShapeDefinitionTypeConverter
{
  /// <summary>
  /// Visual Properties.
  /// </summary>
  private static DMDraws.ShapeProperties? GetShapeProperties(DXDraw.DefaultShapeDefinitionType openXmlElement)
  {
    return DMXDraws.ShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ShapeProperties>());
  }
  
  private static bool CmpShapeProperties(DXDraw.DefaultShapeDefinitionType openXmlElement, DMDraws.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ShapePropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeProperties(DXDraw.DefaultShapeDefinitionType openXmlElement, DMDraws.ShapeProperties? value)
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
  
  /// <summary>
  /// BodyProperties.
  /// </summary>
  private static DMDraws.BodyProperties? GetBodyProperties(DXDraw.DefaultShapeDefinitionType openXmlElement)
  {
    return DMXDraws.BodyPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.BodyProperties>());
  }
  
  private static bool CmpBodyProperties(DXDraw.DefaultShapeDefinitionType openXmlElement, DMDraws.BodyProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BodyPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.BodyProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBodyProperties(DXDraw.DefaultShapeDefinitionType openXmlElement, DMDraws.BodyProperties? value)
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
  
  /// <summary>
  /// ListStyle.
  /// </summary>
  private static DMDraws.ListStyle? GetListStyle(DXDraw.DefaultShapeDefinitionType openXmlElement)
  {
    return DMXDraws.ListStyleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ListStyle>());
  }
  
  private static bool CmpListStyle(DXDraw.DefaultShapeDefinitionType openXmlElement, DMDraws.ListStyle? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ListStyleConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ListStyle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetListStyle(DXDraw.DefaultShapeDefinitionType openXmlElement, DMDraws.ListStyle? value)
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
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  private static DMDraws.ShapeStyle? GetShapeStyle(DXDraw.DefaultShapeDefinitionType openXmlElement)
  {
    return DMXDraws.ShapeStyleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ShapeStyle>());
  }
  
  private static bool CmpShapeStyle(DXDraw.DefaultShapeDefinitionType openXmlElement, DMDraws.ShapeStyle? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ShapeStyleConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ShapeStyle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeStyle(DXDraw.DefaultShapeDefinitionType openXmlElement, DMDraws.ShapeStyle? value)
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
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.DefaultShapeDefinitionType openXmlElement)
  {
    return DMXDraws.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDraw.DefaultShapeDefinitionType openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDraw.DefaultShapeDefinitionType openXmlElement, DMDraws.ExtensionList? value)
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
  
  public static DMDraws.DefaultShapeDefinitionType? CreateModelElement(DXDraw.DefaultShapeDefinitionType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.DefaultShapeDefinitionType();
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.BodyProperties = GetBodyProperties(openXmlElement);
      value.ListStyle = GetListStyle(openXmlElement);
      value.ShapeStyle = GetShapeStyle(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.DefaultShapeDefinitionType? openXmlElement, DMDraws.DefaultShapeDefinitionType? value, DiffList? diffs, string? objName)
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.DefaultShapeDefinitionType? value)
    where OpenXmlElementType: DXDraw.DefaultShapeDefinitionType, new()
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
