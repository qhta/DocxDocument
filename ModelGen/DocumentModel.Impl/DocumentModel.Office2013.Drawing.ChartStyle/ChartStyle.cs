namespace DocumentModel.Office2013.Drawing.ChartStyle;

/// <summary>
/// Defines the ChartStyle Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IMarkerLayoutProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IAxisTitle))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.ICategoryAxis))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IChartArea))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IDataLabel))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IDataLabelCallout))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IDataPoint))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IDataPoint3D))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IDataPointLine))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IDataPointMarker))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IDataPointWireframe))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IDataTableStyle))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IDownBar))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IDropLine))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IErrorBar))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IFloor))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IGridlineMajor))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IGridlineMinor))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IHiLoLine))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.ILeaderLine))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.ILegendStyle))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IPlotArea))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IPlotArea3D))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.ISeriesAxis))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.ISeriesLine))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.ITitleStyle))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.ITrendlineStyle))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.ITrendlineLabel))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IUpBar))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IValueAxis))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IWall))]
public class ChartStyle: IChartStyle
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// AxisTitle.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IAxisTitle? AxisTitle
  {
    get;
    set;
  }
  
  /// <summary>
  /// CategoryAxis.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.ICategoryAxis? CategoryAxis
  {
    get;
    set;
  }
  
  /// <summary>
  /// ChartArea.
  /// </summary>
  public IChartArea? ChartArea
  {
    get;
    set;
  }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IDataLabel? DataLabel
  {
    get;
    set;
  }
  
  /// <summary>
  /// DataLabelCallout.
  /// </summary>
  public IDataLabelCallout? DataLabelCallout
  {
    get;
    set;
  }
  
  /// <summary>
  /// DataPoint.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IDataPoint? DataPoint
  {
    get;
    set;
  }
  
  /// <summary>
  /// DataPoint3D.
  /// </summary>
  public IDataPoint3D? DataPoint3D
  {
    get;
    set;
  }
  
  /// <summary>
  /// DataPointLine.
  /// </summary>
  public IDataPointLine? DataPointLine
  {
    get;
    set;
  }
  
  /// <summary>
  /// DataPointMarker.
  /// </summary>
  public IDataPointMarker? DataPointMarker
  {
    get;
    set;
  }
  
  /// <summary>
  /// MarkerLayoutProperties.
  /// </summary>
  public IMarkerLayoutProperties? MarkerLayoutProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// DataPointWireframe.
  /// </summary>
  public IDataPointWireframe? DataPointWireframe
  {
    get;
    set;
  }
  
  /// <summary>
  /// DataTableStyle.
  /// </summary>
  public IDataTableStyle? DataTableStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// DownBar.
  /// </summary>
  public IDownBar? DownBar
  {
    get;
    set;
  }
  
  /// <summary>
  /// DropLine.
  /// </summary>
  public IDropLine? DropLine
  {
    get;
    set;
  }
  
  /// <summary>
  /// ErrorBar.
  /// </summary>
  public IErrorBar? ErrorBar
  {
    get;
    set;
  }
  
  /// <summary>
  /// Floor.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IFloor? Floor
  {
    get;
    set;
  }
  
  /// <summary>
  /// GridlineMajor.
  /// </summary>
  public IGridlineMajor? GridlineMajor
  {
    get;
    set;
  }
  
  /// <summary>
  /// GridlineMinor.
  /// </summary>
  public IGridlineMinor? GridlineMinor
  {
    get;
    set;
  }
  
  /// <summary>
  /// HiLoLine.
  /// </summary>
  public IHiLoLine? HiLoLine
  {
    get;
    set;
  }
  
  /// <summary>
  /// LeaderLine.
  /// </summary>
  public ILeaderLine? LeaderLine
  {
    get;
    set;
  }
  
  /// <summary>
  /// LegendStyle.
  /// </summary>
  public ILegendStyle? LegendStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IPlotArea? PlotArea
  {
    get;
    set;
  }
  
  /// <summary>
  /// PlotArea3D.
  /// </summary>
  public IPlotArea3D? PlotArea3D
  {
    get;
    set;
  }
  
  /// <summary>
  /// SeriesAxis.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.ISeriesAxis? SeriesAxis
  {
    get;
    set;
  }
  
  /// <summary>
  /// SeriesLine.
  /// </summary>
  public ISeriesLine? SeriesLine
  {
    get;
    set;
  }
  
  /// <summary>
  /// TitleStyle.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.ITitleStyle? TitleStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// TrendlineStyle.
  /// </summary>
  public ITrendlineStyle? TrendlineStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// TrendlineLabel.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.ITrendlineLabel? TrendlineLabel
  {
    get;
    set;
  }
  
  /// <summary>
  /// UpBar.
  /// </summary>
  public IUpBar? UpBar
  {
    get;
    set;
  }
  
  /// <summary>
  /// ValueAxis.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IValueAxis? ValueAxis
  {
    get;
    set;
  }
  
  /// <summary>
  /// Wall.
  /// </summary>
  public IWall? Wall
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IOfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
