namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualGroupDrawingShapePropsExtension Class.
/// </summary>
public static class NonVisualGroupDrawingShapePropsExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXD.NonVisualGroupDrawingShapePropsExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXD.NonVisualGroupDrawingShapePropsExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXD.NonVisualGroupDrawingShapePropsExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMD.NonVisualGroupProperties? GetNonVisualGroupProperties(DXD.NonVisualGroupDrawingShapePropsExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13D.NonVisualGroupProperties>();
    if (element != null)
      return DMXD.NonVisualGroupPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualGroupProperties(DXD.NonVisualGroupDrawingShapePropsExtension openXmlElement, DMD.NonVisualGroupProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.NonVisualGroupPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13D.NonVisualGroupProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetNonVisualGroupProperties(DXD.NonVisualGroupDrawingShapePropsExtension openXmlElement, DMD.NonVisualGroupProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13D.NonVisualGroupProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.NonVisualGroupPropertiesConverter.CreateOpenXmlElement<DXO13D.NonVisualGroupProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.NonVisualGroupDrawingShapePropsExtension? CreateModelElement(DXD.NonVisualGroupDrawingShapePropsExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.NonVisualGroupDrawingShapePropsExtension();
      value.Uri = GetUri(openXmlElement);
      value.NonVisualGroupProperties = GetNonVisualGroupProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.NonVisualGroupDrawingShapePropsExtension? openXmlElement, DMD.NonVisualGroupDrawingShapePropsExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
        ok = false;
      if (!CmpNonVisualGroupProperties(openXmlElement, value.NonVisualGroupProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.NonVisualGroupDrawingShapePropsExtension value)
    where OpenXmlElementType: DXD.NonVisualGroupDrawingShapePropsExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.NonVisualGroupDrawingShapePropsExtension openXmlElement, DMD.NonVisualGroupDrawingShapePropsExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetNonVisualGroupProperties(openXmlElement, value?.NonVisualGroupProperties);
  }
}
