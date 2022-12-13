namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the ChartStyle Class.
/// </summary>
public interface ChartStyle
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Id { get ; set; }
  
  /// <summary>
  /// AxisTitle.
  /// </summary>
  public DocumentModel.Drawings13.Charts.AxisTitle? AxisTitle { get ; set; }
  
  /// <summary>
  /// CategoryAxis.
  /// </summary>
  public DocumentModel.Drawings13.Charts.CategoryAxis? CategoryAxis { get ; set; }
  
  /// <summary>
  /// ChartArea.
  /// </summary>
  public DocumentModel.Drawings13.Charts.ChartArea? ChartArea { get ; set; }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DataLabel? DataLabel { get ; set; }
  
  /// <summary>
  /// DataLabelCallout.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DataLabelCallout? DataLabelCallout { get ; set; }
  
  /// <summary>
  /// DataPoint.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DataPoint? DataPoint { get ; set; }
  
  /// <summary>
  /// DataPoint3D.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DataPoint3D? DataPoint3D { get ; set; }
  
  /// <summary>
  /// DataPointLine.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DataPointLine? DataPointLine { get ; set; }
  
  /// <summary>
  /// DataPointMarker.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DataPointMarker? DataPointMarker { get ; set; }
  
  /// <summary>
  /// MarkerLayoutProperties.
  /// </summary>
  public DocumentModel.Drawings13.Charts.MarkerLayoutProperties? MarkerLayoutProperties { get ; set; }
  
  /// <summary>
  /// DataPointWireframe.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DataPointWireframe? DataPointWireframe { get ; set; }
  
  /// <summary>
  /// DataTableStyle.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DataTableStyle? DataTableStyle { get ; set; }
  
  /// <summary>
  /// DownBar.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DownBar? DownBar { get ; set; }
  
  /// <summary>
  /// DropLine.
  /// </summary>
  public DocumentModel.Drawings13.Charts.DropLine? DropLine { get ; set; }
  
  /// <summary>
  /// ErrorBar.
  /// </summary>
  public DocumentModel.Drawings13.Charts.ErrorBar? ErrorBar { get ; set; }
  
  /// <summary>
  /// Floor.
  /// </summary>
  public DocumentModel.Drawings13.Charts.Floor? Floor { get ; set; }
  
  /// <summary>
  /// GridlineMajor.
  /// </summary>
  public DocumentModel.Drawings13.Charts.GridlineMajor? GridlineMajor { get ; set; }
  
  /// <summary>
  /// GridlineMinor.
  /// </summary>
  public DocumentModel.Drawings13.Charts.GridlineMinor? GridlineMinor { get ; set; }
  
  /// <summary>
  /// HiLoLine.
  /// </summary>
  public DocumentModel.Drawings13.Charts.HiLoLine? HiLoLine { get ; set; }
  
  /// <summary>
  /// LeaderLine.
  /// </summary>
  public DocumentModel.Drawings13.Charts.LeaderLine? LeaderLine { get ; set; }
  
  /// <summary>
  /// LegendStyle.
  /// </summary>
  public DocumentModel.Drawings13.Charts.LegendStyle? LegendStyle { get ; set; }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  public DocumentModel.Drawings13.Charts.PlotArea? PlotArea { get ; set; }
  
  /// <summary>
  /// PlotArea3D.
  /// </summary>
  public DocumentModel.Drawings13.Charts.PlotArea3D? PlotArea3D { get ; set; }
  
  /// <summary>
  /// SeriesAxis.
  /// </summary>
  public DocumentModel.Drawings13.Charts.SeriesAxis? SeriesAxis { get ; set; }
  
  /// <summary>
  /// SeriesLine.
  /// </summary>
  public DocumentModel.Drawings13.Charts.SeriesLine? SeriesLine { get ; set; }
  
  /// <summary>
  /// TitleStyle.
  /// </summary>
  public DocumentModel.Drawings13.Charts.TitleStyle? TitleStyle { get ; set; }
  
  /// <summary>
  /// TrendlineStyle.
  /// </summary>
  public DocumentModel.Drawings13.Charts.TrendlineStyle? TrendlineStyle { get ; set; }
  
  /// <summary>
  /// TrendlineLabel.
  /// </summary>
  public DocumentModel.Drawings13.Charts.TrendlineLabel? TrendlineLabel { get ; set; }
  
  /// <summary>
  /// UpBar.
  /// </summary>
  public DocumentModel.Drawings13.Charts.UpBar? UpBar { get ; set; }
  
  /// <summary>
  /// ValueAxis.
  /// </summary>
  public DocumentModel.Drawings13.Charts.ValueAxis? ValueAxis { get ; set; }
  
  /// <summary>
  /// Wall.
  /// </summary>
  public DocumentModel.Drawings13.Charts.Wall? Wall { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawings13.Charts.OfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
