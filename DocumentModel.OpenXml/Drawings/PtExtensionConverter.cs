namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the PtExtension Class.
/// </summary>
public static class PtExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXD.PtExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXD.PtExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXD.PtExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDD.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXD.PtExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10DD.NonVisualDrawingProperties>();
    if (element != null)
      return DMXDD.NonVisualDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualDrawingProperties(DXD.PtExtension openXmlElement, DMDD.NonVisualDrawingProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.NonVisualDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10DD.NonVisualDrawingProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetNonVisualDrawingProperties(DXD.PtExtension openXmlElement, DMDD.NonVisualDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10DD.NonVisualDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DXO10DD.NonVisualDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.PtExtension? CreateModelElement(DXD.PtExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.PtExtension();
      value.Uri = GetUri(openXmlElement);
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.PtExtension? openXmlElement, DMD.PtExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
        ok = false;
      if (!CmpNonVisualDrawingProperties(openXmlElement, value.NonVisualDrawingProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.PtExtension value)
    where OpenXmlElementType: DXD.PtExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.PtExtension openXmlElement, DMD.PtExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
  }
}
