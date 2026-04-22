namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class Legend
{
  public bool ShouldSerializePos() => Pos is not null;
  public bool ShouldSerializeAlign() => Align is not null;
  public bool ShouldSerializeOverlay() => Overlay is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeTxPrTextBody() => TxPrTextBody is not null;
}
