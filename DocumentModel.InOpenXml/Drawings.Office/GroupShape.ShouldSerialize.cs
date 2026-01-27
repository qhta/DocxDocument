namespace DocumentModel.Drawings.Office;

#pragma warning disable CS1591

public partial class GroupShape
{
  public bool ShouldSerializeGroupShapeNonVisualProperties() => GroupShapeNonVisualProperties is not null;
  public bool ShouldSerializeGroupShapeProperties() => GroupShapeProperties is not null;
  public bool ShouldSerializeShape() => Shape is not null;
  public bool ShouldSerializeChildGroupShape() => ChildGroupShape is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
