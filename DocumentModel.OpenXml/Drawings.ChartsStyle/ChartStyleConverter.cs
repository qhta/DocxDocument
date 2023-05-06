namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the ChartStyle Class.
/// </summary>
public static class ChartStyleConverter
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetId(DXO13DCS.ChartStyle openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO13DCS.ChartStyle openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "AnnotationId", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXO13DCS.ChartStyle openXmlElement, UInt32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// AxisTitle.
  /// </summary>
  private static DMDCS.AxisTitle? GetAxisTitle(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.AxisTitle>();
    if (element != null)
      return DMXDCS.AxisTitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAxisTitle(DXO13DCS.ChartStyle openXmlElement, DMDCS.AxisTitle? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.AxisTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.AxisTitle>(), value, diffs, objName);
  }
  
  private static void SetAxisTitle(DXO13DCS.ChartStyle openXmlElement, DMDCS.AxisTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.AxisTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.AxisTitleConverter.CreateOpenXmlElement<DXO13DCS.AxisTitle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// CategoryAxis.
  /// </summary>
  private static DMDCS.CategoryAxis? GetCategoryAxis(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.CategoryAxis>();
    if (element != null)
      return DMXDCS.CategoryAxisConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCategoryAxis(DXO13DCS.ChartStyle openXmlElement, DMDCS.CategoryAxis? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.CategoryAxisConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.CategoryAxis>(), value, diffs, objName);
  }
  
  private static void SetCategoryAxis(DXO13DCS.ChartStyle openXmlElement, DMDCS.CategoryAxis? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.CategoryAxis>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.CategoryAxisConverter.CreateOpenXmlElement<DXO13DCS.CategoryAxis>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartArea.
  /// </summary>
  private static DMDCS.ChartArea? GetChartArea(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.ChartArea>();
    if (element != null)
      return DMXDCS.ChartAreaConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartArea(DXO13DCS.ChartStyle openXmlElement, DMDCS.ChartArea? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.ChartAreaConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.ChartArea>(), value, diffs, objName);
  }
  
  private static void SetChartArea(DXO13DCS.ChartStyle openXmlElement, DMDCS.ChartArea? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.ChartArea>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.ChartAreaConverter.CreateOpenXmlElement<DXO13DCS.ChartArea>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  private static DMDCS.DataLabel? GetDataLabel(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.DataLabel>();
    if (element != null)
      return DMXDCS.DataLabelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabel(DXO13DCS.ChartStyle openXmlElement, DMDCS.DataLabel? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.DataLabelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.DataLabel>(), value, diffs, objName);
  }
  
  private static void SetDataLabel(DXO13DCS.ChartStyle openXmlElement, DMDCS.DataLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.DataLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.DataLabelConverter.CreateOpenXmlElement<DXO13DCS.DataLabel>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataLabelCallout.
  /// </summary>
  private static DMDCS.DataLabelCallout? GetDataLabelCallout(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.DataLabelCallout>();
    if (element != null)
      return DMXDCS.DataLabelCalloutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabelCallout(DXO13DCS.ChartStyle openXmlElement, DMDCS.DataLabelCallout? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.DataLabelCalloutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.DataLabelCallout>(), value, diffs, objName);
  }
  
  private static void SetDataLabelCallout(DXO13DCS.ChartStyle openXmlElement, DMDCS.DataLabelCallout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.DataLabelCallout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.DataLabelCalloutConverter.CreateOpenXmlElement<DXO13DCS.DataLabelCallout>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataPoint.
  /// </summary>
  private static DMDCS.DataPoint? GetDataPoint(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.DataPoint>();
    if (element != null)
      return DMXDCS.DataPointConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataPoint(DXO13DCS.ChartStyle openXmlElement, DMDCS.DataPoint? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.DataPointConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.DataPoint>(), value, diffs, objName);
  }
  
  private static void SetDataPoint(DXO13DCS.ChartStyle openXmlElement, DMDCS.DataPoint? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.DataPoint>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.DataPointConverter.CreateOpenXmlElement<DXO13DCS.DataPoint>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataPoint3D.
  /// </summary>
  private static DMDCS.DataPoint3D? GetDataPoint3D(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.DataPoint3D>();
    if (element != null)
      return DMXDCS.DataPoint3DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataPoint3D(DXO13DCS.ChartStyle openXmlElement, DMDCS.DataPoint3D? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.DataPoint3DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.DataPoint3D>(), value, diffs, objName);
  }
  
  private static void SetDataPoint3D(DXO13DCS.ChartStyle openXmlElement, DMDCS.DataPoint3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.DataPoint3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.DataPoint3DConverter.CreateOpenXmlElement<DXO13DCS.DataPoint3D>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataPointLine.
  /// </summary>
  private static DMDCS.DataPointLine? GetDataPointLine(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.DataPointLine>();
    if (element != null)
      return DMXDCS.DataPointLineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataPointLine(DXO13DCS.ChartStyle openXmlElement, DMDCS.DataPointLine? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.DataPointLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.DataPointLine>(), value, diffs, objName);
  }
  
  private static void SetDataPointLine(DXO13DCS.ChartStyle openXmlElement, DMDCS.DataPointLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.DataPointLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.DataPointLineConverter.CreateOpenXmlElement<DXO13DCS.DataPointLine>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataPointMarker.
  /// </summary>
  private static DMDCS.DataPointMarker? GetDataPointMarker(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.DataPointMarker>();
    if (element != null)
      return DMXDCS.DataPointMarkerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataPointMarker(DXO13DCS.ChartStyle openXmlElement, DMDCS.DataPointMarker? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.DataPointMarkerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.DataPointMarker>(), value, diffs, objName);
  }
  
  private static void SetDataPointMarker(DXO13DCS.ChartStyle openXmlElement, DMDCS.DataPointMarker? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.DataPointMarker>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.DataPointMarkerConverter.CreateOpenXmlElement<DXO13DCS.DataPointMarker>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// MarkerLayoutProperties.
  /// </summary>
  private static DMDCS.MarkerLayoutProperties? GetMarkerLayoutProperties(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.MarkerLayoutProperties>();
    if (element != null)
      return DMXDCS.MarkerLayoutPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMarkerLayoutProperties(DXO13DCS.ChartStyle openXmlElement, DMDCS.MarkerLayoutProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.MarkerLayoutPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.MarkerLayoutProperties>(), value, diffs, objName);
  }
  
  private static void SetMarkerLayoutProperties(DXO13DCS.ChartStyle openXmlElement, DMDCS.MarkerLayoutProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.MarkerLayoutProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.MarkerLayoutPropertiesConverter.CreateOpenXmlElement<DXO13DCS.MarkerLayoutProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataPointWireframe.
  /// </summary>
  private static DMDCS.DataPointWireframe? GetDataPointWireframe(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.DataPointWireframe>();
    if (element != null)
      return DMXDCS.DataPointWireframeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataPointWireframe(DXO13DCS.ChartStyle openXmlElement, DMDCS.DataPointWireframe? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.DataPointWireframeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.DataPointWireframe>(), value, diffs, objName);
  }
  
  private static void SetDataPointWireframe(DXO13DCS.ChartStyle openXmlElement, DMDCS.DataPointWireframe? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.DataPointWireframe>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.DataPointWireframeConverter.CreateOpenXmlElement<DXO13DCS.DataPointWireframe>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataTableStyle.
  /// </summary>
  private static DMDCS.DataTableStyle? GetDataTableStyle(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.DataTableStyle>();
    if (element != null)
      return DMXDCS.DataTableStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataTableStyle(DXO13DCS.ChartStyle openXmlElement, DMDCS.DataTableStyle? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.DataTableStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.DataTableStyle>(), value, diffs, objName);
  }
  
  private static void SetDataTableStyle(DXO13DCS.ChartStyle openXmlElement, DMDCS.DataTableStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.DataTableStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.DataTableStyleConverter.CreateOpenXmlElement<DXO13DCS.DataTableStyle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// DownBar.
  /// </summary>
  private static DMDCS.DownBar? GetDownBar(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.DownBar>();
    if (element != null)
      return DMXDCS.DownBarConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDownBar(DXO13DCS.ChartStyle openXmlElement, DMDCS.DownBar? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.DownBarConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.DownBar>(), value, diffs, objName);
  }
  
  private static void SetDownBar(DXO13DCS.ChartStyle openXmlElement, DMDCS.DownBar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.DownBar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.DownBarConverter.CreateOpenXmlElement<DXO13DCS.DownBar>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// DropLine.
  /// </summary>
  private static DMDCS.DropLine? GetDropLine(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.DropLine>();
    if (element != null)
      return DMXDCS.DropLineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDropLine(DXO13DCS.ChartStyle openXmlElement, DMDCS.DropLine? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.DropLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.DropLine>(), value, diffs, objName);
  }
  
  private static void SetDropLine(DXO13DCS.ChartStyle openXmlElement, DMDCS.DropLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.DropLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.DropLineConverter.CreateOpenXmlElement<DXO13DCS.DropLine>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ErrorBar.
  /// </summary>
  private static DMDCS.ErrorBar? GetErrorBar(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.ErrorBar>();
    if (element != null)
      return DMXDCS.ErrorBarConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpErrorBar(DXO13DCS.ChartStyle openXmlElement, DMDCS.ErrorBar? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.ErrorBarConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.ErrorBar>(), value, diffs, objName);
  }
  
  private static void SetErrorBar(DXO13DCS.ChartStyle openXmlElement, DMDCS.ErrorBar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.ErrorBar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.ErrorBarConverter.CreateOpenXmlElement<DXO13DCS.ErrorBar>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Floor.
  /// </summary>
  private static DMDCS.Floor? GetFloor(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.Floor>();
    if (element != null)
      return DMXDCS.FloorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFloor(DXO13DCS.ChartStyle openXmlElement, DMDCS.Floor? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.FloorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.Floor>(), value, diffs, objName);
  }
  
  private static void SetFloor(DXO13DCS.ChartStyle openXmlElement, DMDCS.Floor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.Floor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.FloorConverter.CreateOpenXmlElement<DXO13DCS.Floor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// GridlineMajor.
  /// </summary>
  private static DMDCS.GridlineMajor? GetGridlineMajor(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.GridlineMajor>();
    if (element != null)
      return DMXDCS.GridlineMajorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGridlineMajor(DXO13DCS.ChartStyle openXmlElement, DMDCS.GridlineMajor? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.GridlineMajorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.GridlineMajor>(), value, diffs, objName);
  }
  
  private static void SetGridlineMajor(DXO13DCS.ChartStyle openXmlElement, DMDCS.GridlineMajor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.GridlineMajor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.GridlineMajorConverter.CreateOpenXmlElement<DXO13DCS.GridlineMajor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// GridlineMinor.
  /// </summary>
  private static DMDCS.GridlineMinor? GetGridlineMinor(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.GridlineMinor>();
    if (element != null)
      return DMXDCS.GridlineMinorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGridlineMinor(DXO13DCS.ChartStyle openXmlElement, DMDCS.GridlineMinor? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.GridlineMinorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.GridlineMinor>(), value, diffs, objName);
  }
  
  private static void SetGridlineMinor(DXO13DCS.ChartStyle openXmlElement, DMDCS.GridlineMinor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.GridlineMinor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.GridlineMinorConverter.CreateOpenXmlElement<DXO13DCS.GridlineMinor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// HiLoLine.
  /// </summary>
  private static DMDCS.HiLoLine? GetHiLoLine(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.HiLoLine>();
    if (element != null)
      return DMXDCS.HiLoLineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHiLoLine(DXO13DCS.ChartStyle openXmlElement, DMDCS.HiLoLine? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.HiLoLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.HiLoLine>(), value, diffs, objName);
  }
  
  private static void SetHiLoLine(DXO13DCS.ChartStyle openXmlElement, DMDCS.HiLoLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.HiLoLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.HiLoLineConverter.CreateOpenXmlElement<DXO13DCS.HiLoLine>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// LeaderLine.
  /// </summary>
  private static DMDCS.LeaderLine? GetLeaderLine(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.LeaderLine>();
    if (element != null)
      return DMXDCS.LeaderLineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLeaderLine(DXO13DCS.ChartStyle openXmlElement, DMDCS.LeaderLine? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.LeaderLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.LeaderLine>(), value, diffs, objName);
  }
  
  private static void SetLeaderLine(DXO13DCS.ChartStyle openXmlElement, DMDCS.LeaderLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.LeaderLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.LeaderLineConverter.CreateOpenXmlElement<DXO13DCS.LeaderLine>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// LegendStyle.
  /// </summary>
  private static DMDCS.LegendStyle? GetLegendStyle(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.LegendStyle>();
    if (element != null)
      return DMXDCS.LegendStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLegendStyle(DXO13DCS.ChartStyle openXmlElement, DMDCS.LegendStyle? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.LegendStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.LegendStyle>(), value, diffs, objName);
  }
  
  private static void SetLegendStyle(DXO13DCS.ChartStyle openXmlElement, DMDCS.LegendStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.LegendStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.LegendStyleConverter.CreateOpenXmlElement<DXO13DCS.LegendStyle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  private static DMDCS.PlotArea? GetPlotArea(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.PlotArea>();
    if (element != null)
      return DMXDCS.PlotAreaConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPlotArea(DXO13DCS.ChartStyle openXmlElement, DMDCS.PlotArea? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.PlotAreaConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.PlotArea>(), value, diffs, objName);
  }
  
  private static void SetPlotArea(DXO13DCS.ChartStyle openXmlElement, DMDCS.PlotArea? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.PlotArea>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.PlotAreaConverter.CreateOpenXmlElement<DXO13DCS.PlotArea>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// PlotArea3D.
  /// </summary>
  private static DMDCS.PlotArea3D? GetPlotArea3D(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.PlotArea3D>();
    if (element != null)
      return DMXDCS.PlotArea3DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPlotArea3D(DXO13DCS.ChartStyle openXmlElement, DMDCS.PlotArea3D? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.PlotArea3DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.PlotArea3D>(), value, diffs, objName);
  }
  
  private static void SetPlotArea3D(DXO13DCS.ChartStyle openXmlElement, DMDCS.PlotArea3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.PlotArea3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.PlotArea3DConverter.CreateOpenXmlElement<DXO13DCS.PlotArea3D>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// SeriesAxis.
  /// </summary>
  private static DMDCS.SeriesAxis? GetSeriesAxis(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.SeriesAxis>();
    if (element != null)
      return DMXDCS.SeriesAxisConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSeriesAxis(DXO13DCS.ChartStyle openXmlElement, DMDCS.SeriesAxis? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.SeriesAxisConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.SeriesAxis>(), value, diffs, objName);
  }
  
  private static void SetSeriesAxis(DXO13DCS.ChartStyle openXmlElement, DMDCS.SeriesAxis? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.SeriesAxis>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.SeriesAxisConverter.CreateOpenXmlElement<DXO13DCS.SeriesAxis>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// SeriesLine.
  /// </summary>
  private static DMDCS.SeriesLine? GetSeriesLine(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.SeriesLine>();
    if (element != null)
      return DMXDCS.SeriesLineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSeriesLine(DXO13DCS.ChartStyle openXmlElement, DMDCS.SeriesLine? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.SeriesLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.SeriesLine>(), value, diffs, objName);
  }
  
  private static void SetSeriesLine(DXO13DCS.ChartStyle openXmlElement, DMDCS.SeriesLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.SeriesLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.SeriesLineConverter.CreateOpenXmlElement<DXO13DCS.SeriesLine>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// TitleStyle.
  /// </summary>
  private static DMDCS.TitleStyle? GetTitleStyle(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.TitleStyle>();
    if (element != null)
      return DMXDCS.TitleStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTitleStyle(DXO13DCS.ChartStyle openXmlElement, DMDCS.TitleStyle? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.TitleStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.TitleStyle>(), value, diffs, objName);
  }
  
  private static void SetTitleStyle(DXO13DCS.ChartStyle openXmlElement, DMDCS.TitleStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.TitleStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.TitleStyleConverter.CreateOpenXmlElement<DXO13DCS.TitleStyle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// TrendlineStyle.
  /// </summary>
  private static DMDCS.TrendlineStyle? GetTrendlineStyle(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.TrendlineStyle>();
    if (element != null)
      return DMXDCS.TrendlineStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTrendlineStyle(DXO13DCS.ChartStyle openXmlElement, DMDCS.TrendlineStyle? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.TrendlineStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.TrendlineStyle>(), value, diffs, objName);
  }
  
  private static void SetTrendlineStyle(DXO13DCS.ChartStyle openXmlElement, DMDCS.TrendlineStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.TrendlineStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.TrendlineStyleConverter.CreateOpenXmlElement<DXO13DCS.TrendlineStyle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// TrendlineLabel.
  /// </summary>
  private static DMDCS.TrendlineLabel? GetTrendlineLabel(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.TrendlineLabel>();
    if (element != null)
      return DMXDCS.TrendlineLabelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTrendlineLabel(DXO13DCS.ChartStyle openXmlElement, DMDCS.TrendlineLabel? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.TrendlineLabelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.TrendlineLabel>(), value, diffs, objName);
  }
  
  private static void SetTrendlineLabel(DXO13DCS.ChartStyle openXmlElement, DMDCS.TrendlineLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.TrendlineLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.TrendlineLabelConverter.CreateOpenXmlElement<DXO13DCS.TrendlineLabel>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// UpBar.
  /// </summary>
  private static DMDCS.UpBar? GetUpBar(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.UpBar>();
    if (element != null)
      return DMXDCS.UpBarConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUpBar(DXO13DCS.ChartStyle openXmlElement, DMDCS.UpBar? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.UpBarConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.UpBar>(), value, diffs, objName);
  }
  
  private static void SetUpBar(DXO13DCS.ChartStyle openXmlElement, DMDCS.UpBar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.UpBar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.UpBarConverter.CreateOpenXmlElement<DXO13DCS.UpBar>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ValueAxis.
  /// </summary>
  private static DMDCS.ValueAxis? GetValueAxis(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.ValueAxis>();
    if (element != null)
      return DMXDCS.ValueAxisConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpValueAxis(DXO13DCS.ChartStyle openXmlElement, DMDCS.ValueAxis? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.ValueAxisConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.ValueAxis>(), value, diffs, objName);
  }
  
  private static void SetValueAxis(DXO13DCS.ChartStyle openXmlElement, DMDCS.ValueAxis? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.ValueAxis>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.ValueAxisConverter.CreateOpenXmlElement<DXO13DCS.ValueAxis>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Wall.
  /// </summary>
  private static DMDCS.Wall? GetWall(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.Wall>();
    if (element != null)
      return DMXDCS.WallConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWall(DXO13DCS.ChartStyle openXmlElement, DMDCS.Wall? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.WallConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.Wall>(), value, diffs, objName);
  }
  
  private static void SetWall(DXO13DCS.ChartStyle openXmlElement, DMDCS.Wall? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.Wall>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.WallConverter.CreateOpenXmlElement<DXO13DCS.Wall>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMDCS.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO13DCS.ChartStyle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.OfficeArtExtensionList>();
    if (element != null)
      return DMXDCS.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO13DCS.ChartStyle openXmlElement, DMDCS.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.OfficeArtExtensionList>(), value, diffs, objName);
  }
  
  private static void SetOfficeArtExtensionList(DXO13DCS.ChartStyle openXmlElement, DMDCS.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO13DCS.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartsStyle.ChartStyle? CreateModelElement(DXO13DCS.ChartStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartsStyle.ChartStyle();
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
  
  public static bool CompareModelElement(DXO13DCS.ChartStyle? openXmlElement, DMDCS.ChartStyle? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpAxisTitle(openXmlElement, value.AxisTitle, diffs, objName))
        ok = false;
      if (!CmpCategoryAxis(openXmlElement, value.CategoryAxis, diffs, objName))
        ok = false;
      if (!CmpChartArea(openXmlElement, value.ChartArea, diffs, objName))
        ok = false;
      if (!CmpDataLabel(openXmlElement, value.DataLabel, diffs, objName))
        ok = false;
      if (!CmpDataLabelCallout(openXmlElement, value.DataLabelCallout, diffs, objName))
        ok = false;
      if (!CmpDataPoint(openXmlElement, value.DataPoint, diffs, objName))
        ok = false;
      if (!CmpDataPoint3D(openXmlElement, value.DataPoint3D, diffs, objName))
        ok = false;
      if (!CmpDataPointLine(openXmlElement, value.DataPointLine, diffs, objName))
        ok = false;
      if (!CmpDataPointMarker(openXmlElement, value.DataPointMarker, diffs, objName))
        ok = false;
      if (!CmpMarkerLayoutProperties(openXmlElement, value.MarkerLayoutProperties, diffs, objName))
        ok = false;
      if (!CmpDataPointWireframe(openXmlElement, value.DataPointWireframe, diffs, objName))
        ok = false;
      if (!CmpDataTableStyle(openXmlElement, value.DataTableStyle, diffs, objName))
        ok = false;
      if (!CmpDownBar(openXmlElement, value.DownBar, diffs, objName))
        ok = false;
      if (!CmpDropLine(openXmlElement, value.DropLine, diffs, objName))
        ok = false;
      if (!CmpErrorBar(openXmlElement, value.ErrorBar, diffs, objName))
        ok = false;
      if (!CmpFloor(openXmlElement, value.Floor, diffs, objName))
        ok = false;
      if (!CmpGridlineMajor(openXmlElement, value.GridlineMajor, diffs, objName))
        ok = false;
      if (!CmpGridlineMinor(openXmlElement, value.GridlineMinor, diffs, objName))
        ok = false;
      if (!CmpHiLoLine(openXmlElement, value.HiLoLine, diffs, objName))
        ok = false;
      if (!CmpLeaderLine(openXmlElement, value.LeaderLine, diffs, objName))
        ok = false;
      if (!CmpLegendStyle(openXmlElement, value.LegendStyle, diffs, objName))
        ok = false;
      if (!CmpPlotArea(openXmlElement, value.PlotArea, diffs, objName))
        ok = false;
      if (!CmpPlotArea3D(openXmlElement, value.PlotArea3D, diffs, objName))
        ok = false;
      if (!CmpSeriesAxis(openXmlElement, value.SeriesAxis, diffs, objName))
        ok = false;
      if (!CmpSeriesLine(openXmlElement, value.SeriesLine, diffs, objName))
        ok = false;
      if (!CmpTitleStyle(openXmlElement, value.TitleStyle, diffs, objName))
        ok = false;
      if (!CmpTrendlineStyle(openXmlElement, value.TrendlineStyle, diffs, objName))
        ok = false;
      if (!CmpTrendlineLabel(openXmlElement, value.TrendlineLabel, diffs, objName))
        ok = false;
      if (!CmpUpBar(openXmlElement, value.UpBar, diffs, objName))
        ok = false;
      if (!CmpValueAxis(openXmlElement, value.ValueAxis, diffs, objName))
        ok = false;
      if (!CmpWall(openXmlElement, value.Wall, diffs, objName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCS.ChartStyle value)
    where OpenXmlElementType: DXO13DCS.ChartStyle, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DCS.ChartStyle openXmlElement, DMDCS.ChartStyle value)
  {
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
  }
}
