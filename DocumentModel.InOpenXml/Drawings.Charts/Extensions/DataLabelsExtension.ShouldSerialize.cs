namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class DataLabelsExtension
{
  public bool ShouldSerializeChartText() => ChartText is not null;
  public bool ShouldSerializeDataLabelFieldTable() => DataLabelFieldTable is not null;
  public bool ShouldSerializeShowDataLabelsRange() => ShowDataLabelsRange is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeLayout() => Layout is not null;
  public bool ShouldSerializeShowLeaderLines() => ShowLeaderLines is not null;
  public bool ShouldSerializeLeaderLines() => LeaderLines is not null;
}
