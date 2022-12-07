namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartStyle Class.
/// </summary>
public interface ChartStyle
{
  /// <summary>
  /// AxisTitle.
  /// </summary>
  public AxisTitle1? AxisTitle { get ; set; }
  
  /// <summary>
  /// CategoryAxis.
  /// </summary>
  public CategoryAxis1? CategoryAxis { get ; set; }
  
  /// <summary>
  /// ChartArea.
  /// </summary>
  public ChartArea? ChartArea { get ; set; }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  public DataLabel1? DataLabel { get ; set; }
  
  /// <summary>
  /// DataLabelCallout.
  /// </summary>
  public DataLabelCallout? DataLabelCallout { get ; set; }
  
  /// <summary>
  /// DataPoint.
  /// </summary>
  public DataPoint1? DataPoint { get ; set; }
  
  /// <summary>
  /// DataPoint3D.
  /// </summary>
  public DataPoint3D? DataPoint3D { get ; set; }
  
  /// <summary>
  /// DataPointLine.
  /// </summary>
  public DataPointLine? DataPointLine { get ; set; }
  
  /// <summary>
  /// DataPointMarker.
  /// </summary>
  public DataPointMarker? DataPointMarker { get ; set; }
  
  /// <summary>
  /// MarkerLayoutProperties.
  /// </summary>
  public MarkerLayoutProperties? MarkerLayoutProperties { get ; set; }
  
  /// <summary>
  /// DataPointWireframe.
  /// </summary>
  public DataPointWireframe? DataPointWireframe { get ; set; }
  
  /// <summary>
  /// DataTableStyle.
  /// </summary>
  public DataTableStyle? DataTableStyle { get ; set; }
  
  /// <summary>
  /// DownBar.
  /// </summary>
  public DownBar? DownBar { get ; set; }
  
  /// <summary>
  /// DropLine.
  /// </summary>
  public DropLine? DropLine { get ; set; }
  
  /// <summary>
  /// ErrorBar.
  /// </summary>
  public ErrorBar? ErrorBar { get ; set; }
  
  /// <summary>
  /// Floor.
  /// </summary>
  public Floor2? Floor { get ; set; }
  
  /// <summary>
  /// GridlineMajor.
  /// </summary>
  public GridlineMajor? GridlineMajor { get ; set; }
  
  /// <summary>
  /// GridlineMinor.
  /// </summary>
  public GridlineMinor? GridlineMinor { get ; set; }
  
  /// <summary>
  /// HiLoLine.
  /// </summary>
  public HiLoLine? HiLoLine { get ; set; }
  
  /// <summary>
  /// LeaderLine.
  /// </summary>
  public LeaderLine? LeaderLine { get ; set; }
  
  /// <summary>
  /// LegendStyle.
  /// </summary>
  public LegendStyle? LegendStyle { get ; set; }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  public PlotArea3? PlotArea { get ; set; }
  
  /// <summary>
  /// PlotArea3D.
  /// </summary>
  public PlotArea3D? PlotArea3D { get ; set; }
  
  /// <summary>
  /// SeriesAxis.
  /// </summary>
  public SeriesAxis1? SeriesAxis { get ; set; }
  
  /// <summary>
  /// SeriesLine.
  /// </summary>
  public SeriesLine? SeriesLine { get ; set; }
  
  /// <summary>
  /// TitleStyle.
  /// </summary>
  public TitleStyle? TitleStyle { get ; set; }
  
  /// <summary>
  /// TrendlineStyle.
  /// </summary>
  public TrendlineStyle? TrendlineStyle { get ; set; }
  
  /// <summary>
  /// TrendlineLabel.
  /// </summary>
  public TrendlineLabel1? TrendlineLabel { get ; set; }
  
  /// <summary>
  /// UpBar.
  /// </summary>
  public UpBar? UpBar { get ; set; }
  
  /// <summary>
  /// ValueAxis.
  /// </summary>
  public ValueAxis1? ValueAxis { get ; set; }
  
  /// <summary>
  /// Wall.
  /// </summary>
  public Wall? Wall { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList1? OfficeArtExtensionList { get ; set; }
  
}
