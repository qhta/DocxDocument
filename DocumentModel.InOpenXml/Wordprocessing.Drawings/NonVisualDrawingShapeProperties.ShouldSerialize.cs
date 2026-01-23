namespace DocumentModel.Wordprocessing.Drawings;

public partial class NonVisualDrawingShapeProperties
{
  public bool ShouldSerializeTextBox() => TextBox is not null;
  public bool ShouldSerializeShapeLocks() => ShapeLocks is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
