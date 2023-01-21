namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the ChartStyle Class.
/// </summary>
public static class ChartStyleConverter
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetId(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static void SetId(DXO2013DrawChartStyle.ChartStyle openXmlElement, UInt32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// AxisTitle.
  /// </summary>
  private static DMDrawsChartsStyle.AxisTitle? GetAxisTitle(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.AxisTitle>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.AxisTitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAxisTitle(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.AxisTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.AxisTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.AxisTitleConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.AxisTitle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// CategoryAxis.
  /// </summary>
  private static DMDrawsChartsStyle.CategoryAxis? GetCategoryAxis(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.CategoryAxis>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.CategoryAxisConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCategoryAxis(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.CategoryAxis? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.CategoryAxis>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.CategoryAxisConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.CategoryAxis>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartArea.
  /// </summary>
  private static DMDrawsChartsStyle.ChartArea? GetChartArea(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.ChartArea>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.ChartAreaConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartArea(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.ChartArea? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.ChartArea>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.ChartAreaConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.ChartArea>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  private static DMDrawsChartsStyle.DataLabel? GetDataLabel(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.DataLabel>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.DataLabelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabel(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.DataLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.DataLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.DataLabelConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.DataLabel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataLabelCallout.
  /// </summary>
  private static DMDrawsChartsStyle.DataLabelCallout? GetDataLabelCallout(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.DataLabelCallout>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.DataLabelCalloutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabelCallout(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.DataLabelCallout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.DataLabelCallout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.DataLabelCalloutConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.DataLabelCallout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataPoint.
  /// </summary>
  private static DMDrawsChartsStyle.DataPoint? GetDataPoint(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.DataPoint>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.DataPointConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataPoint(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.DataPoint? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.DataPoint>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.DataPointConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.DataPoint>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataPoint3D.
  /// </summary>
  private static DMDrawsChartsStyle.DataPoint3D? GetDataPoint3D(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.DataPoint3D>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.DataPoint3DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataPoint3D(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.DataPoint3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.DataPoint3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.DataPoint3DConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.DataPoint3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataPointLine.
  /// </summary>
  private static DMDrawsChartsStyle.DataPointLine? GetDataPointLine(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.DataPointLine>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.DataPointLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataPointLine(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.DataPointLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.DataPointLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.DataPointLineConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.DataPointLine>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataPointMarker.
  /// </summary>
  private static DMDrawsChartsStyle.DataPointMarker? GetDataPointMarker(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.DataPointMarker>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.DataPointMarkerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataPointMarker(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.DataPointMarker? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.DataPointMarker>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.DataPointMarkerConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.DataPointMarker>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// MarkerLayoutProperties.
  /// </summary>
  private static DMDrawsChartsStyle.MarkerLayoutProperties? GetMarkerLayoutProperties(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.MarkerLayoutProperties>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.MarkerLayoutPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMarkerLayoutProperties(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.MarkerLayoutProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.MarkerLayoutProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.MarkerLayoutPropertiesConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.MarkerLayoutProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataPointWireframe.
  /// </summary>
  private static DMDrawsChartsStyle.DataPointWireframe? GetDataPointWireframe(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.DataPointWireframe>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.DataPointWireframeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataPointWireframe(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.DataPointWireframe? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.DataPointWireframe>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.DataPointWireframeConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.DataPointWireframe>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataTableStyle.
  /// </summary>
  private static DMDrawsChartsStyle.DataTableStyle? GetDataTableStyle(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.DataTableStyle>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.DataTableStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataTableStyle(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.DataTableStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.DataTableStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.DataTableStyleConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.DataTableStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DownBar.
  /// </summary>
  private static DMDrawsChartsStyle.DownBar? GetDownBar(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.DownBar>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.DownBarConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDownBar(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.DownBar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.DownBar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.DownBarConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.DownBar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DropLine.
  /// </summary>
  private static DMDrawsChartsStyle.DropLine? GetDropLine(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.DropLine>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.DropLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDropLine(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.DropLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.DropLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.DropLineConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.DropLine>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ErrorBar.
  /// </summary>
  private static DMDrawsChartsStyle.ErrorBar? GetErrorBar(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.ErrorBar>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.ErrorBarConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetErrorBar(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.ErrorBar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.ErrorBar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.ErrorBarConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.ErrorBar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Floor.
  /// </summary>
  private static DMDrawsChartsStyle.Floor? GetFloor(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.Floor>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.FloorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFloor(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.Floor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.Floor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.FloorConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.Floor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GridlineMajor.
  /// </summary>
  private static DMDrawsChartsStyle.GridlineMajor? GetGridlineMajor(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.GridlineMajor>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.GridlineMajorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGridlineMajor(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.GridlineMajor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.GridlineMajor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.GridlineMajorConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.GridlineMajor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GridlineMinor.
  /// </summary>
  private static DMDrawsChartsStyle.GridlineMinor? GetGridlineMinor(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.GridlineMinor>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.GridlineMinorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGridlineMinor(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.GridlineMinor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.GridlineMinor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.GridlineMinorConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.GridlineMinor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// HiLoLine.
  /// </summary>
  private static DMDrawsChartsStyle.HiLoLine? GetHiLoLine(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.HiLoLine>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.HiLoLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHiLoLine(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.HiLoLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.HiLoLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.HiLoLineConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.HiLoLine>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// LeaderLine.
  /// </summary>
  private static DMDrawsChartsStyle.LeaderLine? GetLeaderLine(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.LeaderLine>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.LeaderLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLeaderLine(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.LeaderLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.LeaderLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.LeaderLineConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.LeaderLine>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// LegendStyle.
  /// </summary>
  private static DMDrawsChartsStyle.LegendStyle? GetLegendStyle(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.LegendStyle>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.LegendStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLegendStyle(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.LegendStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.LegendStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.LegendStyleConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.LegendStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  private static DMDrawsChartsStyle.PlotArea? GetPlotArea(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.PlotArea>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.PlotAreaConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPlotArea(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.PlotArea? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.PlotArea>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.PlotAreaConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.PlotArea>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PlotArea3D.
  /// </summary>
  private static DMDrawsChartsStyle.PlotArea3D? GetPlotArea3D(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.PlotArea3D>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.PlotArea3DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPlotArea3D(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.PlotArea3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.PlotArea3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.PlotArea3DConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.PlotArea3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SeriesAxis.
  /// </summary>
  private static DMDrawsChartsStyle.SeriesAxis? GetSeriesAxis(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.SeriesAxis>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.SeriesAxisConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSeriesAxis(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.SeriesAxis? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.SeriesAxis>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.SeriesAxisConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.SeriesAxis>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SeriesLine.
  /// </summary>
  private static DMDrawsChartsStyle.SeriesLine? GetSeriesLine(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.SeriesLine>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.SeriesLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSeriesLine(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.SeriesLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.SeriesLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.SeriesLineConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.SeriesLine>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TitleStyle.
  /// </summary>
  private static DMDrawsChartsStyle.TitleStyle? GetTitleStyle(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.TitleStyle>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.TitleStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTitleStyle(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.TitleStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.TitleStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.TitleStyleConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.TitleStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TrendlineStyle.
  /// </summary>
  private static DMDrawsChartsStyle.TrendlineStyle? GetTrendlineStyle(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.TrendlineStyle>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.TrendlineStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTrendlineStyle(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.TrendlineStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.TrendlineStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.TrendlineStyleConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.TrendlineStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TrendlineLabel.
  /// </summary>
  private static DMDrawsChartsStyle.TrendlineLabel? GetTrendlineLabel(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.TrendlineLabel>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.TrendlineLabelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTrendlineLabel(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.TrendlineLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.TrendlineLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.TrendlineLabelConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.TrendlineLabel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// UpBar.
  /// </summary>
  private static DMDrawsChartsStyle.UpBar? GetUpBar(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.UpBar>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.UpBarConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetUpBar(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.UpBar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.UpBar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.UpBarConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.UpBar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ValueAxis.
  /// </summary>
  private static DMDrawsChartsStyle.ValueAxis? GetValueAxis(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.ValueAxis>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.ValueAxisConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetValueAxis(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.ValueAxis? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.ValueAxis>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.ValueAxisConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.ValueAxis>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Wall.
  /// </summary>
  private static DMDrawsChartsStyle.Wall? GetWall(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.Wall>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.WallConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetWall(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.Wall? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.Wall>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.WallConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.Wall>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMDrawsChartsStyle.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO2013DrawChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.OfficeArtExtensionList>();
    if (itemElement != null)
      return DMXDrawsChartsStyle.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeArtExtensionList(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartsStyle.ChartStyle? CreateModelElement(DXO2013DrawChartStyle.ChartStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartsStyle.ChartStyle();
      value.Id = GetId(openXmlElement);
      value.AxisTitle = GetAxisTitle(openXmlElement);
      value.CategoryAxis = GetCategoryAxis(openXmlElement);
      value.ChartArea = GetChartArea(openXmlElement);
      value.DataLabel = GetDataLabel(openXmlElement);
      value.DataLabelCallout = GetDataLabelCallout(openXmlElement);
      value.DataPoint = GetDataPoint(openXmlElement);
      value.DataPoint3D = GetDataPoint3D(openXmlElement);
      value.DataPointLine = GetDataPointLine(openXmlElement);
      value.DataPointMarker = GetDataPointMarker(openXmlElement);
      value.MarkerLayoutProperties = GetMarkerLayoutProperties(openXmlElement);
      value.DataPointWireframe = GetDataPointWireframe(openXmlElement);
      value.DataTableStyle = GetDataTableStyle(openXmlElement);
      value.DownBar = GetDownBar(openXmlElement);
      value.DropLine = GetDropLine(openXmlElement);
      value.ErrorBar = GetErrorBar(openXmlElement);
      value.Floor = GetFloor(openXmlElement);
      value.GridlineMajor = GetGridlineMajor(openXmlElement);
      value.GridlineMinor = GetGridlineMinor(openXmlElement);
      value.HiLoLine = GetHiLoLine(openXmlElement);
      value.LeaderLine = GetLeaderLine(openXmlElement);
      value.LegendStyle = GetLegendStyle(openXmlElement);
      value.PlotArea = GetPlotArea(openXmlElement);
      value.PlotArea3D = GetPlotArea3D(openXmlElement);
      value.SeriesAxis = GetSeriesAxis(openXmlElement);
      value.SeriesLine = GetSeriesLine(openXmlElement);
      value.TitleStyle = GetTitleStyle(openXmlElement);
      value.TrendlineStyle = GetTrendlineStyle(openXmlElement);
      value.TrendlineLabel = GetTrendlineLabel(openXmlElement);
      value.UpBar = GetUpBar(openXmlElement);
      value.ValueAxis = GetValueAxis(openXmlElement);
      value.Wall = GetWall(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartsStyle.ChartStyle? value)
    where OpenXmlElementType: DXO2013DrawChartStyle.ChartStyle, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetAxisTitle(openXmlElement, value?.AxisTitle);
      SetCategoryAxis(openXmlElement, value?.CategoryAxis);
      SetChartArea(openXmlElement, value?.ChartArea);
      SetDataLabel(openXmlElement, value?.DataLabel);
      SetDataLabelCallout(openXmlElement, value?.DataLabelCallout);
      SetDataPoint(openXmlElement, value?.DataPoint);
      SetDataPoint3D(openXmlElement, value?.DataPoint3D);
      SetDataPointLine(openXmlElement, value?.DataPointLine);
      SetDataPointMarker(openXmlElement, value?.DataPointMarker);
      SetMarkerLayoutProperties(openXmlElement, value?.MarkerLayoutProperties);
      SetDataPointWireframe(openXmlElement, value?.DataPointWireframe);
      SetDataTableStyle(openXmlElement, value?.DataTableStyle);
      SetDownBar(openXmlElement, value?.DownBar);
      SetDropLine(openXmlElement, value?.DropLine);
      SetErrorBar(openXmlElement, value?.ErrorBar);
      SetFloor(openXmlElement, value?.Floor);
      SetGridlineMajor(openXmlElement, value?.GridlineMajor);
      SetGridlineMinor(openXmlElement, value?.GridlineMinor);
      SetHiLoLine(openXmlElement, value?.HiLoLine);
      SetLeaderLine(openXmlElement, value?.LeaderLine);
      SetLegendStyle(openXmlElement, value?.LegendStyle);
      SetPlotArea(openXmlElement, value?.PlotArea);
      SetPlotArea3D(openXmlElement, value?.PlotArea3D);
      SetSeriesAxis(openXmlElement, value?.SeriesAxis);
      SetSeriesLine(openXmlElement, value?.SeriesLine);
      SetTitleStyle(openXmlElement, value?.TitleStyle);
      SetTrendlineStyle(openXmlElement, value?.TrendlineStyle);
      SetTrendlineLabel(openXmlElement, value?.TrendlineLabel);
      SetUpBar(openXmlElement, value?.UpBar);
      SetValueAxis(openXmlElement, value?.ValueAxis);
      SetWall(openXmlElement, value?.Wall);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
