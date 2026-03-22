namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class ObjectDefaults
{
  public bool ShouldSerializeShapeDefault() => ShapeDefault is not null;
  public bool ShouldSerializeLineDefault() => LineDefault is not null;
  public bool ShouldSerializeTextDefault() => TextDefault is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
