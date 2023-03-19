namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Chart Class.
/// </summary>
public class Chart: ModelElement
{
  /// <summary>
  ///   Title data and formatting.
  /// </summary>
  public Title? Title { get; set; }

  /// <summary>
  ///   True if the chart automatic title has been deleted..
  /// </summary>
  public Boolean? AutoTitleDeleted { get; set; }

  /// <summary>
  ///   pivot chart format persistence data.
  /// </summary>
  public PivotFormats? PivotFormats { get; set; }

  /// <summary>
  ///   3D view settings.
  /// </summary>
  public View3D? View3D { get; set; }

  /// <summary>
  ///   3D floor formatting.
  /// </summary>
  public Floor? Floor { get; set; }

  /// <summary>
  ///   3D side wall formatting.
  /// </summary>
  public SideWall? SideWall { get; set; }

  /// <summary>
  ///   3D back wall formatting.
  /// </summary>
  public BackWall? BackWall { get; set; }

  /// <summary>
  ///   Plot data and formatting.
  /// </summary>
  public PlotArea? PlotArea { get; set; }

  /// <summary>
  ///   Legend data and formatting.
  /// </summary>
  public Legend? Legend { get; set; }

  /// <summary>
  ///   True if only visible cells are plotted..
  /// </summary>
  public Boolean? PlotVisibleOnly { get; set; }

  /// <summary>
  ///   The way that blank cells are plotted on a chart..
  /// </summary>
  public DisplayBlanksAsKind? DisplayBlanksAs { get; set; }

  /// <summary>
  ///   True if we should render datalabels over the maximum scale.
  /// </summary>
  public Boolean? ShowDataLabelsOverMaximum { get; set; }

  /// <summary>
  ///   Extensibility container.
  /// </summary>
  public ChartExtensionList? ChartExtensionList { get; set; }
}