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
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXDraw.PtExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Uri?.Value == value) return true;
    diffs?.Add(objName, "Uri", openXmlElement?.Uri?.Value, value);
    return false;
  }
  
  private static void SetUri(DXDraw.PtExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsDgms.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXDraw.PtExtension openXmlElement)
  {
    return DMXDrawsDgms.NonVisualDrawingPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010DrawDgm.NonVisualDrawingProperties>());
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
  
  public static DMDraws.PtExtension? CreateModelElement(DXDraw.PtExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.PtExtension();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.PtExtension? value)
    where OpenXmlElementType: DXDraw.PtExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
      return openXmlElement;
    }
    return default;
  }
}
