namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Chart Class.
/// </summary>
public static class ChartConverter
{
  /// <summary>
  /// ChartTitle.
  /// </summary>
  private static DMDCDs.ChartTitle? GetChartTitle(DXO16DCD.Chart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ChartTitle>();
    if (element != null)
      return DMXDCDs.ChartTitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartTitle(DXO16DCD.Chart openXmlElement, DMDCDs.ChartTitle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.ChartTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ChartTitle>(), value, diffs, objName, propName);
  }
  
  private static void SetChartTitle(DXO16DCD.Chart openXmlElement, DMDCDs.ChartTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ChartTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ChartTitleConverter.CreateOpenXmlElement<DXO16DCD.ChartTitle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  private static DMDCDs.PlotArea? GetPlotArea(DXO16DCD.Chart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.PlotArea>();
    if (element != null)
      return DMXDCDs.PlotAreaConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPlotArea(DXO16DCD.Chart openXmlElement, DMDCDs.PlotArea? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.PlotAreaConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.PlotArea>(), value, diffs, objName, propName);
  }
  
  private static void SetPlotArea(DXO16DCD.Chart openXmlElement, DMDCDs.PlotArea? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.PlotArea>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.PlotAreaConverter.CreateOpenXmlElement<DXO16DCD.PlotArea>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Legend.
  /// </summary>
  private static DMDCDs.Legend? GetLegend(DXO16DCD.Chart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.Legend>();
    if (element != null)
      return DMXDCDs.LegendConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLegend(DXO16DCD.Chart openXmlElement, DMDCDs.Legend? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.LegendConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.Legend>(), value, diffs, objName, propName);
  }
  
  private static void SetLegend(DXO16DCD.Chart openXmlElement, DMDCDs.Legend? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.Legend>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.LegendConverter.CreateOpenXmlElement<DXO16DCD.Legend>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDCDs.ExtensionList? GetExtensionList(DXO16DCD.Chart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.ExtensionList>();
    if (element != null)
      return DMXDCDs.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO16DCD.Chart openXmlElement, DMDCDs.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXO16DCD.Chart openXmlElement, DMDCDs.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ExtensionListConverter.CreateOpenXmlElement<DXO16DCD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDCDs.Chart? CreateModelElement(DXO16DCD.Chart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.Chart();
      value.ChartTitle = GetChartTitle(openXmlElement);
      value.PlotArea = GetPlotArea(openXmlElement);
      value.Legend = GetLegend(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.Chart? openXmlElement, DMDCDs.Chart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpChartTitle(openXmlElement, value.ChartTitle, diffs, objName, propName))
        ok = false;
      if (!CmpPlotArea(openXmlElement, value.PlotArea, diffs, objName, propName))
        ok = false;
      if (!CmpLegend(openXmlElement, value.Legend, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.Chart value)
    where OpenXmlElementType: DXO16DCD.Chart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.Chart openXmlElement, DMDCDs.Chart value)
  {
    SetChartTitle(openXmlElement, value?.ChartTitle);
    SetPlotArea(openXmlElement, value?.PlotArea);
    SetLegend(openXmlElement, value?.Legend);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
