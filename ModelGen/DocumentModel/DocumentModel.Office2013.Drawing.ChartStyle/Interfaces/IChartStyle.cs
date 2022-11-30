namespace DocumentModel.Office2013.Drawing.ChartStyle;

/// <summary>
/// Defines the ChartStyle Class.
/// </summary>
public interface IChartStyle // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// AxisTitle.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IAxisTitle? AxisTitle { get ; set; }
  
  /// <summary>
  /// CategoryAxis.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.ICategoryAxis? CategoryAxis { get ; set; }
  
  /// <summary>
  /// ChartArea.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IChartArea? ChartArea { get ; set; }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IDataLabel? DataLabel { get ; set; }
  
  /// <summary>
  /// DataLabelCallout.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IDataLabelCallout? DataLabelCallout { get ; set; }
  
  /// <summary>
  /// DataPoint.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IDataPoint? DataPoint { get ; set; }
  
  /// <summary>
  /// DataPoint3D.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IDataPoint3D? DataPoint3D { get ; set; }
  
  /// <summary>
  /// DataPointLine.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IDataPointLine? DataPointLine { get ; set; }
  
  /// <summary>
  /// DataPointMarker.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IDataPointMarker? DataPointMarker { get ; set; }
  
  /// <summary>
  /// MarkerLayoutProperties.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IMarkerLayoutProperties? MarkerLayoutProperties { get ; set; }
  
  /// <summary>
  /// DataPointWireframe.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IDataPointWireframe? DataPointWireframe { get ; set; }
  
  /// <summary>
  /// DataTableStyle.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IDataTableStyle? DataTableStyle { get ; set; }
  
  /// <summary>
  /// DownBar.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IDownBar? DownBar { get ; set; }
  
  /// <summary>
  /// DropLine.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IDropLine? DropLine { get ; set; }
  
  /// <summary>
  /// ErrorBar.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IErrorBar? ErrorBar { get ; set; }
  
  /// <summary>
  /// Floor.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IFloor? Floor { get ; set; }
  
  /// <summary>
  /// GridlineMajor.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IGridlineMajor? GridlineMajor { get ; set; }
  
  /// <summary>
  /// GridlineMinor.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IGridlineMinor? GridlineMinor { get ; set; }
  
  /// <summary>
  /// HiLoLine.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IHiLoLine? HiLoLine { get ; set; }
  
  /// <summary>
  /// LeaderLine.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.ILeaderLine? LeaderLine { get ; set; }
  
  /// <summary>
  /// LegendStyle.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.ILegendStyle? LegendStyle { get ; set; }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IPlotArea? PlotArea { get ; set; }
  
  /// <summary>
  /// PlotArea3D.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IPlotArea3D? PlotArea3D { get ; set; }
  
  /// <summary>
  /// SeriesAxis.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.ISeriesAxis? SeriesAxis { get ; set; }
  
  /// <summary>
  /// SeriesLine.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.ISeriesLine? SeriesLine { get ; set; }
  
  /// <summary>
  /// TitleStyle.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.ITitleStyle? TitleStyle { get ; set; }
  
  /// <summary>
  /// TrendlineStyle.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.ITrendlineStyle? TrendlineStyle { get ; set; }
  
  /// <summary>
  /// TrendlineLabel.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.ITrendlineLabel? TrendlineLabel { get ; set; }
  
  /// <summary>
  /// UpBar.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IUpBar? UpBar { get ; set; }
  
  /// <summary>
  /// ValueAxis.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IValueAxis? ValueAxis { get ; set; }
  
  /// <summary>
  /// Wall.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IWall? Wall { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
