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
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXDraw.LinePropertiesExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Uri?.Value == value;
  }
  
  private static void SetUri(DXDraw.LinePropertiesExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDraws.LineSketchStyleProperties? GetLineSketchStyleProperties(DXDraw.LinePropertiesExtension openXmlElement)
  {
    return DMXDraws.LineSketchStylePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2021DrawSketchyShps.LineSketchStyleProperties>());
  }
  
  private static bool CmpLineSketchStyleProperties(DXDraw.LinePropertiesExtension openXmlElement, DMDraws.LineSketchStyleProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LineSketchStylePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchStyleProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DMDraws.LinePropertiesExtension? CreateModelElement(DXDraw.LinePropertiesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.LinePropertiesExtension();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LinePropertiesExtension? value)
    where OpenXmlElementType: DXDraw.LinePropertiesExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetLineSketchStyleProperties(openXmlElement, value?.LineSketchStyleProperties);
      return openXmlElement;
    }
    return default;
  }
}
