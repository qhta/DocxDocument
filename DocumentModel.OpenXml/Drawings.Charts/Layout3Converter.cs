namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Layout Class.
/// </summary>
public static class Layout3Converter
{
  /// <summary>
  /// Manual Layout.
  /// </summary>
  private static DMDC.ManualLayout? GetManualLayout(DXO13DC.Layout openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ManualLayout>();
    if (element != null)
      return DMXDC.ManualLayoutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpManualLayout(DXO13DC.Layout openXmlElement, DMDC.ManualLayout? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ManualLayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ManualLayout>(), value, diffs, objName, propName);
  }
  
  private static void SetManualLayout(DXO13DC.Layout openXmlElement, DMDC.ManualLayout? value)
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
  private static DMDC.ExtensionList? GetExtensionList(DXO13DC.Layout openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO13DC.Layout openXmlElement, DMDC.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXO13DC.Layout openXmlElement, DMDC.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Charts.Layout3? CreateModelElement(DXO13DC.Layout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Layout3();
      value.ManualLayout = GetManualLayout(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13DC.Layout? openXmlElement, DMDC.Layout3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Layout3 value)
    where OpenXmlElementType: DXO13DC.Layout, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.Layout openXmlElement, DMDC.Layout3 value)
  {
    SetManualLayout(openXmlElement, value?.ManualLayout);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
