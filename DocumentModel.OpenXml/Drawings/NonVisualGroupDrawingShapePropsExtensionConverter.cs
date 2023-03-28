namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualGroupDrawingShapePropsExtension Class converter from/to OpenXml.
///</summary>
public static class NonVisualGroupDrawingShapePropsExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDraw.NonVisualGroupDrawingShapePropsExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDraw.NonVisualGroupDrawingShapePropsExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDraw.NonVisualGroupDrawingShapePropsExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDraws.NonVisualGroupProperties? GetNonVisualGroupProperties(DXDraw.NonVisualGroupDrawingShapePropsExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013Draw.NonVisualGroupProperties>();
    if (element != null)
      return DMXDraws.NonVisualGroupPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualGroupProperties(DXDraw.NonVisualGroupDrawingShapePropsExtension openXmlElement, DMDraws.NonVisualGroupProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.NonVisualGroupPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013Draw.NonVisualGroupProperties>(), value, diffs, objName);
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
  
  public static DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtension? CreateModelElement(DXDraw.NonVisualGroupDrawingShapePropsExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtension();
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.NonVisualGroupDrawingShapePropsExtension value)
    where OpenXmlElementType: DXDraw.NonVisualGroupDrawingShapePropsExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.NonVisualGroupDrawingShapePropsExtension openXmlElement, DMDraws.NonVisualGroupDrawingShapePropsExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetNonVisualGroupProperties(openXmlElement, value?.NonVisualGroupProperties);
  }
}
