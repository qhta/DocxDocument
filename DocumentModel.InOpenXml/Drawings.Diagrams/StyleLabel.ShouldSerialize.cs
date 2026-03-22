namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591
public partial class StyleLabel
{
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeScene3D() => Scene3D is not null;
  public bool ShouldSerializeShape3D() => Shape3D is not null;
  public bool ShouldSerializeTextProperties() => TextProperties is not null;
  public bool ShouldSerializeStyle() => Style is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
