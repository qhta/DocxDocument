namespace DocumentModel.Wordprocessing.Drawings;

#pragma warning disable CS1591

public partial class Shape
{
  public bool ShouldSerializeShapeStyle() => ShapeStyle is not null;
  public bool ShouldSerializeTextBoxInfo2() => TextBoxInfo2 is not null;
  public bool ShouldSerializeLinkedTextBox() => LinkedTextBox is not null;
  public bool ShouldSerializeNormalEastAsianFlow() => NormalEastAsianFlow is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeTextBodyProperties() => TextBodyProperties is not null;
  public bool ShouldSerializeNonVisualDrawingProperties() => NonVisualDrawingProperties is not null;
  public bool ShouldSerializeNonVisualDrawingShapeProperties() => NonVisualDrawingShapeProperties is not null;
  public bool ShouldSerializeNonVisualConnectorProperties() => NonVisualConnectorProperties is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
