namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ChartStyle Class.
/// </summary>
public interface IChartStyle // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Id { get ; set; }
  
  /// <summary>
  /// AxisTitle.
  /// </summary>
  public IAxisTitle? AxisTitle { get ; set; }
  
  /// <summary>
  /// CategoryAxis.
  /// </summary>
  public ICategoryAxis? CategoryAxis { get ; set; }
  
  /// <summary>
  /// ChartArea.
  /// </summary>
  public IChartArea? ChartArea { get ; set; }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  public IDataLabel? DataLabel { get ; set; }
  
  /// <summary>
  /// DataLabelCallout.
  /// </summary>
  public IDataLabelCallout? DataLabelCallout { get ; set; }
  
  /// <summary>
  /// DataPoint.
  /// </summary>
  public IDataPoint? DataPoint { get ; set; }
  
  /// <summary>
  /// DataPoint3D.
  /// </summary>
  public IDataPoint3D? DataPoint3D { get ; set; }
  
  /// <summary>
  /// DataPointLine.
  /// </summary>
  public IDataPointLine? DataPointLine { get ; set; }
  
  /// <summary>
  /// DataPointMarker.
  /// </summary>
  public IDataPointMarker? DataPointMarker { get ; set; }
  
  /// <summary>
  /// MarkerLayoutProperties.
  /// </summary>
  public IMarkerLayoutProperties? MarkerLayoutProperties { get ; set; }
  
  /// <summary>
  /// DataPointWireframe.
  /// </summary>
  public IDataPointWireframe? DataPointWireframe { get ; set; }
  
  /// <summary>
  /// DataTableStyle.
  /// </summary>
  public IDataTableStyle? DataTableStyle { get ; set; }
  
  /// <summary>
  /// DownBar.
  /// </summary>
  public IDownBar? DownBar { get ; set; }
  
  /// <summary>
  /// DropLine.
  /// </summary>
  public IDropLine? DropLine { get ; set; }
  
  /// <summary>
  /// ErrorBar.
  /// </summary>
  public IErrorBar? ErrorBar { get ; set; }
  
  /// <summary>
  /// Floor.
  /// </summary>
  public IFloor? Floor { get ; set; }
  
  /// <summary>
  /// GridlineMajor.
  /// </summary>
  public IGridlineMajor? GridlineMajor { get ; set; }
  
  /// <summary>
  /// GridlineMinor.
  /// </summary>
  public IGridlineMinor? GridlineMinor { get ; set; }
  
  /// <summary>
  /// HiLoLine.
  /// </summary>
  public IHiLoLine? HiLoLine { get ; set; }
  
  /// <summary>
  /// LeaderLine.
  /// </summary>
  public ILeaderLine? LeaderLine { get ; set; }
  
  /// <summary>
  /// LegendStyle.
  /// </summary>
  public ILegendStyle? LegendStyle { get ; set; }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  public IPlotArea? PlotArea { get ; set; }
  
  /// <summary>
  /// PlotArea3D.
  /// </summary>
  public IPlotArea3D? PlotArea3D { get ; set; }
  
  /// <summary>
  /// SeriesAxis.
  /// </summary>
  public ISeriesAxis? SeriesAxis { get ; set; }
  
  /// <summary>
  /// SeriesLine.
  /// </summary>
  public ISeriesLine? SeriesLine { get ; set; }
  
  /// <summary>
  /// TitleStyle.
  /// </summary>
  public ITitleStyle? TitleStyle { get ; set; }
  
  /// <summary>
  /// TrendlineStyle.
  /// </summary>
  public ITrendlineStyle? TrendlineStyle { get ; set; }
  
  /// <summary>
  /// TrendlineLabel.
  /// </summary>
  public ITrendlineLabel? TrendlineLabel { get ; set; }
  
  /// <summary>
  /// UpBar.
  /// </summary>
  public IUpBar? UpBar { get ; set; }
  
  /// <summary>
  /// ValueAxis.
  /// </summary>
  public IValueAxis? ValueAxis { get ; set; }
  
  /// <summary>
  /// Wall.
  /// </summary>
  public IWall? Wall { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
