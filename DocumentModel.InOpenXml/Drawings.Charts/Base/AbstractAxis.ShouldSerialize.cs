namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class AbstractAxis<T> 
{
  public bool ShouldSerializeAxisId() => AxisId is not null;
  public bool ShouldSerializeScaling() => Scaling is not null;
  public bool ShouldSerializeDelete() => Delete is not null;
  public bool ShouldSerializeAxisPosition() => AxisPosition is not null;
  public bool ShouldSerializeMajorGridlines() => MajorGridlines is not null;
  public bool ShouldSerializeMinorGridlines() => MinorGridlines is not null;
  public bool ShouldSerializeTitle() => Title is not null;
  public bool ShouldSerializeNumberingFormat() => NumberingFormat is not null;
  public bool ShouldSerializeMajorTickMark() => MajorTickMark is not null;
  public bool ShouldSerializeMinorTickMark() => MinorTickMark is not null;
  public bool ShouldSerializeTickLabelPosition() => TickLabelPosition is not null;
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
  public bool ShouldSerializeTextProperties() => TextProperties is not null;
  public bool ShouldSerializeCrossingAxis() => CrossingAxis is not null;
  public bool ShouldSerializeCrosses() => Crosses is not null;
  public bool ShouldSerializeCrossesAt() => CrossesAt is not null;
}
