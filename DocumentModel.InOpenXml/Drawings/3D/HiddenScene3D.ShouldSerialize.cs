namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class HiddenScene3D
{
  public bool ShouldSerializeCamera() => Camera is not null;
  public bool ShouldSerializeLightRig() => LightRig is not null;
  public bool ShouldSerializeBackdrop() => Backdrop is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
