namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Chart Class.
/// </summary>
public static class ChartConverter
{
  /// <summary>
  /// Title data and formatting.
  /// </summary>
  private static DMDrawsCharts.Title? GetTitle(DXDrawCharts.Chart openXmlElement)
  {
    return DMXDrawsCharts.TitleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Title>());
  }
  
  private static bool CmpTitle(DXDrawCharts.Chart openXmlElement, DMDrawsCharts.Title? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.TitleConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Title>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTitle(DXDrawCharts.Chart openXmlElement, DMDrawsCharts.Title? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Title>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.TitleConverter.CreateOpenXmlElement<DXDrawCharts.Title>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// True if the chart automatic title has been deleted..
  /// </summary>
  private static Boolean? GetAutoTitleDeleted(DXDrawCharts.Chart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.AutoTitleDeleted>() != null;
  }
  
  private static bool CmpAutoTitleDeleted(DXDrawCharts.Chart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.AutoTitleDeleted>() != null == value;
  }
  
  private static void SetAutoTitleDeleted(DXDrawCharts.Chart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.AutoTitleDeleted>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.AutoTitleDeleted();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// pivot chart format persistence data.
  /// </summary>
  private static DMDrawsCharts.PivotFormats? GetPivotFormats(DXDrawCharts.Chart openXmlElement)
  {
    return DMXDrawsCharts.PivotFormatsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.PivotFormats>());
  }
  
  private static bool CmpPivotFormats(DXDrawCharts.Chart openXmlElement, DMDrawsCharts.PivotFormats? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.PivotFormatsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.PivotFormats>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPivotFormats(DXDrawCharts.Chart openXmlElement, DMDrawsCharts.PivotFormats? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PivotFormats>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.PivotFormatsConverter.CreateOpenXmlElement<DXDrawCharts.PivotFormats>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// 3D view settings.
  /// </summary>
  private static DMDrawsCharts.View3D? GetView3D(DXDrawCharts.Chart openXmlElement)
  {
    return DMXDrawsCharts.View3DConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.View3D>());
  }
  
  private static bool CmpView3D(DXDrawCharts.Chart openXmlElement, DMDrawsCharts.View3D? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.View3DConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.View3D>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetView3D(DXDrawCharts.Chart openXmlElement, DMDrawsCharts.View3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.View3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.View3DConverter.CreateOpenXmlElement<DXDrawCharts.View3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// 3D floor formatting.
  /// </summary>
  private static DMDrawsCharts.Floor? GetFloor(DXDrawCharts.Chart openXmlElement)
  {
    return DMXDrawsCharts.FloorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Floor>());
  }
  
  private static bool CmpFloor(DXDrawCharts.Chart openXmlElement, DMDrawsCharts.Floor? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FloorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Floor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFloor(DXDrawCharts.Chart openXmlElement, DMDrawsCharts.Floor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Floor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.FloorConverter.CreateOpenXmlElement<DXDrawCharts.Floor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// 3D side wall formatting.
  /// </summary>
  private static DMDrawsCharts.SideWall? GetSideWall(DXDrawCharts.Chart openXmlElement)
  {
    return DMXDrawsCharts.SideWallConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.SideWall>());
  }
  
  private static bool CmpSideWall(DXDrawCharts.Chart openXmlElement, DMDrawsCharts.SideWall? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.SideWallConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.SideWall>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSideWall(DXDrawCharts.Chart openXmlElement, DMDrawsCharts.SideWall? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.SideWall>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.SideWallConverter.CreateOpenXmlElement<DXDrawCharts.SideWall>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// 3D back wall formatting.
  /// </summary>
  private static DMDrawsCharts.BackWall? GetBackWall(DXDrawCharts.Chart openXmlElement)
  {
    return DMXDrawsCharts.BackWallConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.BackWall>());
  }
  
  private static bool CmpBackWall(DXDrawCharts.Chart openXmlElement, DMDrawsCharts.BackWall? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.BackWallConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.BackWall>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBackWall(DXDrawCharts.Chart openXmlElement, DMDrawsCharts.BackWall? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BackWall>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.BackWallConverter.CreateOpenXmlElement<DXDrawCharts.BackWall>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Plot data and formatting.
  /// </summary>
  private static DMDrawsCharts.PlotArea? GetPlotArea(DXDrawCharts.Chart openXmlElement)
  {
    return DMXDrawsCharts.PlotAreaConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.PlotArea>());
  }
  
  private static bool CmpPlotArea(DXDrawCharts.Chart openXmlElement, DMDrawsCharts.PlotArea? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.PlotAreaConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.PlotArea>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPlotArea(DXDrawCharts.Chart openXmlElement, DMDrawsCharts.PlotArea? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PlotArea>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.PlotAreaConverter.CreateOpenXmlElement<DXDrawCharts.PlotArea>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Legend data and formatting.
  /// </summary>
  private static DMDrawsCharts.Legend? GetLegend(DXDrawCharts.Chart openXmlElement)
  {
    return DMXDrawsCharts.LegendConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Legend>());
  }
  
  private static bool CmpLegend(DXDrawCharts.Chart openXmlElement, DMDrawsCharts.Legend? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.LegendConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Legend>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLegend(DXDrawCharts.Chart openXmlElement, DMDrawsCharts.Legend? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Legend>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.LegendConverter.CreateOpenXmlElement<DXDrawCharts.Legend>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// True if only visible cells are plotted..
  /// </summary>
  private static Boolean? GetPlotVisibleOnly(DXDrawCharts.Chart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.PlotVisibleOnly>() != null;
  }
  
  private static bool CmpPlotVisibleOnly(DXDrawCharts.Chart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.PlotVisibleOnly>() != null == value;
  }
  
  private static void SetPlotVisibleOnly(DXDrawCharts.Chart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PlotVisibleOnly>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.PlotVisibleOnly();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// The way that blank cells are plotted on a chart..
  /// </summary>
  private static DMDrawsCharts.DisplayBlanksAsKind? GetDisplayBlanksAs(DXDrawCharts.Chart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues, DMDrawsCharts.DisplayBlanksAsKind>(openXmlElement.GetFirstChild<DXDrawCharts.DisplayBlanksAs>()?.Val?.Value);
  }
  
  private static bool CmpDisplayBlanksAs(DXDrawCharts.Chart openXmlElement, DMDrawsCharts.DisplayBlanksAsKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues, DMDrawsCharts.DisplayBlanksAsKind>(openXmlElement.GetFirstChild<DXDrawCharts.DisplayBlanksAs>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDisplayBlanksAs(DXDrawCharts.Chart openXmlElement, DMDrawsCharts.DisplayBlanksAsKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DisplayBlanksAs>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.DisplayBlanksAs, DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues, DMDrawsCharts.DisplayBlanksAsKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// True if we should render datalabels over the maximum scale.
  /// </summary>
  private static Boolean? GetShowDataLabelsOverMaximum(DXDrawCharts.Chart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ShowDataLabelsOverMaximum>() != null;
  }
  
  private static bool CmpShowDataLabelsOverMaximum(DXDrawCharts.Chart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ShowDataLabelsOverMaximum>() != null == value;
  }
  
  private static void SetShowDataLabelsOverMaximum(DXDrawCharts.Chart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowDataLabelsOverMaximum>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.ShowDataLabelsOverMaximum();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Extensibility container.
  /// </summary>
  private static DMDrawsCharts.ChartExtensionList? GetChartExtensionList(DXDrawCharts.Chart openXmlElement)
  {
    return DMXDrawsCharts.ChartExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ChartExtensionList>());
  }
  
  private static bool CmpChartExtensionList(DXDrawCharts.Chart openXmlElement, DMDrawsCharts.ChartExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ChartExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChartExtensionList(DXDrawCharts.Chart openXmlElement, DMDrawsCharts.ChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ChartExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.ChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.Chart? CreateModelElement(DXDrawCharts.Chart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Chart();
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
  
  public static bool CompareModelElement(DXDrawCharts.Chart? openXmlElement, DMDrawsCharts.Chart? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Chart? value)
    where OpenXmlElementType: DXDrawCharts.Chart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
