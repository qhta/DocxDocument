namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class NonVisualDrawingPropertiesExtension
{
  public bool ShouldSerializeUri() => Uri is not null;
}
