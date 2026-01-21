namespace DocumentModel.Wordprocessing.Drawings;

public partial class Scene3D
{
  public bool ShouldSerializeCamera() => Camera is not null;
  public bool ShouldSerializeLightRig() => LightRig is not null;
}
