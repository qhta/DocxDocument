namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a chart in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart?view=word-pia"/>
public partial interface IChart : IInteropObject
{
  /// <summary>
  /// Gets or sets a value indicating whether the chart has a visible title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.hastitle?view=word-pia"/>
  public bool HasTitle { get; set; }

  /// <summary>
  /// Gets the chart title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.charttitle?view=word-pia"/>
  public ChartTitle ChartTitle { get; }

  /// <summary>
  /// Gets or sets the depth of a 3-D chart as a percentage of the chart width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.depthpercent?view=word-pia"/>
  public int DepthPercent { get; set; }

  /// <summary>
  /// Gets or sets the elevation of a 3-D chart view, in degrees.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.elevation?view=word-pia"/>
  public int Elevation { get; set; }

  /// <summary>
  /// Gets or sets the distance between the data series in a 3-D chart, as a percentage of marker width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.gapdepth?view=word-pia"/>
  public int GapDepth { get; set; }

  /// <summary>
  /// Gets or sets the height of a 3-D chart as a percentage of the chart width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.heightpercent?view=word-pia"/>
  public int HeightPercent { get; set; }

  /// <summary>
  /// Gets or sets the perspective for the 3-D chart view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.perspective?view=word-pia"/>
  public int Perspective { get; set; }

  /// <summary>
  /// Gets or sets whether chart axes use right-angle perspective.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.rightangleaxes?view=word-pia"/>
  public object RightAngleAxes { get; set; }

  /// <summary>
  /// Gets or sets the rotation of the 3-D chart view, in degrees.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.rotation?view=word-pia"/>
  public object Rotation { get; set; }

  /// <summary>
  /// Gets or sets how blank cells are plotted on the chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.displayblanksas?view=word-pia"/>
  public DisplayBlanksAs DisplayBlanksAs { get; set; }

  /// <summary>
  /// Gets or sets the chart subtype.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.subtype?view=word-pia"/>
  public int SubType { get; set; }

  /// <summary>
  /// Gets or sets the chart type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.type?view=word-pia"/>
  public int Type { get; set; }

  /// <summary>
  /// Gets the corners object for a 3-D chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.corners?view=word-pia"/>
  public Corners Corners { get; }

  /// <summary>
  /// Gets or sets the chart type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.charttype?view=word-pia"/>
  public object ChartType { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the chart has a data table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.hasdatatable?view=word-pia"/>
  public bool HasDataTable { get; set; }

  /// <summary>
  /// Gets or sets whether data series are plotted by rows or columns.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.plotby?view=word-pia"/>
  public RowCol PlotBy { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the chart has a legend.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.haslegend?view=word-pia"/>
  public bool HasLegend { get; set; }

  /// <summary>
  /// Gets the legend for the chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.legend?view=word-pia"/>
  public Legend Legend { get; }

  /// <summary>
  /// Gets the walls of a 3-D chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.walls?view=word-pia"/>
  public Walls Walls { get; }

  /// <summary>
  /// Gets the floor of a 3-D chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.floor?view=word-pia"/>
  public Floor Floor { get; }

  /// <summary>
  /// Gets the plot area of the chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.plotarea?view=word-pia"/>
  public PlotArea PlotArea { get; }

  /// <summary>
  /// Gets or sets a value indicating whether only visible cells are plotted.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.plotvisibleonly?view=word-pia"/>
  public bool PlotVisibleOnly { get; set; }

  /// <summary>
  /// Gets the chart area.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.chartarea?view=word-pia"/>
  public ChartArea ChartArea { get; }

  /// <summary>
  /// Gets or sets a value indicating whether the chart scales to fit available space.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.autoscaling?view=word-pia"/>
  public bool AutoScaling { get; set; }

  /// <summary>
  /// Gets the chart data table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.datatable?view=word-pia"/>
  public DataTable DataTable { get; }

  /// <summary>
  /// Gets or sets the shape used for bars or columns in a 3-D chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.barshape?view=word-pia"/>
  public BarShape BarShape { get; set; }

  /// <summary>
  /// Gets the side wall of a 3-D chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.sidewall?view=word-pia"/>
  public Walls SideWall { get; }

  /// <summary>
  /// Gets the back wall of a 3-D chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.backwall?view=word-pia"/>
  public Walls BackWall { get; }

  /// <summary>
  /// Gets or sets the chart style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.chartstyle?view=word-pia"/>
  public object ChartStyle { get; set; }

  /// <summary>
  /// Gets the PivotChart layout.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.pivotlayout?view=word-pia"/>
  public object PivotLayout { get; }

  /// <summary>
  /// Gets or sets a value indicating whether the chart has PivotChart fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.haspivotfields?view=word-pia"/>
  public bool HasPivotFields { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether data labels are shown when they exceed the value axis maximum.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.showdatalabelsovermaximum?view=word-pia"/>
  public bool ShowDataLabelsOverMaximum { get; set; }

  /// <summary>
  /// Gets the chart data object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.chartdata?view=word-pia"/>
  public ChartData ChartData { get; }

  /// <summary>
  /// Gets the collection of shapes associated with the chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.shapes?view=word-pia"/>
  public object Shapes { get; }

  /// <summary>
  /// Gets the chart group for 3-D area charts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.area3dgroup?view=word-pia"/>
  public ChartGroup Area3DGroup { get; }

  /// <summary>
  /// Gets the chart group for 3-D bar charts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.bar3dgroup?view=word-pia"/>
  public ChartGroup Bar3DGroup { get; }

  /// <summary>
  /// Gets the chart group for 3-D column charts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.column3dgroup?view=word-pia"/>
  public ChartGroup Column3DGroup { get; }

  /// <summary>
  /// Gets the chart group for 3-D line charts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.line3dgroup?view=word-pia"/>
  public ChartGroup Line3DGroup { get; }

  /// <summary>
  /// Gets the chart group for 3-D pie charts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.pie3dgroup?view=word-pia"/>
  public ChartGroup Pie3DGroup { get; }

  /// <summary>
  /// Gets the chart group for surface charts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.surfacegroup?view=word-pia"/>
  public ChartGroup SurfaceGroup { get; }

  /// <summary>
  /// Gets or sets a value indicating whether report filter field buttons are displayed on a PivotChart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.showreportfilterfieldbuttons?view=word-pia"/>
  public bool ShowReportFilterFieldButtons { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether legend field buttons are displayed on a PivotChart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.showlegendfieldbuttons?view=word-pia"/>
  public bool ShowLegendFieldButtons { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether axis field buttons are displayed on a PivotChart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.showaxisfieldbuttons?view=word-pia"/>
  public bool ShowAxisFieldButtons { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether value field buttons are displayed on a PivotChart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.showvaluefieldbuttons?view=word-pia"/>
  public bool ShowValueFieldButtons { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether all PivotChart field buttons are displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.showallfieldbuttons?view=word-pia"/>
  public bool ShowAllFieldButtons { get; set; }

  /// <summary>
  /// Gets or sets the category label level displayed in the chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.categorylabellevel?view=word-pia"/>
  public CategoryLabelLevel CategoryLabelLevel { get; set; }

  /// <summary>
  /// Gets or sets the series name level displayed in the chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.seriesnamelevel?view=word-pia"/>
  public SeriesNameLevel SeriesNameLevel { get; set; }

  /// <summary>
  /// Gets a value indicating whether the chart includes hidden content.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.hashiddencontent?view=word-pia"/>
  public bool HasHiddenContent { get; }

  /// <summary>
  /// Gets or sets the chart color style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.chartcolor?view=word-pia"/>
  public object ChartColor { get; set; }
}
