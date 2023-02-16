namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the UpDownBars Class.
/// </summary>
public static class UpDownBarsConverter
{
  /// <summary>
  /// Gap Width.
  /// </summary>
  private static UInt16? GetGapWidth(DXDrawCharts.UpDownBars openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.GapWidth>()?.Val?.Value;
  }
  
  private static bool CmpGapWidth(DXDrawCharts.UpDownBars openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.GapWidth>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.GapWidth", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetGapWidth(DXDrawCharts.UpDownBars openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.GapWidth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.GapWidth{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Up Bars.
  /// </summary>
  private static DMDrawsCharts.UpBars? GetUpBars(DXDrawCharts.UpDownBars openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.UpBars>();
    if (element != null)
      return DMXDrawsCharts.UpBarsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUpBars(DXDrawCharts.UpDownBars openXmlElement, DMDrawsCharts.UpBars? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.UpBarsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.UpBars>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUpBars(DXDrawCharts.UpDownBars openXmlElement, DMDrawsCharts.UpBars? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.UpBars>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.UpBarsConverter.CreateOpenXmlElement<DXDrawCharts.UpBars>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Down Bars.
  /// </summary>
  private static DMDrawsCharts.DownBars? GetDownBars(DXDrawCharts.UpDownBars openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.DownBars>();
    if (element != null)
      return DMXDrawsCharts.DownBarsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDownBars(DXDrawCharts.UpDownBars openXmlElement, DMDrawsCharts.DownBars? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DownBarsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DownBars>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDownBars(DXDrawCharts.UpDownBars openXmlElement, DMDrawsCharts.DownBars? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DownBars>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.DownBarsConverter.CreateOpenXmlElement<DXDrawCharts.DownBars>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.UpDownBars openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (element != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawCharts.UpDownBars openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawCharts.UpDownBars openXmlElement, DMDrawsCharts.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Charts.UpDownBars? CreateModelElement(DXDrawCharts.UpDownBars? openXmlElement)
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
  
  public static bool CompareModelElement(DXDrawCharts.UpDownBars? openXmlElement, DMDrawsCharts.UpDownBars? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGapWidth(openXmlElement, value.GapWidth, diffs, objName))
        ok = false;
      if (!CmpUpBars(openXmlElement, value.UpBars, diffs, objName))
        ok = false;
      if (!CmpDownBars(openXmlElement, value.DownBars, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.UpDownBars? value)
    where OpenXmlElementType: DXDrawCharts.UpDownBars, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGapWidth(openXmlElement, value?.GapWidth);
      SetUpBars(openXmlElement, value?.UpBars);
      SetDownBars(openXmlElement, value?.DownBars);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
