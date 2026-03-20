
namespace DocumentModel.Interop.Core;

public partial interface IMsoChart
{
  public bool HasTitle { get; set; }
  public IMsoChartTitle ChartTitle { get; }
  public int DepthPercent { get; set; }
  public int Elevation { get; set; }
  public int GapDepth { get; set; }
  public int HeightPercent { get; set; }
  public int Perspective { get; set; }
  public object RightAngleAxes { get; set; }
  public object Rotation { get; set; }
  public XlDisplayBlanksAs DisplayBlanksAs { get; set; }
  public bool ProtectData { get; set; }
  public bool ProtectFormatting { get; set; }
  public bool ProtectGoalSeek { get; set; }
  public bool ProtectSelection { get; set; }
  public bool ProtectChartObjects { get; set; }
  public object ChartGroups { get; }
  public int SubType { get; set; }
  public int Type { get; set; }
  public IMsoCorners Corners { get; }
  public XlChartType ChartType { get; set; }
  public bool HasDataTable { get; set; }
  public XlRowCol PlotBy { get; set; }
  public bool HasLegend { get; set; }
  public IMsoLegend Legend { get; }
  public object HasAxis { get; set; }
  public IMsoWalls Walls { get; }
  public IMsoFloor Floor { get; }
  public IMsoPlotArea PlotArea { get; }
  public bool PlotVisibleOnly { get; set; }
  public IMsoChartArea ChartArea { get; }
  public bool AutoScaling { get; set; }
  public IMsoDataTable DataTable { get; }
  public XlBarShape BarShape { get; set; }
  public IMsoWalls SideWall { get; }
  public IMsoWalls BackWall { get; }
  public object ChartStyle { get; set; }
  public object PivotLayout { get; }
  public bool HasPivotFields { get; set; }
  public bool ShowDataLabelsOverMaximum { get; set; }
  public object Selection { get; }
  public IMsoChartData ChartData { get; }
  public IMsoChartFormat Format { get; }
  public Shapes Shapes { get; }
  public IMsoChartGroup Area3DGroup { get; }
  public IMsoChartGroup Bar3DGroup { get; }
  public IMsoChartGroup Column3DGroup { get; }
  public IMsoChartGroup Line3DGroup { get; }
  public IMsoChartGroup Pie3DGroup { get; }
  public IMsoChartGroup SurfaceGroup { get; }
  public bool ShowReportFilterFieldButtons { get; set; }
  public bool ShowLegendFieldButtons { get; set; }
  public bool ShowAxisFieldButtons { get; set; }
  public bool ShowValueFieldButtons { get; set; }
  public bool ShowAllFieldButtons { get; set; }
  public bool ProtectChartSheetFormatting { set; }
  public XlCategoryLabelLevel CategoryLabelLevel { get; set; }
  public XlSeriesNameLevel SeriesNameLevel { get; set; }
  public bool HasHiddenContent { get; }
  public object ChartColor { get; set; }
}
