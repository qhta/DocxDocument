namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the ChartStyle Class.
/// </summary>
public static class ChartStyleConverter
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetId(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, UInt32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// AxisTitle.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.AxisTitle? GetAxisTitle(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.AxisTitle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.AxisTitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAxisTitle(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.AxisTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.AxisTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.AxisTitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.AxisTitle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// CategoryAxis.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.CategoryAxis? GetCategoryAxis(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.CategoryAxis>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.CategoryAxisConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCategoryAxis(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.CategoryAxis? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.CategoryAxis>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.CategoryAxisConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.CategoryAxis>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartArea.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.ChartArea? GetChartArea(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartArea>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.ChartAreaConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartArea(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.ChartArea? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartArea>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.ChartAreaConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartArea>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.DataLabel? GetDataLabel(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.DataLabelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabel(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.DataLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.DataLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataLabelCallout.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.DataLabelCallout? GetDataLabelCallout(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabelCallout>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.DataLabelCalloutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabelCallout(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.DataLabelCallout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabelCallout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.DataLabelCalloutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabelCallout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataPoint.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.DataPoint? GetDataPoint(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.DataPointConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataPoint(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.DataPoint? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.DataPointConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataPoint3D.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.DataPoint3D? GetDataPoint3D(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint3D>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.DataPoint3DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataPoint3D(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.DataPoint3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.DataPoint3DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataPointLine.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.DataPointLine? GetDataPointLine(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointLine>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.DataPointLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataPointLine(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.DataPointLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.DataPointLineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointLine>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataPointMarker.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.DataPointMarker? GetDataPointMarker(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointMarker>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.DataPointMarkerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataPointMarker(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.DataPointMarker? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointMarker>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.DataPointMarkerConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointMarker>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// MarkerLayoutProperties.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.MarkerLayoutProperties? GetMarkerLayoutProperties(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.MarkerLayoutPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMarkerLayoutProperties(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.MarkerLayoutProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.MarkerLayoutPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataPointWireframe.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.DataPointWireframe? GetDataPointWireframe(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointWireframe>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.DataPointWireframeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataPointWireframe(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.DataPointWireframe? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointWireframe>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.DataPointWireframeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointWireframe>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataTableStyle.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.DataTableStyle? GetDataTableStyle(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataTableStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.DataTableStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataTableStyle(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.DataTableStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataTableStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.DataTableStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataTableStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DownBar.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.DownBar? GetDownBar(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DownBar>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.DownBarConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDownBar(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.DownBar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DownBar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.DownBarConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DownBar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DropLine.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.DropLine? GetDropLine(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DropLine>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.DropLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDropLine(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.DropLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DropLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.DropLineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DropLine>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ErrorBar.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.ErrorBar? GetErrorBar(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ErrorBar>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.ErrorBarConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetErrorBar(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.ErrorBar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ErrorBar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.ErrorBarConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ErrorBar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Floor.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.Floor? GetFloor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Floor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.FloorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFloor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.Floor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Floor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.FloorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Floor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GridlineMajor.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.GridlineMajor? GetGridlineMajor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMajor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.GridlineMajorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGridlineMajor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.GridlineMajor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMajor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.GridlineMajorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMajor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GridlineMinor.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.GridlineMinor? GetGridlineMinor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMinor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.GridlineMinorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGridlineMinor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.GridlineMinor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMinor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.GridlineMinorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMinor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// HiLoLine.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.HiLoLine? GetHiLoLine(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.HiLoLine>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.HiLoLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHiLoLine(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.HiLoLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.HiLoLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.HiLoLineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.HiLoLine>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// LeaderLine.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.LeaderLine? GetLeaderLine(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.LeaderLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLeaderLine(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.LeaderLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.LeaderLineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// LegendStyle.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.LegendStyle? GetLegendStyle(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LegendStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.LegendStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLegendStyle(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.LegendStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LegendStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.LegendStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LegendStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.PlotArea? GetPlotArea(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.PlotAreaConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPlotArea(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.PlotArea? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.PlotAreaConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PlotArea3D.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.PlotArea3D? GetPlotArea3D(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea3D>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.PlotArea3DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPlotArea3D(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.PlotArea3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.PlotArea3DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SeriesAxis.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.SeriesAxis? GetSeriesAxis(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesAxis>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.SeriesAxisConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSeriesAxis(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.SeriesAxis? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesAxis>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.SeriesAxisConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesAxis>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SeriesLine.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.SeriesLine? GetSeriesLine(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesLine>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.SeriesLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSeriesLine(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.SeriesLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.SeriesLineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesLine>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TitleStyle.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.TitleStyle? GetTitleStyle(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TitleStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.TitleStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTitleStyle(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.TitleStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TitleStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.TitleStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TitleStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TrendlineStyle.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.TrendlineStyle? GetTrendlineStyle(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.TrendlineStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTrendlineStyle(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.TrendlineStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.TrendlineStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TrendlineLabel.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.TrendlineLabel? GetTrendlineLabel(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineLabel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.TrendlineLabelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTrendlineLabel(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.TrendlineLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.TrendlineLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineLabel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// UpBar.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.UpBar? GetUpBar(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.UpBar>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.UpBarConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetUpBar(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.UpBar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.UpBar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.UpBarConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.UpBar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ValueAxis.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.ValueAxis? GetValueAxis(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ValueAxis>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.ValueAxisConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetValueAxis(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.ValueAxis? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ValueAxis>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.ValueAxisConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ValueAxis>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Wall.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.Wall? GetWall(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Wall>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.WallConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetWall(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.Wall? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Wall>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.WallConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Wall>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.OfficeArtExtensionList? GetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.OfficeArtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartsStyle.ChartStyle? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartsStyle.ChartStyle? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle, new()
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
