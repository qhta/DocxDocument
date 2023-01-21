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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Title>();
    if (itemElement != null)
      return DMXDrawsCharts.TitleConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.AutoTitleDeleted>();
    return itemElement != null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.PivotFormats>();
    if (itemElement != null)
      return DMXDrawsCharts.PivotFormatsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.View3D>();
    if (itemElement != null)
      return DMXDrawsCharts.View3DConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Floor>();
    if (itemElement != null)
      return DMXDrawsCharts.FloorConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.SideWall>();
    if (itemElement != null)
      return DMXDrawsCharts.SideWallConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.BackWall>();
    if (itemElement != null)
      return DMXDrawsCharts.BackWallConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.PlotArea>();
    if (itemElement != null)
      return DMXDrawsCharts.PlotAreaConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Legend>();
    if (itemElement != null)
      return DMXDrawsCharts.LegendConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PlotVisibleOnly>();
    return itemElement != null;
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
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DisplayBlanksAs>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues, DMDrawsCharts.DisplayBlanksAsKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowDataLabelsOverMaximum>();
    return itemElement != null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ChartExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.ChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
