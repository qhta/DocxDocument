namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a chart, including title, formatting, 3D view and wall settings, plot area, legend, visibility, blank cell display, and data label options.
/// </summary>
public interface Chart
{
  /// <summary>
  ///   Title data and formatting for the chart.
  /// </summary>
  public Title? Title { get; set; }

  /// <summary>
  ///   Indicates if the chart automatic title has been deleted.
  /// </summary>
  public bool? AutoTitleDeleted { get; set; }

  /// <summary>
  ///   Pivot chart format persistence data.
  /// </summary>
  public PivotFormats? PivotFormats { get; set; }

  /// <summary>
  ///   3D view settings for the chart.
  /// </summary>
  public View3D? View3D { get; set; }

  /// <summary>
  ///   3D floor formatting for the chart.
  /// </summary>
  public Floor? Floor { get; set; }

  /// <summary>
  ///   3D side wall formatting for the chart.
  /// </summary>
  public SideWall? SideWall { get; set; }

  /// <summary>
  ///   3D back wall formatting for the chart.
  /// </summary>
  public BackWall? BackWall { get; set; }

  /// <summary>
  ///   Plot data and formatting for the chart.
  /// </summary>
  public PlotArea? PlotArea { get; set; }

  /// <summary>
  ///   Legend data and formatting for the chart.
  /// </summary>
  public Legend? Legend { get; set; }

  /// <summary>
  ///   Indicates if only visible cells are plotted.
  /// </summary>
  public bool? PlotVisibleOnly { get; set; }

  /// <summary>
  ///   Specifies how blank cells are plotted on the chart.
  /// </summary>
  public DisplayBlanksAsKind? DisplayBlanksAs { get; set; }

  /// <summary>
  ///   Indicates if data labels should be rendered over the maximum scale.
  /// </summary>
  public bool? ShowDataLabelsOverMaximum { get; set; }
}