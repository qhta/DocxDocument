namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ChartSpaceExtension Class.
/// </summary>
public static class ChartSpaceExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.ChartSpaceExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.ChartSpaceExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.ChartSpaceExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDC.PivotOptions? GetPivotOptions(DXDC.ChartSpaceExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10DC.PivotOptions>();
    if (element != null)
      return DMXDC.PivotOptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPivotOptions(DXDC.ChartSpaceExtension openXmlElement, DMDC.PivotOptions? value, DiffList? diffs, string? objName)
  {
    return DMXDC.PivotOptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10DC.PivotOptions>(), value, diffs, objName);
  }
  
  private static void SetPivotOptions(DXDC.ChartSpaceExtension openXmlElement, DMDC.PivotOptions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10DC.PivotOptions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.PivotOptionsConverter.CreateOpenXmlElement<DXO10DC.PivotOptions>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.SketchOptions? GetSketchOptions(DXDC.ChartSpaceExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10DC.SketchOptions>();
    if (element != null)
      return DMXDC.SketchOptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSketchOptions(DXDC.ChartSpaceExtension openXmlElement, DMDC.SketchOptions? value, DiffList? diffs, string? objName)
  {
    return DMXDC.SketchOptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10DC.SketchOptions>(), value, diffs, objName);
  }
  
  private static void SetSketchOptions(DXDC.ChartSpaceExtension openXmlElement, DMDC.SketchOptions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10DC.SketchOptions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.SketchOptionsConverter.CreateOpenXmlElement<DXO10DC.SketchOptions>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.PivotSource3? GetPivotSource(DXDC.ChartSpaceExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.PivotSource>();
    if (element != null)
      return DMXDC.PivotSource3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPivotSource(DXDC.ChartSpaceExtension openXmlElement, DMDC.PivotSource3? value, DiffList? diffs, string? objName)
  {
    return DMXDC.PivotSource3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.PivotSource>(), value, diffs, objName);
  }
  
  private static void SetPivotSource(DXDC.ChartSpaceExtension openXmlElement, DMDC.PivotSource3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.PivotSource>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.PivotSource3Converter.CreateOpenXmlElement<DXO13DC.PivotSource>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.ChartSpaceExtension? CreateModelElement(DXDC.ChartSpaceExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartSpaceExtension();
      value.Uri = GetUri(openXmlElement);
      value.PivotOptions = GetPivotOptions(openXmlElement);
      value.SketchOptions = GetSketchOptions(openXmlElement);
      value.PivotSource = GetPivotSource(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.ChartSpaceExtension? openXmlElement, DMDC.ChartSpaceExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpPivotOptions(openXmlElement, value.PivotOptions, diffs, objName))
        ok = false;
      if (!CmpSketchOptions(openXmlElement, value.SketchOptions, diffs, objName))
        ok = false;
      if (!CmpPivotSource(openXmlElement, value.PivotSource, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.ChartSpaceExtension value)
    where OpenXmlElementType: DXDC.ChartSpaceExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.ChartSpaceExtension openXmlElement, DMDC.ChartSpaceExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetPivotOptions(openXmlElement, value?.PivotOptions);
    SetSketchOptions(openXmlElement, value?.SketchOptions);
    SetPivotSource(openXmlElement, value?.PivotSource);
  }
}
