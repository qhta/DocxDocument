namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Chart Class.
/// </summary>
public interface IChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Title data and formatting.
  /// </summary>
  public DocumentModel.Drawing.Charts.ITitle? Title { get ; set; }
  
  /// <summary>
  /// True if the chart automatic title has been deleted..
  /// </summary>
  public System.Boolean? AutoTitleDeleted { get ; set; }
  
  /// <summary>
  /// pivot chart format persistence data.
  /// </summary>
  public DocumentModel.Drawing.Charts.IPivotFormats? PivotFormats { get ; set; }
  
  /// <summary>
  /// 3D view settings.
  /// </summary>
  public DocumentModel.Drawing.Charts.IView3D? View3D { get ; set; }
  
  /// <summary>
  /// 3D floor formatting.
  /// </summary>
  public DocumentModel.Drawing.Charts.IFloor? Floor { get ; set; }
  
  /// <summary>
  /// 3D side wall formatting.
  /// </summary>
  public DocumentModel.Drawing.Charts.ISideWall? SideWall { get ; set; }
  
  /// <summary>
  /// 3D back wall formatting.
  /// </summary>
  public DocumentModel.Drawing.Charts.IBackWall? BackWall { get ; set; }
  
  /// <summary>
  /// Plot data and formatting.
  /// </summary>
  public DocumentModel.Drawing.Charts.IPlotArea? PlotArea { get ; set; }
  
  /// <summary>
  /// Legend data and formatting.
  /// </summary>
  public DocumentModel.Drawing.Charts.ILegend? Legend { get ; set; }
  
  /// <summary>
  /// True if only visible cells are plotted..
  /// </summary>
  public System.Boolean? PlotVisibleOnly { get ; set; }
  
  /// <summary>
  /// The way that blank cells are plotted on a chart..
  /// </summary>
  public DocumentModel.Drawing.Charts.DisplayBlanksAsKind? DisplayBlanksAs { get ; set; }
  
  /// <summary>
  /// True if we should render datalabels over the maximum scale.
  /// </summary>
  public System.Boolean? ShowDataLabelsOverMaximum { get ; set; }
  
  /// <summary>
  /// Extensibility container.
  /// </summary>
  public DocumentModel.Drawing.Charts.IChartExtensionList? ChartExtensionList { get ; set; }
  
}
