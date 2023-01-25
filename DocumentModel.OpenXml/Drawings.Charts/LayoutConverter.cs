namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Layout.
/// </summary>
public static class LayoutConverter
{
  /// <summary>
  /// Manual Layout.
  /// </summary>
  private static DMDrawsCharts.ManualLayout? GetManualLayout(DXDrawCharts.Layout openXmlElement)
  {
    return DMXDrawsCharts.ManualLayoutConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ManualLayout>());
  }
  
  private static bool CmpManualLayout(DXDrawCharts.Layout openXmlElement, DMDrawsCharts.ManualLayout? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ManualLayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ManualLayout>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetManualLayout(DXDrawCharts.Layout openXmlElement, DMDrawsCharts.ManualLayout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ManualLayout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ManualLayoutConverter.CreateOpenXmlElement<DXDrawCharts.ManualLayout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.Layout openXmlElement)
  {
    return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDrawCharts.Layout openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawCharts.Layout openXmlElement, DMDrawsCharts.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.Layout? CreateModelElement(DXDrawCharts.Layout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Layout();
      value.ManualLayout = GetManualLayout(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.Layout? openXmlElement, DMDrawsCharts.Layout? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Layout? value)
    where OpenXmlElementType: DXDrawCharts.Layout, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetManualLayout(openXmlElement, value?.ManualLayout);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
