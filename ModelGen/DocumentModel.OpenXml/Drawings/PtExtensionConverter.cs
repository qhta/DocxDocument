namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the PtExtension Class.
/// </summary>
public static class PtExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDraw.PtExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDraw.PtExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDraw.PtExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDrawsDgms.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXDraw.PtExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010DrawDgm.NonVisualDrawingProperties>();
    if (element != null)
      return DMXDrawsDgms.NonVisualDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualDrawingProperties(DXDraw.PtExtension openXmlElement, DMDrawsDgms.NonVisualDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.NonVisualDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010DrawDgm.NonVisualDrawingProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNonVisualDrawingProperties(DXDraw.PtExtension openXmlElement, DMDrawsDgms.NonVisualDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010DrawDgm.NonVisualDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DXO2010DrawDgm.NonVisualDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.PtExtension? CreateModelElement(DXDraw.PtExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PtExtension();
      value.Uri = GetUri(openXmlElement);
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.PtExtension? openXmlElement, DMDraws.PtExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpNonVisualDrawingProperties(openXmlElement, value.NonVisualDrawingProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.PtExtension value)
    where OpenXmlElementType: DXDraw.PtExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.PtExtension openXmlElement, DMDraws.PtExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
  }
}
