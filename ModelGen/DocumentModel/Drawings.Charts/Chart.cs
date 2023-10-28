namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Chart Class.
/// </summary>
public partial class Chart
{
  
  /// <summary>
  ///   Title data and formatting.
  /// </summary>
  public DMDC.Title? Title { get; set; }
  
  
  /// <summary>
  ///   True if the chart automatic title has been deleted..
  /// </summary>
  public DMDC.AutoTitleDeleted? AutoTitleDeleted { get; set; }
  
  
  /// <summary>
  ///   pivot chart format persistence data.
  /// </summary>
  public DMDC.PivotFormats? PivotFormats { get; set; }
  
  
  /// <summary>
  ///   3D view settings.
  /// </summary>
  public DMDC.View3D? View3D { get; set; }
  
  
  /// <summary>
  ///   3D floor formatting.
  /// </summary>
  public DMDC.Floor? Floor { get; set; }
  
  
  /// <summary>
  ///   3D side wall formatting.
  /// </summary>
  public DMDC.SideWall? SideWall { get; set; }
  
  
  /// <summary>
  ///   3D back wall formatting.
  /// </summary>
  public DMDC.BackWall? BackWall { get; set; }
  
  
  /// <summary>
  ///   Plot data and formatting.
  /// </summary>
  public DMDC.PlotArea? PlotArea { get; set; }
  
  
  /// <summary>
  ///   Legend data and formatting.
  /// </summary>
  public DMDC.Legend? Legend { get; set; }
  
  
  /// <summary>
  ///   True if only visible cells are plotted..
  /// </summary>
  public DMDC.PlotVisibleOnly? PlotVisibleOnly { get; set; }
  
  
  /// <summary>
  ///   The way that blank cells are plotted on a chart..
  /// </summary>
  public DMDC.DisplayBlanksAsKind? DisplayBlanksAs { get; set; }
  
  
  /// <summary>
  ///   True if we should render datalabels over the maximum scale.
  /// </summary>
  public DMDC.ShowDataLabelsOverMaximum? ShowDataLabelsOverMaximum { get; set; }
  
  
  /// <summary>
  ///   Extensibility container.
  /// </summary>
  public DMDC.ChartExtensionList? ChartExtensionList { get; set; }
  
}
