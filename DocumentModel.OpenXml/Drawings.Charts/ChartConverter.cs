namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Chart Class.
/// </summary>
public static class ChartConverter
{
  /// <summary>
  /// Title data and formatting.
  /// </summary>
  private static DMDC.Title? GetTitle(DXDC.Chart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Title>();
    if (element != null)
      return DMXDC.TitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTitle(DXDC.Chart openXmlElement, DMDC.Title? value, DiffList? diffs, string? objName)
  {
    return DMXDC.TitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Title>(), value, diffs, objName);
  }
  
  private static void SetTitle(DXDC.Chart openXmlElement, DMDC.Title? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Title>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.TitleConverter.CreateOpenXmlElement<DXDC.Title>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// True if the chart automatic title has been deleted..
  /// </summary>
  private static Boolean? GetAutoTitleDeleted(DXDC.Chart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.AutoTitleDeleted>() != null;
  }
  
  private static bool CmpAutoTitleDeleted(DXDC.Chart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.AutoTitleDeleted>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.AutoTitleDeleted", val, value);
    return false;
  }
  
  private static void SetAutoTitleDeleted(DXDC.Chart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.AutoTitleDeleted>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.AutoTitleDeleted();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// pivot chart format persistence data.
  /// </summary>
  private static DMDC.PivotFormats? GetPivotFormats(DXDC.Chart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.PivotFormats>();
    if (element != null)
      return DMXDC.PivotFormatsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPivotFormats(DXDC.Chart openXmlElement, DMDC.PivotFormats? value, DiffList? diffs, string? objName)
  {
    return DMXDC.PivotFormatsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.PivotFormats>(), value, diffs, objName);
  }
  
  private static void SetPivotFormats(DXDC.Chart openXmlElement, DMDC.PivotFormats? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.PivotFormats>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.PivotFormatsConverter.CreateOpenXmlElement<DXDC.PivotFormats>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// 3D view settings.
  /// </summary>
  private static DMDC.View3D? GetView3D(DXDC.Chart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.View3D>();
    if (element != null)
      return DMXDC.View3DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpView3D(DXDC.Chart openXmlElement, DMDC.View3D? value, DiffList? diffs, string? objName)
  {
    return DMXDC.View3DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.View3D>(), value, diffs, objName);
  }
  
  private static void SetView3D(DXDC.Chart openXmlElement, DMDC.View3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.View3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.View3DConverter.CreateOpenXmlElement<DXDC.View3D>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// 3D floor formatting.
  /// </summary>
  private static DMDC.Floor? GetFloor(DXDC.Chart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Floor>();
    if (element != null)
      return DMXDC.FloorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFloor(DXDC.Chart openXmlElement, DMDC.Floor? value, DiffList? diffs, string? objName)
  {
    return DMXDC.FloorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Floor>(), value, diffs, objName);
  }
  
  private static void SetFloor(DXDC.Chart openXmlElement, DMDC.Floor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Floor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.FloorConverter.CreateOpenXmlElement<DXDC.Floor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// 3D side wall formatting.
  /// </summary>
  private static DMDC.SideWall? GetSideWall(DXDC.Chart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.SideWall>();
    if (element != null)
      return DMXDC.SideWallConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSideWall(DXDC.Chart openXmlElement, DMDC.SideWall? value, DiffList? diffs, string? objName)
  {
    return DMXDC.SideWallConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.SideWall>(), value, diffs, objName);
  }
  
  private static void SetSideWall(DXDC.Chart openXmlElement, DMDC.SideWall? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.SideWall>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.SideWallConverter.CreateOpenXmlElement<DXDC.SideWall>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// 3D back wall formatting.
  /// </summary>
  private static DMDC.BackWall? GetBackWall(DXDC.Chart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.BackWall>();
    if (element != null)
      return DMXDC.BackWallConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackWall(DXDC.Chart openXmlElement, DMDC.BackWall? value, DiffList? diffs, string? objName)
  {
    return DMXDC.BackWallConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.BackWall>(), value, diffs, objName);
  }
  
  private static void SetBackWall(DXDC.Chart openXmlElement, DMDC.BackWall? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.BackWall>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.BackWallConverter.CreateOpenXmlElement<DXDC.BackWall>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Plot data and formatting.
  /// </summary>
  private static DMDC.PlotArea? GetPlotArea(DXDC.Chart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.PlotArea>();
    if (element != null)
      return DMXDC.PlotAreaConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPlotArea(DXDC.Chart openXmlElement, DMDC.PlotArea? value, DiffList? diffs, string? objName)
  {
    return DMXDC.PlotAreaConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.PlotArea>(), value, diffs, objName);
  }
  
  private static void SetPlotArea(DXDC.Chart openXmlElement, DMDC.PlotArea? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.PlotArea>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.PlotAreaConverter.CreateOpenXmlElement<DXDC.PlotArea>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Legend data and formatting.
  /// </summary>
  private static DMDC.Legend? GetLegend(DXDC.Chart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Legend>();
    if (element != null)
      return DMXDC.LegendConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLegend(DXDC.Chart openXmlElement, DMDC.Legend? value, DiffList? diffs, string? objName)
  {
    return DMXDC.LegendConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Legend>(), value, diffs, objName);
  }
  
  private static void SetLegend(DXDC.Chart openXmlElement, DMDC.Legend? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Legend>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.LegendConverter.CreateOpenXmlElement<DXDC.Legend>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// True if only visible cells are plotted..
  /// </summary>
  private static Boolean? GetPlotVisibleOnly(DXDC.Chart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.PlotVisibleOnly>() != null;
  }
  
  private static bool CmpPlotVisibleOnly(DXDC.Chart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.PlotVisibleOnly>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.PlotVisibleOnly", val, value);
    return false;
  }
  
  private static void SetPlotVisibleOnly(DXDC.Chart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.PlotVisibleOnly>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.PlotVisibleOnly();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// The way that blank cells are plotted on a chart..
  /// </summary>
  private static DMDC.DisplayBlanksAsKind? GetDisplayBlanksAs(DXDC.Chart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues, DMDC.DisplayBlanksAsKind>(openXmlElement.GetFirstChild<DXDC.DisplayBlanksAs>()?.Val?.Value);
  }
  
  private static bool CmpDisplayBlanksAs(DXDC.Chart openXmlElement, DMDC.DisplayBlanksAsKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues, DMDC.DisplayBlanksAsKind>(openXmlElement.GetFirstChild<DXDC.DisplayBlanksAs>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetDisplayBlanksAs(DXDC.Chart openXmlElement, DMDC.DisplayBlanksAsKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.DisplayBlanksAs>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues, DMDC.DisplayBlanksAsKind>(itemElement, (DMDC.DisplayBlanksAsKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.DisplayBlanksAs, DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues, DMDC.DisplayBlanksAsKind>((DMDC.DisplayBlanksAsKind)value));
  }
  
  /// <summary>
  /// True if we should render datalabels over the maximum scale.
  /// </summary>
  private static Boolean? GetShowDataLabelsOverMaximum(DXDC.Chart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ShowDataLabelsOverMaximum>() != null;
  }
  
  private static bool CmpShowDataLabelsOverMaximum(DXDC.Chart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ShowDataLabelsOverMaximum>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ShowDataLabelsOverMaximum", val, value);
    return false;
  }
  
  private static void SetShowDataLabelsOverMaximum(DXDC.Chart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ShowDataLabelsOverMaximum>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ShowDataLabelsOverMaximum();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Extensibility container.
  /// </summary>
  private static DMDC.ChartExtensionList? GetChartExtensionList(DXDC.Chart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartExtensionList>();
    if (element != null)
      return DMXDC.ChartExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartExtensionList(DXDC.Chart openXmlElement, DMDC.ChartExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartExtensionList>(), value, diffs, objName);
  }
  
  private static void SetChartExtensionList(DXDC.Chart openXmlElement, DMDC.ChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ChartExtensionListConverter.CreateOpenXmlElement<DXDC.ChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.Chart? CreateModelElement(DXDC.Chart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Chart();
      value.Title = GetTitle(openXmlElement);
      value.AutoTitleDeleted = GetAutoTitleDeleted(openXmlElement);
      value.PivotFormats = GetPivotFormats(openXmlElement);
      value.View3D = GetView3D(openXmlElement);
      value.Floor = GetFloor(openXmlElement);
      value.SideWall = GetSideWall(openXmlElement);
      value.BackWall = GetBackWall(openXmlElement);
      value.PlotArea = GetPlotArea(openXmlElement);
      value.Legend = GetLegend(openXmlElement);
      value.PlotVisibleOnly = GetPlotVisibleOnly(openXmlElement);
      value.DisplayBlanksAs = GetDisplayBlanksAs(openXmlElement);
      value.ShowDataLabelsOverMaximum = GetShowDataLabelsOverMaximum(openXmlElement);
      value.ChartExtensionList = GetChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.Chart? openXmlElement, DMDC.Chart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTitle(openXmlElement, value.Title, diffs, objName))
        ok = false;
      if (!CmpAutoTitleDeleted(openXmlElement, value.AutoTitleDeleted, diffs, objName))
        ok = false;
      if (!CmpPivotFormats(openXmlElement, value.PivotFormats, diffs, objName))
        ok = false;
      if (!CmpView3D(openXmlElement, value.View3D, diffs, objName))
        ok = false;
      if (!CmpFloor(openXmlElement, value.Floor, diffs, objName))
        ok = false;
      if (!CmpSideWall(openXmlElement, value.SideWall, diffs, objName))
        ok = false;
      if (!CmpBackWall(openXmlElement, value.BackWall, diffs, objName))
        ok = false;
      if (!CmpPlotArea(openXmlElement, value.PlotArea, diffs, objName))
        ok = false;
      if (!CmpLegend(openXmlElement, value.Legend, diffs, objName))
        ok = false;
      if (!CmpPlotVisibleOnly(openXmlElement, value.PlotVisibleOnly, diffs, objName))
        ok = false;
      if (!CmpDisplayBlanksAs(openXmlElement, value.DisplayBlanksAs, diffs, objName))
        ok = false;
      if (!CmpShowDataLabelsOverMaximum(openXmlElement, value.ShowDataLabelsOverMaximum, diffs, objName))
        ok = false;
      if (!CmpChartExtensionList(openXmlElement, value.ChartExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Chart value)
    where OpenXmlElementType: DXDC.Chart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Chart openXmlElement, DMDC.Chart value)
  {
    SetTitle(openXmlElement, value?.Title);
    SetAutoTitleDeleted(openXmlElement, value?.AutoTitleDeleted);
    SetPivotFormats(openXmlElement, value?.PivotFormats);
    SetView3D(openXmlElement, value?.View3D);
    SetFloor(openXmlElement, value?.Floor);
    SetSideWall(openXmlElement, value?.SideWall);
    SetBackWall(openXmlElement, value?.BackWall);
    SetPlotArea(openXmlElement, value?.PlotArea);
    SetLegend(openXmlElement, value?.Legend);
    SetPlotVisibleOnly(openXmlElement, value?.PlotVisibleOnly);
    SetDisplayBlanksAs(openXmlElement, value?.DisplayBlanksAs);
    SetShowDataLabelsOverMaximum(openXmlElement, value?.ShowDataLabelsOverMaximum);
    SetChartExtensionList(openXmlElement, value?.ChartExtensionList);
  }
}
