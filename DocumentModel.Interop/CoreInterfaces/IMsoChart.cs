
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart?view=office-pia
/// </remarks>
public partial interface IMsoChart
{
  /// <summary>
  /// Gets or sets the `HasTitle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.hastitle?view=office-pia
  /// </remarks>
  public bool HasTitle { get; set; }
  /// <summary>
  /// Gets the `ChartTitle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.charttitle?view=office-pia
  /// </remarks>
  public IMsoChartTitle ChartTitle { get; }
  /// <summary>
  /// Gets or sets the `DepthPercent` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.depthpercent?view=office-pia
  /// </remarks>
  public int DepthPercent { get; set; }
  /// <summary>
  /// Gets or sets the `Elevation` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.elevation?view=office-pia
  /// </remarks>
  public int Elevation { get; set; }
  /// <summary>
  /// Gets or sets the `GapDepth` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.gapdepth?view=office-pia
  /// </remarks>
  public int GapDepth { get; set; }
  /// <summary>
  /// Gets or sets the `HeightPercent` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.heightpercent?view=office-pia
  /// </remarks>
  public int HeightPercent { get; set; }
  /// <summary>
  /// Gets or sets the `Perspective` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.perspective?view=office-pia
  /// </remarks>
  public int Perspective { get; set; }
  /// <summary>
  /// Gets or sets the `RightAngleAxes` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.rightangleaxes?view=office-pia
  /// </remarks>
  public object RightAngleAxes { get; set; }
  /// <summary>
  /// Gets or sets the `Rotation` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.rotation?view=office-pia
  /// </remarks>
  public object Rotation { get; set; }
  /// <summary>
  /// Gets or sets the `DisplayBlanksAs` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.displayblanksas?view=office-pia
  /// </remarks>
  public XlDisplayBlanksAs DisplayBlanksAs { get; set; }
  /// <summary>
  /// Gets or sets the `ProtectData` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.protectdata?view=office-pia
  /// </remarks>
  public bool ProtectData { get; set; }
  /// <summary>
  /// Gets or sets the `ProtectFormatting` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.protectformatting?view=office-pia
  /// </remarks>
  public bool ProtectFormatting { get; set; }
  /// <summary>
  /// Gets or sets the `ProtectGoalSeek` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.protectgoalseek?view=office-pia
  /// </remarks>
  public bool ProtectGoalSeek { get; set; }
  /// <summary>
  /// Gets or sets the `ProtectSelection` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.protectselection?view=office-pia
  /// </remarks>
  public bool ProtectSelection { get; set; }
  /// <summary>
  /// Gets or sets the `ProtectChartObjects` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.protectchartobjects?view=office-pia
  /// </remarks>
  public bool ProtectChartObjects { get; set; }
  /// <summary>
  /// Gets the `ChartGroups` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.chartgroups?view=office-pia
  /// </remarks>
  public object ChartGroups { get; }
  /// <summary>
  /// Gets or sets the `SubType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.subtype?view=office-pia
  /// </remarks>
  public int SubType { get; set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.type?view=office-pia
  /// </remarks>
  public int Type { get; set; }
  /// <summary>
  /// Gets the `Corners` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.corners?view=office-pia
  /// </remarks>
  public IMsoCorners Corners { get; }
  /// <summary>
  /// Gets or sets the `ChartType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.charttype?view=office-pia
  /// </remarks>
  public XlChartType ChartType { get; set; }
  /// <summary>
  /// Gets or sets the `HasDataTable` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.hasdatatable?view=office-pia
  /// </remarks>
  public bool HasDataTable { get; set; }
  /// <summary>
  /// Gets or sets the `PlotBy` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.plotby?view=office-pia
  /// </remarks>
  public XlRowCol PlotBy { get; set; }
  /// <summary>
  /// Gets or sets the `HasLegend` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.haslegend?view=office-pia
  /// </remarks>
  public bool HasLegend { get; set; }
  /// <summary>
  /// Gets the `Legend` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.legend?view=office-pia
  /// </remarks>
  public IMsoLegend Legend { get; }
  /// <summary>
  /// Gets or sets the `HasAxis` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.hasaxis?view=office-pia
  /// </remarks>
  public object HasAxis { get; set; }
  /// <summary>
  /// Gets the `Walls` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.walls?view=office-pia
  /// </remarks>
  public IMsoWalls Walls { get; }
  /// <summary>
  /// Gets the `Floor` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.floor?view=office-pia
  /// </remarks>
  public IMsoFloor Floor { get; }
  /// <summary>
  /// Gets the `PlotArea` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.plotarea?view=office-pia
  /// </remarks>
  public IMsoPlotArea PlotArea { get; }
  /// <summary>
  /// Gets or sets the `PlotVisibleOnly` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.plotvisibleonly?view=office-pia
  /// </remarks>
  public bool PlotVisibleOnly { get; set; }
  /// <summary>
  /// Gets the `ChartArea` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.chartarea?view=office-pia
  /// </remarks>
  public IMsoChartArea ChartArea { get; }
  /// <summary>
  /// Gets or sets the `AutoScaling` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.autoscaling?view=office-pia
  /// </remarks>
  public bool AutoScaling { get; set; }
  /// <summary>
  /// Gets the `DataTable` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.datatable?view=office-pia
  /// </remarks>
  public IMsoDataTable DataTable { get; }
  /// <summary>
  /// Gets or sets the `BarShape` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.barshape?view=office-pia
  /// </remarks>
  public XlBarShape BarShape { get; set; }
  /// <summary>
  /// Gets the `SideWall` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.sidewall?view=office-pia
  /// </remarks>
  public IMsoWalls SideWall { get; }
  /// <summary>
  /// Gets the `BackWall` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.backwall?view=office-pia
  /// </remarks>
  public IMsoWalls BackWall { get; }
  /// <summary>
  /// Gets or sets the `ChartStyle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.chartstyle?view=office-pia
  /// </remarks>
  public object ChartStyle { get; set; }
  /// <summary>
  /// Gets the `PivotLayout` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.pivotlayout?view=office-pia
  /// </remarks>
  public object PivotLayout { get; }
  /// <summary>
  /// Gets or sets the `HasPivotFields` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.haspivotfields?view=office-pia
  /// </remarks>
  public bool HasPivotFields { get; set; }
  /// <summary>
  /// Gets or sets the `ShowDataLabelsOverMaximum` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.showdatalabelsovermaximum?view=office-pia
  /// </remarks>
  public bool ShowDataLabelsOverMaximum { get; set; }
  /// <summary>
  /// Gets the `Selection` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.selection?view=office-pia
  /// </remarks>
  public object Selection { get; }
  /// <summary>
  /// Gets the `ChartData` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.chartdata?view=office-pia
  /// </remarks>
  public IMsoChartData ChartData { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.format?view=office-pia
  /// </remarks>
  public IMsoChartFormat Format { get; }
  /// <summary>
  /// Gets the `Shapes` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.shapes?view=office-pia
  /// </remarks>
  public Shapes Shapes { get; }
  /// <summary>
  /// Gets the `Area3DGroup` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.area3dgroup?view=office-pia
  /// </remarks>
  public IMsoChartGroup Area3DGroup { get; }
  /// <summary>
  /// Gets the `Bar3DGroup` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.bar3dgroup?view=office-pia
  /// </remarks>
  public IMsoChartGroup Bar3DGroup { get; }
  /// <summary>
  /// Gets the `Column3DGroup` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.column3dgroup?view=office-pia
  /// </remarks>
  public IMsoChartGroup Column3DGroup { get; }
  /// <summary>
  /// Gets the `Line3DGroup` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.line3dgroup?view=office-pia
  /// </remarks>
  public IMsoChartGroup Line3DGroup { get; }
  /// <summary>
  /// Gets the `Pie3DGroup` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.pie3dgroup?view=office-pia
  /// </remarks>
  public IMsoChartGroup Pie3DGroup { get; }
  /// <summary>
  /// Gets the `SurfaceGroup` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.surfacegroup?view=office-pia
  /// </remarks>
  public IMsoChartGroup SurfaceGroup { get; }
  /// <summary>
  /// Gets or sets the `ShowReportFilterFieldButtons` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.showreportfilterfieldbuttons?view=office-pia
  /// </remarks>
  public bool ShowReportFilterFieldButtons { get; set; }
  /// <summary>
  /// Gets or sets the `ShowLegendFieldButtons` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.showlegendfieldbuttons?view=office-pia
  /// </remarks>
  public bool ShowLegendFieldButtons { get; set; }
  /// <summary>
  /// Gets or sets the `ShowAxisFieldButtons` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.showaxisfieldbuttons?view=office-pia
  /// </remarks>
  public bool ShowAxisFieldButtons { get; set; }
  /// <summary>
  /// Gets or sets the `ShowValueFieldButtons` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.showvaluefieldbuttons?view=office-pia
  /// </remarks>
  public bool ShowValueFieldButtons { get; set; }
  /// <summary>
  /// Gets or sets the `ShowAllFieldButtons` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.showallfieldbuttons?view=office-pia
  /// </remarks>
  public bool ShowAllFieldButtons { get; set; }
  public bool ProtectChartSheetFormatting { set; }
  /// <summary>
  /// Gets or sets the `CategoryLabelLevel` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.categorylabellevel?view=office-pia
  /// </remarks>
  public XlCategoryLabelLevel CategoryLabelLevel { get; set; }
  /// <summary>
  /// Gets or sets the `SeriesNameLevel` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.seriesnamelevel?view=office-pia
  /// </remarks>
  public XlSeriesNameLevel SeriesNameLevel { get; set; }
  /// <summary>
  /// Gets the `HasHiddenContent` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.hashiddencontent?view=office-pia
  /// </remarks>
  public bool HasHiddenContent { get; }
  /// <summary>
  /// Gets or sets the `ChartColor` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochart.chartcolor?view=office-pia
  /// </remarks>
  public object ChartColor { get; set; }
}
