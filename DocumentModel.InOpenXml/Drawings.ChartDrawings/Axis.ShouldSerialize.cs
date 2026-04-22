namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class Axis
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeHidden() => Hidden is not null;
  public bool ShouldSerializeCategoryAxisScaling() => CategoryAxisScaling is not null;
  public bool ShouldSerializeValueAxisScaling() => ValueAxisScaling is not null;
  public bool ShouldSerializeAxisTitle() => AxisTitle is not null;
  public bool ShouldSerializeAxisUnits() => AxisUnits is not null;
  public bool ShouldSerializeMajorGridlinesGridlines() => MajorGridlinesGridlines is not null;
  public bool ShouldSerializeMinorGridlinesGridlines() => MinorGridlinesGridlines is not null;
  public bool ShouldSerializeMajorTickMarksTickMarks() => MajorTickMarksTickMarks is not null;
  public bool ShouldSerializeMinorTickMarksTickMarks() => MinorTickMarksTickMarks is not null;
  public bool ShouldSerializeTickLabels() => TickLabels is not null;
  public bool ShouldSerializeNumberFormat() => NumberFormat is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeTxPrTextBody() => TxPrTextBody is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
