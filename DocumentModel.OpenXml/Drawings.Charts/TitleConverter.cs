namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Title.
/// </summary>
public static class TitleConverter
{
  /// <summary>
  /// Chart Text.
  /// </summary>
  private static DMDC.ChartText? GetChartText(DXDC.Title openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartText>();
    if (element != null)
      return DMXDC.ChartTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartText(DXDC.Title openXmlElement, DMDC.ChartText? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ChartTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartText>(), value, diffs, objName);
  }
  
  private static void SetChartText(DXDC.Title openXmlElement, DMDC.ChartText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ChartText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ChartTextConverter.CreateOpenXmlElement<DXDC.ChartText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Layout.
  /// </summary>
  private static DMDC.Layout? GetLayout(DXDC.Title openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Layout>();
    if (element != null)
      return DMXDC.LayoutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLayout(DXDC.Title openXmlElement, DMDC.Layout? value, DiffList? diffs, string? objName)
  {
    return DMXDC.LayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Layout>(), value, diffs, objName);
  }
  
  private static void SetLayout(DXDC.Title openXmlElement, DMDC.Layout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Layout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.LayoutConverter.CreateOpenXmlElement<DXDC.Layout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Overlay.
  /// </summary>
  private static Boolean? GetOverlay(DXDC.Title openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.Overlay>() != null;
  }
  
  private static bool CmpOverlay(DXDC.Title openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.Overlay>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.Overlay", val, value);
    return false;
  }
  
  private static void SetOverlay(DXDC.Title openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.Overlay>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.Overlay();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDC.ChartShapeProperties? GetChartShapeProperties(DXDC.Title openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartShapeProperties>();
    if (element != null)
      return DMXDC.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXDC.Title openXmlElement, DMDC.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetChartShapeProperties(DXDC.Title openXmlElement, DMDC.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ChartShapePropertiesConverter.CreateOpenXmlElement<DXDC.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  private static DMDC.TextProperties? GetTextProperties(DXDC.Title openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.TextProperties>();
    if (element != null)
      return DMXDC.TextPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextProperties(DXDC.Title openXmlElement, DMDC.TextProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDC.TextPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.TextProperties>(), value, diffs, objName);
  }
  
  private static void SetTextProperties(DXDC.Title openXmlElement, DMDC.TextProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.TextProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.TextPropertiesConverter.CreateOpenXmlElement<DXDC.TextProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDC.ExtensionList? GetExtensionList(DXDC.Title openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.Title openXmlElement, DMDC.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDC.Title openXmlElement, DMDC.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.Title? CreateModelElement(DXDC.Title? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Title();
      value.ChartText = GetChartText(openXmlElement);
      value.Layout = GetLayout(openXmlElement);
      value.Overlay = GetOverlay(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.Title? openXmlElement, DMDC.Title? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpChartText(openXmlElement, value.ChartText, diffs, objName))
        ok = false;
      if (!CmpLayout(openXmlElement, value.Layout, diffs, objName))
        ok = false;
      if (!CmpOverlay(openXmlElement, value.Overlay, diffs, objName))
        ok = false;
      if (!CmpChartShapeProperties(openXmlElement, value.ChartShapeProperties, diffs, objName))
        ok = false;
      if (!CmpTextProperties(openXmlElement, value.TextProperties, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Title value)
    where OpenXmlElementType: DXDC.Title, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Title openXmlElement, DMDC.Title value)
  {
    SetChartText(openXmlElement, value?.ChartText);
    SetLayout(openXmlElement, value?.Layout);
    SetOverlay(openXmlElement, value?.Overlay);
    SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
    SetTextProperties(openXmlElement, value?.TextProperties);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
