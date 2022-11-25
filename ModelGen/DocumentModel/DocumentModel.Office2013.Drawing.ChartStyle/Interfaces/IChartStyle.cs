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
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? AxisTitle { get ; set; }
  
  /// <summary>
  /// CategoryAxis.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? CategoryAxis { get ; set; }
  
  /// <summary>
  /// ChartArea.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? ChartArea { get ; set; }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? DataLabel { get ; set; }
  
  /// <summary>
  /// DataLabelCallout.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? DataLabelCallout { get ; set; }
  
  /// <summary>
  /// DataPoint.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? DataPoint { get ; set; }
  
  /// <summary>
  /// DataPoint3D.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? DataPoint3D { get ; set; }
  
  /// <summary>
  /// DataPointLine.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? DataPointLine { get ; set; }
  
  /// <summary>
  /// DataPointMarker.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? DataPointMarker { get ; set; }
  
  /// <summary>
  /// MarkerLayoutProperties.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IMarkerLayoutProperties? MarkerLayoutProperties { get ; set; }
  
  /// <summary>
  /// DataPointWireframe.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? DataPointWireframe { get ; set; }
  
  /// <summary>
  /// DataTableStyle.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? DataTableStyle { get ; set; }
  
  /// <summary>
  /// DownBar.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? DownBar { get ; set; }
  
  /// <summary>
  /// DropLine.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? DropLine { get ; set; }
  
  /// <summary>
  /// ErrorBar.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? ErrorBar { get ; set; }
  
  /// <summary>
  /// Floor.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? Floor { get ; set; }
  
  /// <summary>
  /// GridlineMajor.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? GridlineMajor { get ; set; }
  
  /// <summary>
  /// GridlineMinor.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? GridlineMinor { get ; set; }
  
  /// <summary>
  /// HiLoLine.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? HiLoLine { get ; set; }
  
  /// <summary>
  /// LeaderLine.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? LeaderLine { get ; set; }
  
  /// <summary>
  /// LegendStyle.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? LegendStyle { get ; set; }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? PlotArea { get ; set; }
  
  /// <summary>
  /// PlotArea3D.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? PlotArea3D { get ; set; }
  
  /// <summary>
  /// SeriesAxis.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? SeriesAxis { get ; set; }
  
  /// <summary>
  /// SeriesLine.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? SeriesLine { get ; set; }
  
  /// <summary>
  /// TitleStyle.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? TitleStyle { get ; set; }
  
  /// <summary>
  /// TrendlineStyle.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? TrendlineStyle { get ; set; }
  
  /// <summary>
  /// TrendlineLabel.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? TrendlineLabel { get ; set; }
  
  /// <summary>
  /// UpBar.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? UpBar { get ; set; }
  
  /// <summary>
  /// ValueAxis.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? ValueAxis { get ; set; }
  
  /// <summary>
  /// Wall.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry? Wall { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? OfficeArtExtensionList { get ; set; }
  
}
