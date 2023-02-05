namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualGroupDrawingShapePropsExtension Class.
/// </summary>
public static class NonVisualGroupDrawingShapePropsExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDraw.NonVisualGroupDrawingShapePropsExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXDraw.NonVisualGroupDrawingShapePropsExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Uri?.Value == value) return true;
    diffs?.Add(objName, "Uri", openXmlElement?.Uri?.Value, value);
    return false;
  }
  
  private static void SetUri(DXDraw.NonVisualGroupDrawingShapePropsExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDraws.NonVisualGroupProperties? GetNonVisualGroupProperties(DXDraw.NonVisualGroupDrawingShapePropsExtension openXmlElement)
  {
    return DMXDraws.NonVisualGroupPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013Draw.NonVisualGroupProperties>());
  }
  
  private static bool CmpNonVisualGroupProperties(DXDraw.NonVisualGroupDrawingShapePropsExtension openXmlElement, DMDraws.NonVisualGroupProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.NonVisualGroupPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013Draw.NonVisualGroupProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNonVisualGroupProperties(DXDraw.NonVisualGroupDrawingShapePropsExtension openXmlElement, DMDraws.NonVisualGroupProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013Draw.NonVisualGroupProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.NonVisualGroupPropertiesConverter.CreateOpenXmlElement<DXO2013Draw.NonVisualGroupProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.NonVisualGroupDrawingShapePropsExtension? CreateModelElement(DXDraw.NonVisualGroupDrawingShapePropsExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.NonVisualGroupDrawingShapePropsExtension();
      value.Uri = GetUri(openXmlElement);
      value.NonVisualGroupProperties = GetNonVisualGroupProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.NonVisualGroupDrawingShapePropsExtension? openXmlElement, DMDraws.NonVisualGroupDrawingShapePropsExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpNonVisualGroupProperties(openXmlElement, value.NonVisualGroupProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.NonVisualGroupDrawingShapePropsExtension? value)
    where OpenXmlElementType: DXDraw.NonVisualGroupDrawingShapePropsExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetNonVisualGroupProperties(openXmlElement, value?.NonVisualGroupProperties);
      return openXmlElement;
    }
    return default;
  }
}
