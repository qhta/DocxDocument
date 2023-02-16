namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Layout Class.
/// </summary>
public static class Layout3Converter
{
  /// <summary>
  /// Manual Layout.
  /// </summary>
  private static DMDrawsCharts.ManualLayout? GetManualLayout(DXO2013DrawChart.Layout openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ManualLayout>();
    if (element != null)
      return DMXDrawsCharts.ManualLayoutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpManualLayout(DXO2013DrawChart.Layout openXmlElement, DMDrawsCharts.ManualLayout? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ManualLayoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ManualLayout>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetManualLayout(DXO2013DrawChart.Layout openXmlElement, DMDrawsCharts.ManualLayout? value)
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
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXO2013DrawChart.Layout openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (element != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO2013DrawChart.Layout openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXO2013DrawChart.Layout openXmlElement, DMDrawsCharts.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Charts.Layout3? CreateModelElement(DXO2013DrawChart.Layout? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2013DrawChart.Layout? openXmlElement, DMDrawsCharts.Layout3? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Layout3? value)
    where OpenXmlElementType: DXO2013DrawChart.Layout, new()
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
