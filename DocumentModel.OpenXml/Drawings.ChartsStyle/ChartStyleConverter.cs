using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using AxisTitle = DocumentModel.Drawings.ChartsStyle.AxisTitle;
using CategoryAxis = DocumentModel.Drawings.ChartsStyle.CategoryAxis;
using ChartArea = DocumentModel.Drawings.ChartsStyle.ChartArea;
using DataLabel = DocumentModel.Drawings.ChartsStyle.DataLabel;
using DataLabelCallout = DocumentModel.Drawings.ChartsStyle.DataLabelCallout;
using DataPoint = DocumentModel.Drawings.ChartsStyle.DataPoint;
using DataPoint3D = DocumentModel.Drawings.ChartsStyle.DataPoint3D;
using DataPointLine = DocumentModel.Drawings.ChartsStyle.DataPointLine;
using DataPointMarker = DocumentModel.Drawings.ChartsStyle.DataPointMarker;
using DataPointWireframe = DocumentModel.Drawings.ChartsStyle.DataPointWireframe;
using DataTableStyle = DocumentModel.Drawings.ChartsStyle.DataTableStyle;
using DownBar = DocumentModel.Drawings.ChartsStyle.DownBar;
using DropLine = DocumentModel.Drawings.ChartsStyle.DropLine;
using ErrorBar = DocumentModel.Drawings.ChartsStyle.ErrorBar;
using Floor = DocumentModel.Drawings.ChartsStyle.Floor;
using GridlineMajor = DocumentModel.Drawings.ChartsStyle.GridlineMajor;
using GridlineMinor = DocumentModel.Drawings.ChartsStyle.GridlineMinor;
using HiLoLine = DocumentModel.Drawings.ChartsStyle.HiLoLine;
using LeaderLine = DocumentModel.Drawings.ChartsStyle.LeaderLine;
using LegendStyle = DocumentModel.Drawings.ChartsStyle.LegendStyle;
using MarkerLayoutProperties = DocumentModel.Drawings.ChartsStyle.MarkerLayoutProperties;
using PlotArea = DocumentModel.Drawings.ChartsStyle.PlotArea;
using PlotArea3D = DocumentModel.Drawings.ChartsStyle.PlotArea3D;
using SeriesAxis = DocumentModel.Drawings.ChartsStyle.SeriesAxis;
using SeriesLine = DocumentModel.Drawings.ChartsStyle.SeriesLine;
using TitleStyle = DocumentModel.Drawings.ChartsStyle.TitleStyle;
using TrendlineLabel = DocumentModel.Drawings.ChartsStyle.TrendlineLabel;
using TrendlineStyle = DocumentModel.Drawings.ChartsStyle.TrendlineStyle;
using UpBar = DocumentModel.Drawings.ChartsStyle.UpBar;
using ValueAxis = DocumentModel.Drawings.ChartsStyle.ValueAxis;
using Wall = DocumentModel.Drawings.ChartsStyle.Wall;

namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
///   Defines the ChartStyle Class.
/// </summary>
public static class ChartStyleConverter
{
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public static UInt32? GetId(ChartStyle? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(ChartStyle? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Id = value;
  }

  /// <summary>
  ///   AxisTitle.
  /// </summary>
  public static AxisTitle? GetAxisTitle(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.AxisTitle>();
    if (itemElement != null)
      return AxisTitleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAxisTitle(ChartStyle? openXmlElement, AxisTitle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.AxisTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AxisTitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.AxisTitle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   CategoryAxis.
  /// </summary>
  public static CategoryAxis? GetCategoryAxis(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.CategoryAxis>();
    if (itemElement != null)
      return CategoryAxisConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCategoryAxis(ChartStyle? openXmlElement, CategoryAxis? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.CategoryAxis>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CategoryAxisConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.CategoryAxis>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ChartArea.
  /// </summary>
  public static ChartArea? GetChartArea(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartArea>();
    if (itemElement != null)
      return ChartAreaConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartArea(ChartStyle? openXmlElement, ChartArea? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartArea>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartAreaConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartArea>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DataLabel.
  /// </summary>
  public static DataLabel? GetDataLabel(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabel>();
    if (itemElement != null)
      return DataLabelConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataLabel(ChartStyle? openXmlElement, DataLabel? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabel>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DataLabelCallout.
  /// </summary>
  public static DataLabelCallout? GetDataLabelCallout(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabelCallout>();
    if (itemElement != null)
      return DataLabelCalloutConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataLabelCallout(ChartStyle? openXmlElement, DataLabelCallout? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabelCallout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelCalloutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabelCallout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DataPoint.
  /// </summary>
  public static DataPoint? GetDataPoint(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint>();
    if (itemElement != null)
      return DataPointConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataPoint(ChartStyle? openXmlElement, DataPoint? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataPointConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DataPoint3D.
  /// </summary>
  public static DataPoint3D? GetDataPoint3D(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint3D>();
    if (itemElement != null)
      return DataPoint3DConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataPoint3D(ChartStyle? openXmlElement, DataPoint3D? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataPoint3DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint3D>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DataPointLine.
  /// </summary>
  public static DataPointLine? GetDataPointLine(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointLine>();
    if (itemElement != null)
      return DataPointLineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataPointLine(ChartStyle? openXmlElement, DataPointLine? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointLine>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataPointLineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointLine>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DataPointMarker.
  /// </summary>
  public static DataPointMarker? GetDataPointMarker(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointMarker>();
    if (itemElement != null)
      return DataPointMarkerConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataPointMarker(ChartStyle? openXmlElement, DataPointMarker? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointMarker>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataPointMarkerConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointMarker>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   MarkerLayoutProperties.
  /// </summary>
  public static MarkerLayoutProperties? GetMarkerLayoutProperties(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties>();
    if (itemElement != null)
      return MarkerLayoutPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMarkerLayoutProperties(ChartStyle? openXmlElement, MarkerLayoutProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkerLayoutPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DataPointWireframe.
  /// </summary>
  public static DataPointWireframe? GetDataPointWireframe(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointWireframe>();
    if (itemElement != null)
      return DataPointWireframeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataPointWireframe(ChartStyle? openXmlElement, DataPointWireframe? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointWireframe>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataPointWireframeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointWireframe>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DataTableStyle.
  /// </summary>
  public static DataTableStyle? GetDataTableStyle(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataTableStyle>();
    if (itemElement != null)
      return DataTableStyleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataTableStyle(ChartStyle? openXmlElement, DataTableStyle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataTableStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataTableStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataTableStyle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DownBar.
  /// </summary>
  public static DownBar? GetDownBar(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DownBar>();
    if (itemElement != null)
      return DownBarConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDownBar(ChartStyle? openXmlElement, DownBar? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DownBar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DownBarConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DownBar>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DropLine.
  /// </summary>
  public static DropLine? GetDropLine(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DropLine>();
    if (itemElement != null)
      return DropLineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDropLine(ChartStyle? openXmlElement, DropLine? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DropLine>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DropLineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DropLine>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ErrorBar.
  /// </summary>
  public static ErrorBar? GetErrorBar(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ErrorBar>();
    if (itemElement != null)
      return ErrorBarConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetErrorBar(ChartStyle? openXmlElement, ErrorBar? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ErrorBar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ErrorBarConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ErrorBar>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Floor.
  /// </summary>
  public static Floor? GetFloor(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Floor>();
    if (itemElement != null)
      return FloorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFloor(ChartStyle? openXmlElement, Floor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Floor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FloorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Floor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   GridlineMajor.
  /// </summary>
  public static GridlineMajor? GetGridlineMajor(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMajor>();
    if (itemElement != null)
      return GridlineMajorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGridlineMajor(ChartStyle? openXmlElement, GridlineMajor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMajor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GridlineMajorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMajor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   GridlineMinor.
  /// </summary>
  public static GridlineMinor? GetGridlineMinor(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMinor>();
    if (itemElement != null)
      return GridlineMinorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGridlineMinor(ChartStyle? openXmlElement, GridlineMinor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMinor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GridlineMinorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMinor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   HiLoLine.
  /// </summary>
  public static HiLoLine? GetHiLoLine(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.HiLoLine>();
    if (itemElement != null)
      return HiLoLineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHiLoLine(ChartStyle? openXmlElement, HiLoLine? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.HiLoLine>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HiLoLineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.HiLoLine>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   LeaderLine.
  /// </summary>
  public static LeaderLine? GetLeaderLine(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine>();
    if (itemElement != null)
      return LeaderLineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLeaderLine(ChartStyle? openXmlElement, LeaderLine? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LeaderLineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   LegendStyle.
  /// </summary>
  public static LegendStyle? GetLegendStyle(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LegendStyle>();
    if (itemElement != null)
      return LegendStyleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLegendStyle(ChartStyle? openXmlElement, LegendStyle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LegendStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LegendStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LegendStyle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   PlotArea.
  /// </summary>
  public static PlotArea? GetPlotArea(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea>();
    if (itemElement != null)
      return PlotAreaConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPlotArea(ChartStyle? openXmlElement, PlotArea? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PlotAreaConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   PlotArea3D.
  /// </summary>
  public static PlotArea3D? GetPlotArea3D(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea3D>();
    if (itemElement != null)
      return PlotArea3DConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPlotArea3D(ChartStyle? openXmlElement, PlotArea3D? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PlotArea3DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea3D>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   SeriesAxis.
  /// </summary>
  public static SeriesAxis? GetSeriesAxis(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesAxis>();
    if (itemElement != null)
      return SeriesAxisConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSeriesAxis(ChartStyle? openXmlElement, SeriesAxis? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesAxis>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SeriesAxisConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesAxis>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   SeriesLine.
  /// </summary>
  public static SeriesLine? GetSeriesLine(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesLine>();
    if (itemElement != null)
      return SeriesLineConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSeriesLine(ChartStyle? openXmlElement, SeriesLine? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesLine>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SeriesLineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesLine>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TitleStyle.
  /// </summary>
  public static TitleStyle? GetTitleStyle(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TitleStyle>();
    if (itemElement != null)
      return TitleStyleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTitleStyle(ChartStyle? openXmlElement, TitleStyle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TitleStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TitleStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TitleStyle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TrendlineStyle.
  /// </summary>
  public static TrendlineStyle? GetTrendlineStyle(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineStyle>();
    if (itemElement != null)
      return TrendlineStyleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTrendlineStyle(ChartStyle? openXmlElement, TrendlineStyle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrendlineStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineStyle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TrendlineLabel.
  /// </summary>
  public static TrendlineLabel? GetTrendlineLabel(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineLabel>();
    if (itemElement != null)
      return TrendlineLabelConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTrendlineLabel(ChartStyle? openXmlElement, TrendlineLabel? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineLabel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrendlineLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineLabel>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   UpBar.
  /// </summary>
  public static UpBar? GetUpBar(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.UpBar>();
    if (itemElement != null)
      return UpBarConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUpBar(ChartStyle? openXmlElement, UpBar? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.UpBar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UpBarConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.UpBar>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ValueAxis.
  /// </summary>
  public static ValueAxis? GetValueAxis(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ValueAxis>();
    if (itemElement != null)
      return ValueAxisConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetValueAxis(ChartStyle? openXmlElement, ValueAxis? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ValueAxis>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ValueAxisConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ValueAxis>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Wall.
  /// </summary>
  public static Wall? GetWall(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Wall>();
    if (itemElement != null)
      return WallConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetWall(ChartStyle? openXmlElement, Wall? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Wall>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WallConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Wall>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ChartsStyle.OfficeArtExtensionList? GetOfficeArtExtensionList(ChartStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>();
    if (itemElement != null)
      return OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOfficeArtExtensionList(ChartStyle? openXmlElement, DocumentModel.Drawings.ChartsStyle.OfficeArtExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartsStyle.ChartStyle? CreateModelElement(ChartStyle? openXmlElement)
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
    where OpenXmlElementType : ChartStyle, new()
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