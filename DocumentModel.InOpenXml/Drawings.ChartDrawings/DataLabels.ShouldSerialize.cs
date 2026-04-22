namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class DataLabels
{
  public bool ShouldSerializePos() => Pos is not null;
  public bool ShouldSerializeNumberFormat() => NumberFormat is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeTxPrTextBody() => TxPrTextBody is not null;
  public bool ShouldSerializeDataLabelVisibilities() => DataLabelVisibilities is not null;
  public bool ShouldSerializeSeparator() => !String.IsNullOrEmpty(Separator);
  public bool ShouldSerializeHiddenDataLabels() => HiddenDataLabels is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
