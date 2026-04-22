namespace DocumentModel.Drawings.ChartsStyle;

#pragma warning disable CS1591

public partial class ChartStyle
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeAxisTitle() => AxisTitle is not null;
  public bool ShouldSerializeCategoryAxis() => CategoryAxis is not null;
  public bool ShouldSerializeChartArea() => ChartArea is not null;
  public bool ShouldSerializeDataLabel() => DataLabel is not null;
  public bool ShouldSerializeDataLabelCallout() => DataLabelCallout is not null;
  public bool ShouldSerializeDataPoint() => DataPoint is not null;
  public bool ShouldSerializeDataPoint3D() => DataPoint3D is not null;
  public bool ShouldSerializeDataPointLine() => DataPointLine is not null;
  public bool ShouldSerializeDataPointMarker() => DataPointMarker is not null;
  public bool ShouldSerializeMarkerLayoutProperties() => MarkerLayoutProperties is not null;
  public bool ShouldSerializeDataPointWireframe() => DataPointWireframe is not null;
  public bool ShouldSerializeDataTableStyle() => DataTableStyle is not null;
  public bool ShouldSerializeDownBar() => DownBar is not null;
  public bool ShouldSerializeDropLine() => DropLine is not null;
  public bool ShouldSerializeErrorBar() => ErrorBar is not null;
  public bool ShouldSerializeFloor() => Floor is not null;
  public bool ShouldSerializeGridlineMajor() => GridlineMajor is not null;
  public bool ShouldSerializeGridlineMinor() => GridlineMinor is not null;
  public bool ShouldSerializeHiLoLine() => HiLoLine is not null;
  public bool ShouldSerializeLeaderLine() => LeaderLine is not null;
  public bool ShouldSerializeLegendStyle() => LegendStyle is not null;
  public bool ShouldSerializePlotArea() => PlotArea is not null;
  public bool ShouldSerializePlotArea3D() => PlotArea3D is not null;
  public bool ShouldSerializeSeriesAxis() => SeriesAxis is not null;
  public bool ShouldSerializeSeriesLine() => SeriesLine is not null;
  public bool ShouldSerializeTitleStyle() => TitleStyle is not null;
  public bool ShouldSerializeTrendlineStyle() => TrendlineStyle is not null;
  public bool ShouldSerializeTrendlineLabel() => TrendlineLabel is not null;
  public bool ShouldSerializeUpBar() => UpBar is not null;
  public bool ShouldSerializeValueAxis() => ValueAxis is not null;
  public bool ShouldSerializeWall() => Wall is not null;
}
