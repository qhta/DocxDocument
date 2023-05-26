namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the UpDownBars Class.
/// </summary>
public static class UpDownBarsConverter
{
  /// <summary>
  /// Gap Width.
  /// </summary>
  private static UInt16? GetGapWidth(DXDC.UpDownBars openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.GapWidth>()?.Val);
  }
  
  private static bool CmpGapWidth(DXDC.UpDownBars openXmlElement, UInt16? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.GapWidth>()?.Val, value, diffs, objName, "GapWidth");
  }
  
  private static void SetGapWidth(DXDC.UpDownBars openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXDC.GapWidth,System.UInt16>(openXmlElement, value);
  }
  
  /// <summary>
  /// Up Bars.
  /// </summary>
  private static DMDC.UpBars? GetUpBars(DXDC.UpDownBars openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.UpBars>();
    if (element != null)
      return DMXDC.UpBarsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUpBars(DXDC.UpDownBars openXmlElement, DMDC.UpBars? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.UpBarsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.UpBars>(), value, diffs, objName, propName);
  }
  
  private static void SetUpBars(DXDC.UpDownBars openXmlElement, DMDC.UpBars? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.UpBars>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.UpBarsConverter.CreateOpenXmlElement<DXDC.UpBars>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Down Bars.
  /// </summary>
  private static DMDC.DownBars? GetDownBars(DXDC.UpDownBars openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DownBars>();
    if (element != null)
      return DMXDC.DownBarsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDownBars(DXDC.UpDownBars openXmlElement, DMDC.DownBars? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DownBarsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DownBars>(), value, diffs, objName, propName);
  }
  
  private static void SetDownBars(DXDC.UpDownBars openXmlElement, DMDC.DownBars? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.DownBars>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.DownBarsConverter.CreateOpenXmlElement<DXDC.DownBars>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDC.ExtensionList? GetExtensionList(DXDC.UpDownBars openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.UpDownBars openXmlElement, DMDC.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDC.UpDownBars openXmlElement, DMDC.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Charts.UpDownBars? CreateModelElement(DXDC.UpDownBars? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.UpDownBars();
      value.GapWidth = GetGapWidth(openXmlElement);
      value.UpBars = GetUpBars(openXmlElement);
      value.DownBars = GetDownBars(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.UpDownBars? openXmlElement, DMDC.UpDownBars? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGapWidth(openXmlElement, value.GapWidth, diffs, objName, propName))
        ok = false;
      if (!CmpUpBars(openXmlElement, value.UpBars, diffs, objName, propName))
        ok = false;
      if (!CmpDownBars(openXmlElement, value.DownBars, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.UpDownBars value)
    where OpenXmlElementType: DXDC.UpDownBars, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.UpDownBars openXmlElement, DMDC.UpDownBars value)
  {
    SetGapWidth(openXmlElement, value?.GapWidth);
    SetUpBars(openXmlElement, value?.UpBars);
    SetDownBars(openXmlElement, value?.DownBars);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
