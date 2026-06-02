
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart?view=office-pia"/>
public partial interface IMsoChart
{
  /// <summary>
  /// Gets or sets the `HasTitle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.hastitle?view=office-pia"/>
  public bool HasTitle { get; set; }
  /// <summary>
  /// Gets the `ChartTitle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.charttitle?view=office-pia"/>
  public IMsoChartTitle ChartTitle { get; }
  /// <summary>
  /// Gets or sets the `DepthPercent` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.depthpercent?view=office-pia"/>
  public int DepthPercent { get; set; }
  /// <summary>
  /// Gets or sets the `Elevation` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.elevation?view=office-pia"/>
  public int Elevation { get; set; }
  /// <summary>
  /// Gets or sets the `GapDepth` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.gapdepth?view=office-pia"/>
  public int GapDepth { get; set; }
  /// <summary>
  /// Gets or sets the `HeightPercent` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.heightpercent?view=office-pia"/>
  public int HeightPercent { get; set; }
  /// <summary>
  /// Gets or sets the `Perspective` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.perspective?view=office-pia"/>
  public int Perspective { get; set; }
  /// <summary>
  /// Gets or sets the `RightAngleAxes` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.rightangleaxes?view=office-pia"/>
  public object RightAngleAxes { get; set; }
  /// <summary>
  /// Gets or sets the `Rotation` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.rotation?view=office-pia"/>
  public object Rotation { get; set; }
  /// <summary>
  /// Gets or sets the `DisplayBlanksAs` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.displayblanksas?view=office-pia"/>
  public DisplayBlanksAs DisplayBlanksAs { get; set; }
  /// <summary>
  /// Gets or sets the `ProtectData` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.protectdata?view=office-pia"/>
  public bool ProtectData { get; set; }
  /// <summary>
  /// Gets or sets the `ProtectFormatting` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.protectformatting?view=office-pia"/>
  public bool ProtectFormatting { get; set; }
  /// <summary>
  /// Gets or sets the `ProtectGoalSeek` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.protectgoalseek?view=office-pia"/>
  public bool ProtectGoalSeek { get; set; }
  /// <summary>
  /// Gets or sets the `ProtectSelection` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.protectselection?view=office-pia"/>
  public bool ProtectSelection { get; set; }
  /// <summary>
  /// Gets or sets the `ProtectChartObjects` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.protectchartobjects?view=office-pia"/>
  public bool ProtectChartObjects { get; set; }
  /// <summary>
  /// Gets the `ChartGroups` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.chartgroups?view=office-pia"/>
  public object ChartGroups { get; }
  /// <summary>
  /// Gets or sets the `SubType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.subtype?view=office-pia"/>
  public int SubType { get; set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.type?view=office-pia"/>
  public int Type { get; set; }
  /// <summary>
  /// Gets the `Corners` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.corners?view=office-pia"/>
  public IMsoCorners Corners { get; }
  /// <summary>
  /// Gets or sets the `ChartType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.charttype?view=office-pia"/>
  public ChartType ChartType { get; set; }
  /// <summary>
  /// Gets or sets the `HasDataTable` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.hasdatatable?view=office-pia"/>
  public bool HasDataTable { get; set; }
  /// <summary>
  /// Gets or sets the `PlotBy` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.plotby?view=office-pia"/>
  public RowCol PlotBy { get; set; }
  /// <summary>
  /// Gets or sets the `HasLegend` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.haslegend?view=office-pia"/>
  public bool HasLegend { get; set; }
  /// <summary>
  /// Gets the `Legend` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.legend?view=office-pia"/>
  public IMsoLegend Legend { get; }
  /// <summary>
  /// Gets or sets the `HasAxis` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.hasaxis?view=office-pia"/>
  public object HasAxis { get; set; }
  /// <summary>
  /// Gets the `Walls` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.walls?view=office-pia"/>
  public IMsoWalls Walls { get; }
  /// <summary>
  /// Gets the `Floor` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.floor?view=office-pia"/>
  public IMsoFloor Floor { get; }
  /// <summary>
  /// Gets the `PlotArea` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.plotarea?view=office-pia"/>
  public IMsoPlotArea PlotArea { get; }
  /// <summary>
  /// Gets or sets the `PlotVisibleOnly` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.plotvisibleonly?view=office-pia"/>
  public bool PlotVisibleOnly { get; set; }
  /// <summary>
  /// Gets the `ChartArea` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.chartarea?view=office-pia"/>
  public IMsoChartArea ChartArea { get; }
  /// <summary>
  /// Gets or sets the `AutoScaling` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.autoscaling?view=office-pia"/>
  public bool AutoScaling { get; set; }
  /// <summary>
  /// Gets the `DataTable` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.datatable?view=office-pia"/>
  public IMsoDataTable DataTable { get; }
  /// <summary>
  /// Gets or sets the `BarShape` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.barshape?view=office-pia"/>
  public BarShape BarShape { get; set; }
  /// <summary>
  /// Gets the `SideWall` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.sidewall?view=office-pia"/>
  public IMsoWalls SideWall { get; }
  /// <summary>
  /// Gets the `BackWall` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.backwall?view=office-pia"/>
  public IMsoWalls BackWall { get; }
  /// <summary>
  /// Gets or sets the `ChartStyle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.chartstyle?view=office-pia"/>
  public object ChartStyle { get; set; }
  /// <summary>
  /// Gets the `PivotLayout` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.pivotlayout?view=office-pia"/>
  public object PivotLayout { get; }
  /// <summary>
  /// Gets or sets the `HasPivotFields` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.haspivotfields?view=office-pia"/>
  public bool HasPivotFields { get; set; }
  /// <summary>
  /// Gets or sets the `ShowDataLabelsOverMaximum` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.showdatalabelsovermaximum?view=office-pia"/>
  public bool ShowDataLabelsOverMaximum { get; set; }
  /// <summary>
  /// Gets the `Selection` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.selection?view=office-pia"/>
  public object Selection { get; }
  /// <summary>
  /// Gets the `ChartData` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.chartdata?view=office-pia"/>
  public IMsoChartData ChartData { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.format?view=office-pia"/>
  public MsoChartFormat Format { get; }
  /// <summary>
  /// Gets the `Shapes` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.shapes?view=office-pia"/>
  public Shapes Shapes { get; }
  /// <summary>
  /// Gets the `Area3DGroup` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.area3dgroup?view=office-pia"/>
  public MsoChartGroup Area3DGroup { get; }
  /// <summary>
  /// Gets the `Bar3DGroup` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.bar3dgroup?view=office-pia"/>
  public MsoChartGroup Bar3DGroup { get; }
  /// <summary>
  /// Gets the `Column3DGroup` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.column3dgroup?view=office-pia"/>
  public MsoChartGroup Column3DGroup { get; }
  /// <summary>
  /// Gets the `Line3DGroup` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.line3dgroup?view=office-pia"/>
  public MsoChartGroup Line3DGroup { get; }
  /// <summary>
  /// Gets the `Pie3DGroup` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.pie3dgroup?view=office-pia"/>
  public MsoChartGroup Pie3DGroup { get; }
  /// <summary>
  /// Gets the `SurfaceGroup` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.surfacegroup?view=office-pia"/>
  public MsoChartGroup SurfaceGroup { get; }
  /// <summary>
  /// Gets or sets the `ShowReportFilterFieldButtons` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.showreportfilterfieldbuttons?view=office-pia"/>
  public bool ShowReportFilterFieldButtons { get; set; }
  /// <summary>
  /// Gets or sets the `ShowLegendFieldButtons` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.showlegendfieldbuttons?view=office-pia"/>
  public bool ShowLegendFieldButtons { get; set; }
  /// <summary>
  /// Gets or sets the `ShowAxisFieldButtons` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.showaxisfieldbuttons?view=office-pia"/>
  public bool ShowAxisFieldButtons { get; set; }
  /// <summary>
  /// Gets or sets the `ShowValueFieldButtons` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.showvaluefieldbuttons?view=office-pia"/>
  public bool ShowValueFieldButtons { get; set; }
  /// <summary>
  /// Gets or sets the `ShowAllFieldButtons` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.showallfieldbuttons?view=office-pia"/>
  public bool ShowAllFieldButtons { get; set; }
  public bool ProtectChartSheetFormatting { set; }
  /// <summary>
  /// Gets or sets the `CategoryLabelLevel` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.categorylabellevel?view=office-pia"/>
  public CategoryLabelLevel CategoryLabelLevel { get; set; }
  /// <summary>
  /// Gets or sets the `SeriesNameLevel` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.seriesnamelevel?view=office-pia"/>
  public SeriesNameLevel SeriesNameLevel { get; set; }
  /// <summary>
  /// Gets the `HasHiddenContent` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.hashiddencontent?view=office-pia"/>
  public bool HasHiddenContent { get; }
  /// <summary>
  /// Gets or sets the `ChartColor` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.chartcolor?view=office-pia"/>
  public object ChartColor { get; set; }
}

