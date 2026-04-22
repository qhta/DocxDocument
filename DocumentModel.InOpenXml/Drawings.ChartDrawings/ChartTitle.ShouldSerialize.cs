namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class ChartTitle
{
  public bool ShouldSerializePos() => Pos is not null;
  public bool ShouldSerializeAlign() => Align is not null;
  public bool ShouldSerializeOverlay() => Overlay is not null;
  public bool ShouldSerializeText() => Text is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeTxPrTextBody() => TxPrTextBody is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
