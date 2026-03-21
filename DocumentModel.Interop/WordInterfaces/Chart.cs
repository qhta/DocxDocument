namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a chart in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart?view=word-pia"/>
public partial interface Chart : InteropObject
{
  /// <summary>
  /// The has title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.hastitle?view=word-pia"/>
  public bool HasTitle { get; set; }

  /// <summary>
  /// The chart title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.charttitle?view=word-pia"/>
  public ChartTitle ChartTitle { get; }

  /// <summary>
  /// The depth percent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.depthpercent?view=word-pia"/>
  public int DepthPercent { get; set; }

  /// <summary>
  /// The elevation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.elevation?view=word-pia"/>
  public int Elevation { get; set; }

  /// <summary>
  /// The gap depth.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.gapdepth?view=word-pia"/>
  public int GapDepth { get; set; }

  /// <summary>
  /// The height percent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.heightpercent?view=word-pia"/>
  public int HeightPercent { get; set; }

  /// <summary>
  /// The perspective.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.perspective?view=word-pia"/>
  public int Perspective { get; set; }

  /// <summary>
  /// The right angle axes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.rightangleaxes?view=word-pia"/>
  public object RightAngleAxes { get; set; }

  /// <summary>
  /// The rotation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.rotation?view=word-pia"/>
  public object Rotation { get; set; }

  /// <summary>
  /// The display blanks as.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.displayblanksas?view=word-pia"/>
  public XlDisplayBlanksAs DisplayBlanksAs { get; set; }

  /// <summary>
  /// The sub type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.subtype?view=word-pia"/>
  public int SubType { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.type?view=word-pia"/>
  public int Type { get; set; }

  /// <summary>
  /// The corners.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.corners?view=word-pia"/>
  public Corners Corners { get; }

  /// <summary>
  /// The chart type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.charttype?view=word-pia"/>
  public object ChartType { get; set; }

  /// <summary>
  /// The has data table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.hasdatatable?view=word-pia"/>
  public bool HasDataTable { get; set; }

  /// <summary>
  /// The plot by.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.plotby?view=word-pia"/>
  public XlRowCol PlotBy { get; set; }

  /// <summary>
  /// The has legend.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.haslegend?view=word-pia"/>
  public bool HasLegend { get; set; }

  /// <summary>
  /// The legend.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.legend?view=word-pia"/>
  public Legend Legend { get; }

  /// <summary>
  /// The walls.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.walls?view=word-pia"/>
  public Walls Walls { get; }

  /// <summary>
  /// The floor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.floor?view=word-pia"/>
  public Floor Floor { get; }

  /// <summary>
  /// The plot area.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.plotarea?view=word-pia"/>
  public PlotArea PlotArea { get; }

  /// <summary>
  /// The plot visible only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.plotvisibleonly?view=word-pia"/>
  public bool PlotVisibleOnly { get; set; }

  /// <summary>
  /// The chart area.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.chartarea?view=word-pia"/>
  public ChartArea ChartArea { get; }

  /// <summary>
  /// The auto scaling.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.autoscaling?view=word-pia"/>
  public bool AutoScaling { get; set; }

  /// <summary>
  /// The data table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.datatable?view=word-pia"/>
  public DataTable DataTable { get; }

  /// <summary>
  /// The bar shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.barshape?view=word-pia"/>
  public XlBarShape BarShape { get; set; }

  /// <summary>
  /// The side wall.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.sidewall?view=word-pia"/>
  public Walls SideWall { get; }

  /// <summary>
  /// The back wall.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.backwall?view=word-pia"/>
  public Walls BackWall { get; }

  /// <summary>
  /// The chart style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.chartstyle?view=word-pia"/>
  public object ChartStyle { get; set; }

  /// <summary>
  /// The pivot layout.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.pivotlayout?view=word-pia"/>
  public object PivotLayout { get; }

  /// <summary>
  /// The has pivot fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.haspivotfields?view=word-pia"/>
  public bool HasPivotFields { get; set; }

  /// <summary>
  /// The show data labels over maximum.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.showdatalabelsovermaximum?view=word-pia"/>
  public bool ShowDataLabelsOverMaximum { get; set; }

  /// <summary>
  /// The chart data.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.chartdata?view=word-pia"/>
  public ChartData ChartData { get; }

  /// <summary>
  /// The shapes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.shapes?view=word-pia"/>
  public object Shapes { get; }

  /// <summary>
  /// The area3 dgroup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.area3dgroup?view=word-pia"/>
  public ChartGroup Area3DGroup { get; }

  /// <summary>
  /// The bar3 dgroup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.bar3dgroup?view=word-pia"/>
  public ChartGroup Bar3DGroup { get; }

  /// <summary>
  /// The column3 dgroup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.column3dgroup?view=word-pia"/>
  public ChartGroup Column3DGroup { get; }

  /// <summary>
  /// The line3 dgroup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.line3dgroup?view=word-pia"/>
  public ChartGroup Line3DGroup { get; }

  /// <summary>
  /// The pie3 dgroup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.pie3dgroup?view=word-pia"/>
  public ChartGroup Pie3DGroup { get; }

  /// <summary>
  /// The surface group.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.surfacegroup?view=word-pia"/>
  public ChartGroup SurfaceGroup { get; }

  /// <summary>
  /// The show report filter field buttons.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.showreportfilterfieldbuttons?view=word-pia"/>
  public bool ShowReportFilterFieldButtons { get; set; }

  /// <summary>
  /// The show legend field buttons.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.showlegendfieldbuttons?view=word-pia"/>
  public bool ShowLegendFieldButtons { get; set; }

  /// <summary>
  /// The show axis field buttons.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.showaxisfieldbuttons?view=word-pia"/>
  public bool ShowAxisFieldButtons { get; set; }

  /// <summary>
  /// The show value field buttons.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.showvaluefieldbuttons?view=word-pia"/>
  public bool ShowValueFieldButtons { get; set; }

  /// <summary>
  /// The show all field buttons.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.showallfieldbuttons?view=word-pia"/>
  public bool ShowAllFieldButtons { get; set; }

  /// <summary>
  /// The category label level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.categorylabellevel?view=word-pia"/>
  public XlCategoryLabelLevel CategoryLabelLevel { get; set; }

  /// <summary>
  /// The series name level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.seriesnamelevel?view=word-pia"/>
  public XlSeriesNameLevel SeriesNameLevel { get; set; }

  /// <summary>
  /// The has hidden content.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.hashiddencontent?view=word-pia"/>
  public bool HasHiddenContent { get; }

  /// <summary>
  /// The chart color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.chartcolor?view=word-pia"/>
  public object ChartColor { get; set; }
}
