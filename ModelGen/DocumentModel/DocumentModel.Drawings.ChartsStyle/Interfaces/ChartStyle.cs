namespace DocumentModel.Drawings.ChartsStyle;

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
  public DocumentModel.Drawings.ChartsStyle.AxisTitle? AxisTitle { get ; set; }
  
  /// <summary>
  /// CategoryAxis.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.CategoryAxis? CategoryAxis { get ; set; }
  
  /// <summary>
  /// ChartArea.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.ChartArea? ChartArea { get ; set; }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.DataLabel? DataLabel { get ; set; }
  
  /// <summary>
  /// DataLabelCallout.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.DataLabelCallout? DataLabelCallout { get ; set; }
  
  /// <summary>
  /// DataPoint.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.DataPoint? DataPoint { get ; set; }
  
  /// <summary>
  /// DataPoint3D.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.DataPoint3D? DataPoint3D { get ; set; }
  
  /// <summary>
  /// DataPointLine.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.DataPointLine? DataPointLine { get ; set; }
  
  /// <summary>
  /// DataPointMarker.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.DataPointMarker? DataPointMarker { get ; set; }
  
  /// <summary>
  /// MarkerLayoutProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.MarkerLayoutProperties? MarkerLayoutProperties { get ; set; }
  
  /// <summary>
  /// DataPointWireframe.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.DataPointWireframe? DataPointWireframe { get ; set; }
  
  /// <summary>
  /// DataTableStyle.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.DataTableStyle? DataTableStyle { get ; set; }
  
  /// <summary>
  /// DownBar.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.DownBar? DownBar { get ; set; }
  
  /// <summary>
  /// DropLine.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.DropLine? DropLine { get ; set; }
  
  /// <summary>
  /// ErrorBar.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.ErrorBar? ErrorBar { get ; set; }
  
  /// <summary>
  /// Floor.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.Floor? Floor { get ; set; }
  
  /// <summary>
  /// GridlineMajor.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.GridlineMajor? GridlineMajor { get ; set; }
  
  /// <summary>
  /// GridlineMinor.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.GridlineMinor? GridlineMinor { get ; set; }
  
  /// <summary>
  /// HiLoLine.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.HiLoLine? HiLoLine { get ; set; }
  
  /// <summary>
  /// LeaderLine.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.LeaderLine? LeaderLine { get ; set; }
  
  /// <summary>
  /// LegendStyle.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.LegendStyle? LegendStyle { get ; set; }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.PlotArea? PlotArea { get ; set; }
  
  /// <summary>
  /// PlotArea3D.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.PlotArea3D? PlotArea3D { get ; set; }
  
  /// <summary>
  /// SeriesAxis.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.SeriesAxis? SeriesAxis { get ; set; }
  
  /// <summary>
  /// SeriesLine.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.SeriesLine? SeriesLine { get ; set; }
  
  /// <summary>
  /// TitleStyle.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.TitleStyle? TitleStyle { get ; set; }
  
  /// <summary>
  /// TrendlineStyle.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.TrendlineStyle? TrendlineStyle { get ; set; }
  
  /// <summary>
  /// TrendlineLabel.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.TrendlineLabel? TrendlineLabel { get ; set; }
  
  /// <summary>
  /// UpBar.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.UpBar? UpBar { get ; set; }
  
  /// <summary>
  /// ValueAxis.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.ValueAxis? ValueAxis { get ; set; }
  
  /// <summary>
  /// Wall.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.Wall? Wall { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ChartsStyle.OfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
