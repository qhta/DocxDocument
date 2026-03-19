namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a chart in a document.
/// </summary>
public partial interface Chart : InteropObject
{
  /// <summary>
  /// The has title.
  /// </summary>
  public bool HasTitle { get; set; }

  /// <summary>
  /// The chart title.
  /// </summary>
  public ChartTitle ChartTitle { get; }

  /// <summary>
  /// The depth percent.
  /// </summary>
  public int DepthPercent { get; set; }

  /// <summary>
  /// The elevation.
  /// </summary>
  public int Elevation { get; set; }

  /// <summary>
  /// The gap depth.
  /// </summary>
  public int GapDepth { get; set; }

  /// <summary>
  /// The height percent.
  /// </summary>
  public int HeightPercent { get; set; }

  /// <summary>
  /// The perspective.
  /// </summary>
  public int Perspective { get; set; }

  /// <summary>
  /// The right angle axes.
  /// </summary>
  public object RightAngleAxes { get; set; }

  /// <summary>
  /// The rotation.
  /// </summary>
  public object Rotation { get; set; }

  /// <summary>
  /// The display blanks as.
  /// </summary>
  public XlDisplayBlanksAs DisplayBlanksAs { get; set; }

  /// <summary>
  /// The sub type.
  /// </summary>
  public int SubType { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  public int Type { get; set; }

  /// <summary>
  /// The corners.
  /// </summary>
  public Corners Corners { get; }

  /// <summary>
  /// The chart type.
  /// </summary>
  public object ChartType { get; set; }

  /// <summary>
  /// The has data table.
  /// </summary>
  public bool HasDataTable { get; set; }

  /// <summary>
  /// The plot by.
  /// </summary>
  public XlRowCol PlotBy { get; set; }

  /// <summary>
  /// The has legend.
  /// </summary>
  public bool HasLegend { get; set; }

  /// <summary>
  /// The legend.
  /// </summary>
  public Legend Legend { get; }

  /// <summary>
  /// The walls.
  /// </summary>
  public Walls Walls { get; }

  /// <summary>
  /// The floor.
  /// </summary>
  public Floor Floor { get; }

  /// <summary>
  /// The plot area.
  /// </summary>
  public PlotArea PlotArea { get; }

  /// <summary>
  /// The plot visible only.
  /// </summary>
  public bool PlotVisibleOnly { get; set; }

  /// <summary>
  /// The chart area.
  /// </summary>
  public ChartArea ChartArea { get; }

  /// <summary>
  /// The auto scaling.
  /// </summary>
  public bool AutoScaling { get; set; }

  /// <summary>
  /// The data table.
  /// </summary>
  public DataTable DataTable { get; }

  /// <summary>
  /// The bar shape.
  /// </summary>
  public XlBarShape BarShape { get; set; }

  /// <summary>
  /// The side wall.
  /// </summary>
  public Walls SideWall { get; }

  /// <summary>
  /// The back wall.
  /// </summary>
  public Walls BackWall { get; }

  /// <summary>
  /// The chart style.
  /// </summary>
  public object ChartStyle { get; set; }

  /// <summary>
  /// The pivot layout.
  /// </summary>
  public object PivotLayout { get; }

  /// <summary>
  /// The has pivot fields.
  /// </summary>
  public bool HasPivotFields { get; set; }

  /// <summary>
  /// The show data labels over maximum.
  /// </summary>
  public bool ShowDataLabelsOverMaximum { get; set; }

  /// <summary>
  /// The chart data.
  /// </summary>
  public ChartData ChartData { get; }

  /// <summary>
  /// The shapes.
  /// </summary>
  public object Shapes { get; }

  /// <summary>
  /// The area3 dgroup.
  /// </summary>
  public ChartGroup Area3DGroup { get; }

  /// <summary>
  /// The bar3 dgroup.
  /// </summary>
  public ChartGroup Bar3DGroup { get; }

  /// <summary>
  /// The column3 dgroup.
  /// </summary>
  public ChartGroup Column3DGroup { get; }

  /// <summary>
  /// The line3 dgroup.
  /// </summary>
  public ChartGroup Line3DGroup { get; }

  /// <summary>
  /// The pie3 dgroup.
  /// </summary>
  public ChartGroup Pie3DGroup { get; }

  /// <summary>
  /// The surface group.
  /// </summary>
  public ChartGroup SurfaceGroup { get; }

  /// <summary>
  /// The show report filter field buttons.
  /// </summary>
  public bool ShowReportFilterFieldButtons { get; set; }

  /// <summary>
  /// The show legend field buttons.
  /// </summary>
  public bool ShowLegendFieldButtons { get; set; }

  /// <summary>
  /// The show axis field buttons.
  /// </summary>
  public bool ShowAxisFieldButtons { get; set; }

  /// <summary>
  /// The show value field buttons.
  /// </summary>
  public bool ShowValueFieldButtons { get; set; }

  /// <summary>
  /// The show all field buttons.
  /// </summary>
  public bool ShowAllFieldButtons { get; set; }

  /// <summary>
  /// The category label level.
  /// </summary>
  public XlCategoryLabelLevel CategoryLabelLevel { get; set; }

  /// <summary>
  /// The series name level.
  /// </summary>
  public XlSeriesNameLevel SeriesNameLevel { get; set; }

  /// <summary>
  /// The has hidden content.
  /// </summary>
  public bool HasHiddenContent { get; }

  /// <summary>
  /// The chart color.
  /// </summary>
  public object ChartColor { get; set; }
}
