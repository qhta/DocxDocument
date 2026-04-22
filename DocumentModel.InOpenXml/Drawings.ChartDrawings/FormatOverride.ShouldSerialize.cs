namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class FormatOverride
{
  public bool ShouldSerializeIdx() => Idx is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
