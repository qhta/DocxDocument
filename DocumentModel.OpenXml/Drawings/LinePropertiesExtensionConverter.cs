namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LinePropertiesExtension Class.
/// </summary>
public static class LinePropertiesExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXD.LinePropertiesExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXD.LinePropertiesExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXD.LinePropertiesExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMD.LineSketchStyleProperties? GetLineSketchStyleProperties(DXD.LinePropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DSS.LineSketchStyleProperties>();
    if (element != null)
      return DMXD.LineSketchStylePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineSketchStyleProperties(DXD.LinePropertiesExtension openXmlElement, DMD.LineSketchStyleProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.LineSketchStylePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DSS.LineSketchStyleProperties>(), value, diffs, objName);
  }
  
  private static void SetLineSketchStyleProperties(DXD.LinePropertiesExtension openXmlElement, DMD.LineSketchStyleProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DSS.LineSketchStyleProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LineSketchStylePropertiesConverter.CreateOpenXmlElement<DXO21DSS.LineSketchStyleProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.LinePropertiesExtension? CreateModelElement(DXD.LinePropertiesExtension? openXmlElement)
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
  
  public static bool CompareModelElement(DXD.LinePropertiesExtension? openXmlElement, DMD.LinePropertiesExtension? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.LinePropertiesExtension value)
    where OpenXmlElementType: DXD.LinePropertiesExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.LinePropertiesExtension openXmlElement, DMD.LinePropertiesExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetLineSketchStyleProperties(openXmlElement, value?.LineSketchStyleProperties);
  }
}
