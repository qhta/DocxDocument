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
  
  private static bool CmpManualLayout(DXDC.Layout openXmlElement, DMDC.ManualLayout? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ManualLayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ManualLayout>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
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
  
  private static bool CmpExtensionList(DXDC.Layout openXmlElement, DMDC.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.Layout? CreateModelElement(DXDC.Layout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.Layout();
      value.ManualLayout = GetManualLayout(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.Layout? openXmlElement, DMDC.Layout? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpManualLayout(openXmlElement, value.ManualLayout, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
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
