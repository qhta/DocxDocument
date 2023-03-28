namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LinePropertiesExtension Class.
/// </summary>
public static class LinePropertiesExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDraw.LinePropertiesExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDraw.LinePropertiesExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDraw.LinePropertiesExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDraws.LineSketchStyleProperties? GetLineSketchStyleProperties(DXDraw.LinePropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2021DrawSketchyShps.LineSketchStyleProperties>();
    if (element != null)
      return DMXDraws.LineSketchStylePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineSketchStyleProperties(DXDraw.LinePropertiesExtension openXmlElement, DMDraws.LineSketchStyleProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LineSketchStylePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchStyleProperties>(), value, diffs, objName);
  }
  
  private static void SetLineSketchStyleProperties(DXDraw.LinePropertiesExtension openXmlElement, DMDraws.LineSketchStyleProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchStyleProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LineSketchStylePropertiesConverter.CreateOpenXmlElement<DXO2021DrawSketchyShps.LineSketchStyleProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.LinePropertiesExtension? CreateModelElement(DXDraw.LinePropertiesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LinePropertiesExtension();
      value.Uri = GetUri(openXmlElement);
      value.LineSketchStyleProperties = GetLineSketchStyleProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.LinePropertiesExtension? openXmlElement, DMDraws.LinePropertiesExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpLineSketchStyleProperties(openXmlElement, value.LineSketchStyleProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LinePropertiesExtension value)
    where OpenXmlElementType: DXDraw.LinePropertiesExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.LinePropertiesExtension openXmlElement, DMDraws.LinePropertiesExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetLineSketchStyleProperties(openXmlElement, value?.LineSketchStyleProperties);
  }
}
