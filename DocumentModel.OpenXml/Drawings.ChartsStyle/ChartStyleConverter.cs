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
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2013DrawChartStyle.ChartStyle openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.AxisTitle>();
    if (element != null)
      return DMXDrawsChartsStyle.AxisTitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAxisTitle(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.AxisTitle? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.AxisTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.AxisTitle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.CategoryAxis>();
    if (element != null)
      return DMXDrawsChartsStyle.CategoryAxisConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCategoryAxis(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.CategoryAxis? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.CategoryAxisConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.CategoryAxis>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.ChartArea>();
    if (element != null)
      return DMXDrawsChartsStyle.ChartAreaConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartArea(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.ChartArea? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.ChartAreaConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.ChartArea>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.DataLabel>();
    if (element != null)
      return DMXDrawsChartsStyle.DataLabelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabel(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.DataLabel? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.DataLabelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.DataLabel>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.DataLabelCallout>();
    if (element != null)
      return DMXDrawsChartsStyle.DataLabelCalloutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabelCallout(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.DataLabelCallout? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.DataLabelCalloutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.DataLabelCallout>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.DataPoint>();
    if (element != null)
      return DMXDrawsChartsStyle.DataPointConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataPoint(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.DataPoint? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.DataPointConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.DataPoint>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.DataPoint3D>();
    if (element != null)
      return DMXDrawsChartsStyle.DataPoint3DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataPoint3D(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.DataPoint3D? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.DataPoint3DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.DataPoint3D>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.DataPointLine>();
    if (element != null)
      return DMXDrawsChartsStyle.DataPointLineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataPointLine(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.DataPointLine? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.DataPointLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.DataPointLine>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.DataPointMarker>();
    if (element != null)
      return DMXDrawsChartsStyle.DataPointMarkerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataPointMarker(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.DataPointMarker? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.DataPointMarkerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.DataPointMarker>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.MarkerLayoutProperties>();
    if (element != null)
      return DMXDrawsChartsStyle.MarkerLayoutPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMarkerLayoutProperties(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.MarkerLayoutProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.MarkerLayoutPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.MarkerLayoutProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.DataPointWireframe>();
    if (element != null)
      return DMXDrawsChartsStyle.DataPointWireframeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataPointWireframe(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.DataPointWireframe? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.DataPointWireframeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.DataPointWireframe>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.DataTableStyle>();
    if (element != null)
      return DMXDrawsChartsStyle.DataTableStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataTableStyle(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.DataTableStyle? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.DataTableStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.DataTableStyle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.DownBar>();
    if (element != null)
      return DMXDrawsChartsStyle.DownBarConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDownBar(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.DownBar? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.DownBarConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.DownBar>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.DropLine>();
    if (element != null)
      return DMXDrawsChartsStyle.DropLineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDropLine(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.DropLine? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.DropLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.DropLine>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.ErrorBar>();
    if (element != null)
      return DMXDrawsChartsStyle.ErrorBarConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpErrorBar(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.ErrorBar? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.ErrorBarConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.ErrorBar>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.Floor>();
    if (element != null)
      return DMXDrawsChartsStyle.FloorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFloor(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.Floor? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.FloorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.Floor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.GridlineMajor>();
    if (element != null)
      return DMXDrawsChartsStyle.GridlineMajorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGridlineMajor(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.GridlineMajor? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.GridlineMajorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.GridlineMajor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.GridlineMinor>();
    if (element != null)
      return DMXDrawsChartsStyle.GridlineMinorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGridlineMinor(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.GridlineMinor? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.GridlineMinorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.GridlineMinor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.HiLoLine>();
    if (element != null)
      return DMXDrawsChartsStyle.HiLoLineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHiLoLine(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.HiLoLine? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.HiLoLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.HiLoLine>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.LeaderLine>();
    if (element != null)
      return DMXDrawsChartsStyle.LeaderLineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLeaderLine(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.LeaderLine? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.LeaderLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.LeaderLine>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.LegendStyle>();
    if (element != null)
      return DMXDrawsChartsStyle.LegendStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLegendStyle(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.LegendStyle? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.LegendStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.LegendStyle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.PlotArea>();
    if (element != null)
      return DMXDrawsChartsStyle.PlotAreaConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPlotArea(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.PlotArea? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.PlotAreaConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.PlotArea>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.PlotArea3D>();
    if (element != null)
      return DMXDrawsChartsStyle.PlotArea3DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPlotArea3D(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.PlotArea3D? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.PlotArea3DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.PlotArea3D>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.SeriesAxis>();
    if (element != null)
      return DMXDrawsChartsStyle.SeriesAxisConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSeriesAxis(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.SeriesAxis? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.SeriesAxisConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.SeriesAxis>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.SeriesLine>();
    if (element != null)
      return DMXDrawsChartsStyle.SeriesLineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSeriesLine(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.SeriesLine? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.SeriesLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.SeriesLine>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.TitleStyle>();
    if (element != null)
      return DMXDrawsChartsStyle.TitleStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTitleStyle(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.TitleStyle? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.TitleStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.TitleStyle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.TrendlineStyle>();
    if (element != null)
      return DMXDrawsChartsStyle.TrendlineStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTrendlineStyle(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.TrendlineStyle? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.TrendlineStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.TrendlineStyle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.TrendlineLabel>();
    if (element != null)
      return DMXDrawsChartsStyle.TrendlineLabelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTrendlineLabel(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.TrendlineLabel? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.TrendlineLabelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.TrendlineLabel>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.UpBar>();
    if (element != null)
      return DMXDrawsChartsStyle.UpBarConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUpBar(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.UpBar? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.UpBarConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.UpBar>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.ValueAxis>();
    if (element != null)
      return DMXDrawsChartsStyle.ValueAxisConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpValueAxis(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.ValueAxis? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.ValueAxisConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.ValueAxis>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.Wall>();
    if (element != null)
      return DMXDrawsChartsStyle.WallConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWall(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.Wall? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.WallConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.Wall>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.OfficeArtExtensionList>();
    if (element != null)
      return DMXDrawsChartsStyle.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO2013DrawChartStyle.ChartStyle openXmlElement, DMDrawsChartsStyle.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.OfficeArtExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Drawings.ChartsStyle.ChartStyle? CreateModelElement(DXO2013DrawChartStyle.ChartStyle? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2013DrawChartStyle.ChartStyle? openXmlElement, DMDrawsChartsStyle.ChartStyle? value, DiffList? diffs, string? objName)
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
