namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class NonVisualDrawingShapeProperties<T>
{
  public bool ShouldSerializeTextBox() => TextBox is not null;
  public bool ShouldSerializeShapeLocks() => ShapeLocks is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
