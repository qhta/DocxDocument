namespace DocumentModel.Drawings;

public partial class NonVisualDrawingPropertiesExtension
{
  public bool ShouldSerializeUri() => Uri is not null;
}
