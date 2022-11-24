namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Chart Class.
/// </summary>
public interface IChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Title data and formatting.
  /// </summary>
  public ITitle? Title { get ; set; }
  
  /// <summary>
  /// True if the chart automatic title has been deleted..
  /// </summary>
  public IAutoTitleDeleted? AutoTitleDeleted { get ; set; }
  
  /// <summary>
  /// pivot chart format persistence data.
  /// </summary>
  public IPivotFormats? PivotFormats { get ; set; }
  
  /// <summary>
  /// 3D view settings.
  /// </summary>
  public IView3D? View3D { get ; set; }
  
  /// <summary>
  /// 3D floor formatting.
  /// </summary>
  public IFloor? Floor { get ; set; }
  
  /// <summary>
  /// 3D side wall formatting.
  /// </summary>
  public ISideWall? SideWall { get ; set; }
  
  /// <summary>
  /// 3D back wall formatting.
  /// </summary>
  public IBackWall? BackWall { get ; set; }
  
  /// <summary>
  /// Plot data and formatting.
  /// </summary>
  public IPlotArea? PlotArea { get ; set; }
  
  /// <summary>
  /// Legend data and formatting.
  /// </summary>
  public ILegend? Legend { get ; set; }
  
  /// <summary>
  /// True if only visible cells are plotted..
  /// </summary>
  public IPlotVisibleOnly? PlotVisibleOnly { get ; set; }
  
  /// <summary>
  /// The way that blank cells are plotted on a chart..
  /// </summary>
  public IDisplayBlanksAs? DisplayBlanksAs { get ; set; }
  
  /// <summary>
  /// True if we should render datalabels over the maximum scale.
  /// </summary>
  public IShowDataLabelsOverMaximum? ShowDataLabelsOverMaximum { get ; set; }
  
  /// <summary>
  /// Extensibility container.
  /// </summary>
  public IChartExtensionList? ChartExtensionList { get ; set; }
  
}
