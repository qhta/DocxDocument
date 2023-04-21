namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Layout.
/// </summary>
public static class LayoutConverter
{
  /// <summary>
  /// Manual Layout.
  /// </summary>
  private static DMDC.ManualLayout? GetManualLayout(DXDC.Layout openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ManualLayout>();
    if (element != null)
      return DMXDC.ManualLayoutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpManualLayout(DXDC.Layout openXmlElement, DMDC.ManualLayout? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ManualLayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ManualLayout>(), value, diffs, objName);
  }
  
  private static void SetManualLayout(DXDC.Layout openXmlElement, DMDC.ManualLayout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ManualLayout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ManualLayoutConverter.CreateOpenXmlElement<DXDC.ManualLayout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDC.ExtensionList? GetExtensionList(DXDC.Layout openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.Layout openXmlElement, DMDC.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDC.Layout openXmlElement, DMDC.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Charts.Layout? CreateModelElement(DXDC.Layout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Layout();
      value.ManualLayout = GetManualLayout(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.Layout? openXmlElement, DMDC.Layout? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpManualLayout(openXmlElement, value.ManualLayout, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Layout value)
    where OpenXmlElementType: DXDC.Layout, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Layout openXmlElement, DMDC.Layout value)
  {
    SetManualLayout(openXmlElement, value?.ManualLayout);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
